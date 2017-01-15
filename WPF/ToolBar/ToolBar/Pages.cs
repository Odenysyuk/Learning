using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ToolBar
{
    class Pages
    {
        Dictionary<String, Page> ListOfPages;
        Page CurrentPage;

        public Pages()
        {
            CurrentPage = new Page();                                  
        }

        public void AddPage(Page NewPage)
        {
            CurrentPage = NewPage;
            ListOfPages = new Dictionary<String, Page>();
            ListOfPages.Add(CurrentPage.PageGiud, CurrentPage);
        }

        public void DeletePage(String key)
        {
            CurrentPage = null;
            ListOfPages.Remove(key);
        }
        public void Save()
        {
            if (String.IsNullOrEmpty(CurrentPage.Path))
            {
                SaveAs();
            }
            else
            {
                Save(CurrentPage.Path);
            }

        }

        public void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.rtf";
            sfd.Filter = "RTF Files|*.rtf";
            if (sfd.ShowDialog() == true)
            {
                Save(sfd.FileName);
            }
        }

        void Save(String path)
        {
            RichTextBox richTextBox1 = CurrentPage.Text;
            TextRange t = new TextRange(richTextBox1.Document.ContentStart,
                                   richTextBox1.Document.ContentEnd);
            FileStream file = new FileStream(path, FileMode.OpenOrCreate);
            t.Save(file, System.Windows.DataFormats.Rtf);
            file.Close();
        }

        public void Undo()
        {
            if (CurrentPage != null)
                CurrentPage.Text.Undo();
        }

        public void Redo()
        {
            if (CurrentPage != null)
                CurrentPage.Text.Redo();
        }

        public void Copy()
        {
            if (CurrentPage != null)
                CurrentPage.Text.Copy();
        }

        public void Cut()
        {
            if (CurrentPage != null)
                CurrentPage.Text.Cut();
        }

        public void Paste()
        {
            if (CurrentPage != null)
                CurrentPage.Text.Paste();
        }

        public void Help()
        {
            MessageBox.Show("This notepad for homework 3. Version 1.0.0", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }


    }
}
