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
    class Page
    {
        private RichTextBox text;
        private string path;
        private Boolean hasModification;
        private Guid pageGuid;
        public String SafeFileName { get; set; }


        public string Path {
            get { return path; }
            set
            {
              
                if (String.IsNullOrEmpty(value))
                    return;

                TextRange range = new TextRange(text.Document.ContentStart,
                                text.Document.ContentEnd);
                using (var fStream = new FileStream(value,  FileMode.OpenOrCreate))
                {
                    range.Load(fStream, DataFormats.Rtf);
                    fStream.Close();
                }
                path = value;                
            }
        }
        public RichTextBox Text {
            get
            {
                if (text == null)
                    return new RichTextBox();
                return text;
            }
            set
            {

                text = value;
                hasModification = true;

            }
        }
        public String PageGiud
        {
            get
            {
                if (pageGuid.ToString() == "")
                    pageGuid = Guid.NewGuid();
                return "tab" + pageGuid.ToString().Replace('-', '_');
            }

        }
        public Page(string path, string SafeFileName)
        {
            if (String.IsNullOrEmpty(path))
                return;
            this.Text = new RichTextBox();
            this.pageGuid = Guid.NewGuid();
            this.Path = path;
            this.SafeFileName = SafeFileName;

        }
        public Page()
        {
            this.Text = new RichTextBox();
            this.hasModification = true;
            this.pageGuid = Guid.NewGuid();
        }

    }
}
