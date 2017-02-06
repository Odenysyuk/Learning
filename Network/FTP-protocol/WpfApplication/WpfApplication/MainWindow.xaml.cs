using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FttpClient ftp = new FttpClient();
        String serverDir = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        //Connect to ftp
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Host.Text == "")
            {
                MessageBox.Show("Name server cannot be full");
                return;
            }

            ftp.Host = Host.Text;
            ftp.User = User.Text;
            ftp.Password = Password.Text;

            string[] FileList = ftp.ListDirectory("");

            try
            {
                foreach (String s in FileList)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Content = s;     
                    listView2.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           

        }

        private void CreateFolder(object sender, RoutedEventArgs e)
        {
            if (listView2.SelectedItems[0] == null)
            {
                MessageBox.Show("Select some item of viewer");
            }
            try
            {
                string directory = listView2.SelectedItems[0].ToString().Trim();
                ftp.CreateDirectory(serverDir + "/" + directory, "new folder");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveFolder(object sender, RoutedEventArgs e)
        {
            if (listView2.SelectedItems[0] == null)
            {
                MessageBox.Show("Select some item of viewer");
            }
            try
            {
                string directory = listView2.SelectedItems[0].ToString().Trim();
                ftp.RemoveDirectory(serverDir + "/" + directory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CreateFile(object sender, RoutedEventArgs e)
        {
            if (listView2.SelectedItems[0] == null)
            {
                MessageBox.Show("Select some item of viewer");
            }
            try
            {
                string directory = listView2.SelectedItems[0].ToString().Trim();
                ftp.CreateDirectory(serverDir, directory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveFile(object sender, RoutedEventArgs e)
        {
            if (listView2.SelectedItems[0] == null)
            {
                MessageBox.Show("Select some item of viewer");
            }
            try
            {
                string directory = listView2.SelectedItems[0].ToString().Trim();
                ftp.DeleteFile(serverDir + "/" + directory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Upload_File(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog1.ShowDialog() != true) return;
            string file = openFileDialog1.FileName;
            try
            {
                ftp.UploadFile(serverDir, file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Download_File(object sender, RoutedEventArgs e)
        {
            if (listView2.SelectedItems[0] == null)
            {
                MessageBox.Show("Select some item of viewer");
            }
            try
            {
                string directory = listView2.SelectedItems[0].ToString().Trim();
                ftp.DownloadFile(serverDir, directory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
