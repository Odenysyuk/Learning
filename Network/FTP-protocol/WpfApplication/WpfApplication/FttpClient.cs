using System;
using System.Collections.Generic;
using System.Net;
using System.IO;

namespace WpfApplication
{
    public class FttpClient
    {
        FtpWebRequest ftpRequest;
        FtpWebResponse ftpResponse;
        public String User { get; set; }
        public String Password { get; set; }
        public String Host { get; set; }
        public Boolean UseSSL { get; set; }


        public string[] ListDirectory(string path)
        {
            if (path == null || path == "")
            {
                path = "/";
            }

            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + Host + path);
            ftpRequest.Credentials = new NetworkCredential(User, Password);
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            ftpRequest.EnableSsl = UseSSL;
            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

            string content = "";

            StreamReader sr = new StreamReader(ftpResponse.GetResponseStream(), System.Text.Encoding.ASCII);
            content = sr.ReadToEnd();
            sr.Close();
            ftpResponse.Close();

            string[] parser = content.Split('\n');
            return parser;

            //DirectoryListParser parser = new DirectoryListParser(content);
            //return parser.FullListing;
        }

        public void DownloadFile(string path, string fileName)
        {

            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + Host + path + "/" + fileName);

            ftpRequest.Credentials = new NetworkCredential(User, Password);
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;

            ftpRequest.EnableSsl = UseSSL;
            FileStream downloadedFile = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);

            ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            Stream responseStream = ftpResponse.GetResponseStream();

            byte[] buffer = new byte[1024];
            int size = 0;

            while ((size = responseStream.Read(buffer, 0, 1024)) > 0)
            {
                downloadedFile.Write(buffer, 0, size);

            }
            ftpResponse.Close();
            downloadedFile.Close();
            responseStream.Close();
        }
   

        public void UploadFile(string path, string fileName)
        {

            string shortName = fileName.Remove(0, fileName.LastIndexOf(@"\") + 1);            

            FileStream uploadedFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + Host + path + shortName);
            ftpRequest.Credentials = new NetworkCredential(User, Password);
            ftpRequest.EnableSsl = UseSSL;
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;

        
            byte[] file_to_bytes = new byte[uploadedFile.Length];
            uploadedFile.Read(file_to_bytes, 0, file_to_bytes.Length);

            uploadedFile.Close();

    
            Stream writer = ftpRequest.GetRequestStream();

            writer.Write(file_to_bytes, 0, file_to_bytes.Length);
            writer.Close();
        }


        public void DeleteFile(string path)
        {
            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + Host + path);
            ftpRequest.Credentials = new NetworkCredential(User, Password);
            ftpRequest.EnableSsl = UseSSL;
            ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;
            FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpResponse.Close();
        }

        public void CreateDirectory(string path, string folderName)
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + Host + path + folderName);

            ftpRequest.Credentials = new NetworkCredential(User, Password);
            ftpRequest.EnableSsl = UseSSL;
            ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;

            FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpResponse.Close();
        }
        

        public void RemoveDirectory(string path)
        {
            string filename = path;
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + Host + path);
            ftpRequest.Credentials = new NetworkCredential(User, Password);
            ftpRequest.EnableSsl = UseSSL;
            ftpRequest.Method = WebRequestMethods.Ftp.RemoveDirectory;

            FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
            ftpResponse.Close();
        }
    }

    public struct FileStruct
    {
        public string Flags;
        public string Owner;
        public bool IsDirectory;
        public string CreateTime;
        public string Name;
    }
    
    public class DirectoryListParser
    {
        private List<FileStruct> _myListArray;

        public FileStruct[] FullListing
        {
            get
            {
                return _myListArray.ToArray();
            }
        }

        public FileStruct[] FileList
        {
            get
            {
                List<FileStruct> _fileList = new List<FileStruct>();
                foreach (FileStruct thisstruct in _myListArray)
                {
                    if (!thisstruct.IsDirectory)
                    {
                        _fileList.Add(thisstruct);
                    }
                }
                return _fileList.ToArray();
            }
        }

        public FileStruct[] DirectoryList
        {
            get
            {
                List<FileStruct> _dirList = new List<FileStruct>();
                foreach (FileStruct thisstruct in _myListArray)
                {
                    if (thisstruct.IsDirectory)
                    {
                        _dirList.Add(thisstruct);
                    }
                }
                return _dirList.ToArray();
            }
        }

        public DirectoryListParser(string responseString)
        {
            _myListArray = GetList(responseString);
        }

        private List<FileStruct> GetList(string datastring)
        {
            List<FileStruct> myListArray = new List<FileStruct>();
            string[] dataRecords = datastring.Split('\n');
                  
            foreach (string s in dataRecords)
            {
                if (String.IsNullOrEmpty(s))
                    continue;          
                FileStruct f = new FileStruct();
                f.Name = "..";
                    f = ParseFileStruct(s);         
                if (f.Name != "" && f.Name != "." && f.Name != "..")
                {
                    myListArray.Add(f);
                }
                    
            }
            return myListArray;
        }
            
        private FileStruct ParseFileStruct(string Record)
        {
                

            FileStruct f = new FileStruct();
            string processstr = Record.Trim();
            
            string dateStr = processstr.Substring(0, 8);
            processstr = (processstr.Substring(8, processstr.Length - 8)).Trim();
    
            string timeStr = processstr.Substring(0, 7);
            processstr = (processstr.Substring(7, processstr.Length - 7)).Trim();
            f.CreateTime = dateStr + " " + timeStr;
    
            if (processstr.Substring(0, 5) == "<DIR>")
            {
                f.IsDirectory = true;
                processstr = (processstr.Substring(5, processstr.Length - 5)).Trim();
            }
            else
            {
                string[] strs = processstr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                processstr = strs[1];
                f.IsDirectory = false;
            }

            f.Name = processstr;
            return f;
        }
                             
         
       }
  }
