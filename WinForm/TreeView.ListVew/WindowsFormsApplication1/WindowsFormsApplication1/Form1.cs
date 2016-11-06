using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            string[] dir = Directory.GetDirectories(@"d:\");
            for (int i = 2; i < dir.Length; ++i)
            {
                if (i != 25)//Access rights issue (not needed)
                {
                    TreeNode node = new TreeNode(dir[i].Substring(3));
                    string[] subDir = Directory.GetDirectories(dir[i]);
                    for (int j = 0; j < subDir.Length; ++j)
                        node.Nodes.Add(new TreeNode(subDir[j].Substring(subDir[j].LastIndexOf('\\')+1, subDir[j].Length - subDir[j].LastIndexOf('\\')-1)));
                    treeView1.Nodes.Add(node);
                }
            }

            listView1.Columns.Add("Name");
            listView1.Columns.Add("Date modified");
            listView1.Columns.Add("Size");
        }

        void GeneratePath(TreeNode node, ref string name)
        {

            if (node.Parent != null)
            {
                name = node.Parent.Text + "\\" + name;
                node = node.Parent;
                GeneratePath(node, ref name);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            for (int i = 0; i < node.Nodes.Count; ++i)
            {
                string text = node.Nodes[i].Text;
                GeneratePath(node.Nodes[i], ref text);
                text = @"D:\" + text;
                string[] subDir = Directory.GetDirectories(text);
                for (int j = 0; j < subDir.Length; ++j)
                {
                    node.Nodes[i].Nodes.Add(new TreeNode(subDir[j].Substring(subDir[j].LastIndexOf('\\') + 1, subDir[j].Length - subDir[j].LastIndexOf('\\') - 1)));
                }
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            string text = node.Text;
            GeneratePath(node, ref text);
            text = @"D:\" + text;
            string[] files = Directory.GetFiles(text);
            listView1.Items.Clear();
            for (int i = 0; i < files.Length; ++i)
            {
                FileAttributes f = new FileInfo(files[i]).Attributes;
                if (f.HasFlag(FileAttributes.Hidden)==false||checkBox1.Checked==true)
                {
                    text = files[i].Substring(files[i].LastIndexOf('\\') + 1, files[i].Length - files[i].LastIndexOf('\\') - 1);
                    ListViewItem it = new ListViewItem(text);
                    it.SubItems.Add(File.GetLastWriteTime(files[i]).ToShortDateString() + " " + File.GetLastWriteTime(files[i]).ToShortTimeString());
                    it.SubItems.Add(((new FileInfo(files[i]).Length / 1024) == 0 ? 1 : new FileInfo(files[i]).Length / 1024).ToString() + " KB");
                    listView1.Items.Add(it);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //switch (listView1.View)
            //{ 
            //    case View.Details: listView1.View = View.LargeIcon; break;
            //    case View.LargeIcon: listView1.View = View.List; break;
            //    case View.List: listView1.View = View.SmallIcon; break;
            //    case View.SmallIcon: listView1.View = View.Tile; break;
            //    case View.Tile: listView1.View = View.Details; break;
            //}
            listView1.View = (View)(((int)listView1.View + 1)%5);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string text = node.Text;
            GeneratePath(node, ref text);
            text = @"D:\" + text;
            string[] files = Directory.GetFiles(text);
            listView1.Items.Clear();
            for (int i = 0; i < files.Length; ++i)
            {
                FileAttributes f = new FileInfo(files[i]).Attributes;
                if (f.HasFlag(FileAttributes.Hidden) == false || checkBox1.Checked == true)
                {
                    text = files[i].Substring(files[i].LastIndexOf('\\') + 1, files[i].Length - files[i].LastIndexOf('\\') - 1);
                    ListViewItem it = new ListViewItem(text);
                    it.SubItems.Add(File.GetLastWriteTime(files[i]).ToShortDateString() + " " + File.GetLastWriteTime(files[i]).ToShortTimeString());
                    it.SubItems.Add(((new FileInfo(files[i]).Length / 1024) == 0 ? 1 : new FileInfo(files[i]).Length / 1024).ToString() + " KB");
                    listView1.Items.Add(it);
                }
            }
        }
    }
}
