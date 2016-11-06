using System;
using System.Text;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {


            Boolean exit = false;

            Int32 choise;

            while (!exit) {

                Console.WriteLine("Menu\n 0 - Exit\n 1 - Open file;\n 2 - Open file and save;\n 3 - Create folder; \n 4 - Delete folder;\n 5 - Delete file; \n 6 -View folder and file");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        OpenFileAndShow();
                        break;
                    case 2:
                        OpenCreateFileAndShow();
                        break;
                    case 3:
                        CreateFolder();
                        break;
                    case 4:
                        DeleteFolder();
                        break;
                    case 5:
                        DeleteFile();
                        break;
                    case 6:
                        ViewFolderFile();
                        break;
                    default:
                        Console.WriteLine("Not correct choise! Try again!!!");
                        continue;
                }


            }
        }

        static void OpenFileAndShow()
        {

            Console.WriteLine("Enter way to file:");
            String way = Console.ReadLine();

           try
           {
                using (FileStream fs = new FileStream(way, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    StreamReader read = new StreamReader(fs, Encoding.UTF8);
                    Console.WriteLine(read.ReadToEnd());
                    fs.Dispose();
                }
           }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
              }
        }

        static void OpenCreateFileAndShow()
        {

            Console.WriteLine("Enter way to file:");
            String way = Console.ReadLine();

            try
            {
                using (FileStream fs = new FileStream(way, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read))
                {

                    fs.Seek(0, SeekOrigin.End);   

                    StreamWriter write = new StreamWriter(way, false);
                    Console.WriteLine("End text:");
                    write.WriteLine(Console.ReadLine());

                    fs.Dispose();

                    StreamReader read = new StreamReader(fs, Encoding.UTF8);
                    Console.WriteLine(read.ReadToEnd());

                    fs.Dispose();

                    
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void CreateFolder()
        {

            Console.WriteLine("Enter way to file:");
            String way = Console.ReadLine();

            try
            {
                DirectoryInfo dr = new DirectoryInfo(way);
                dr.Create();
                FileInfo fl = new FileInfo(dr.FullName + "\\file.txt");
                fl.Create();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void DeleteFolder()
        {

            Console.WriteLine("Enter way to file:");
            String way = Console.ReadLine();

            try
            {
                DirectoryInfo dr = new DirectoryInfo(way);
                dr.Delete(true);

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void DeleteFile()
        {

            Console.WriteLine("Enter way to file:");
            String way = Console.ReadLine();

            try
            {
                FileInfo dr = new FileInfo(way);
                dr.Delete();

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void ViewFolderFile()
        {

            Console.WriteLine("Enter way to file:");
            String way = Console.ReadLine();

            try
            {
                DirectoryInfo dr = new DirectoryInfo(way);

                if (dr.Exists == false)
                    return;

                ShowDirectory(dr, 0);               

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void ShowDirectory(DirectoryInfo dr, Int32 count) {
            ++count;
    
            if (dr.Exists == false)
                return;

            String formate = "";
            for (int i = 0; i < count; i++)
                formate = formate + String.Format("\t");

            FileInfo []temp = dr.GetFiles();
            foreach(FileInfo el in temp)
            {
                Console.WriteLine("{0}{1}", formate, el.Name);
            }

            DirectoryInfo[] dir_temp = dr.GetDirectories();
            foreach (DirectoryInfo el in dir_temp)
            {
                Console.WriteLine("{0}{1}", formate, el.Name);
                ShowDirectory(el, count);
            }

        }

    }

}
