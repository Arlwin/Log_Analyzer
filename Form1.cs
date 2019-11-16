using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace Log_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DragItem();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           // System.Windows.Forms.Application.Exit();
        }

        private void DragItem()
        {

            txt_Fltr.Text = "pota ka";

        }

        private void tabPage3_DragDrop(object sender, DragEventArgs e)
        {
            DragItem();
        }

        private void listDir()
        {

        }

        /*private void readZip(String path)
        {
            ZipArchive zip = ZipFile.OpenRead("test.zip");
            foreach (ZipArchiveEntry entry in zip.Entries)
            {
                txt_Area.AppendText("\r\n > " + entry.FullName);
                tree_FileView.Nodes.Add(entry.FullName);
            }
        }*/

        private string extractZip(string path)
        {
            string dest = "";
            int index = path.IndexOf(".");

            if(index > 0)
            {
                dest = path.Substring(0, index);
            }

            using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(path))
            {
                zip.Password = "trend";
                zip.ExtractAll(dest, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
            }

            /*try
            {
                ZipFile.ExtractToDirectory(path, dest);
            }
            catch (Exception e)
            {
                Directory.Delete(dest, true);
                ZipFile.ExtractToDirectory(path, dest);
            }*/

            return dest;
        }

        private void loadDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            TreeNode node = tree_FileView.Nodes.Add(dir.Name);
            node.Tag = dir.FullName;
            node.StateImageIndex = 0;
            loadFiles(path, node);
            loadSubDir(path, node);
        }

        private void loadSubDir(string path, TreeNode node)
        {
            string[] subdir = Directory.GetDirectories(path);

            foreach (string sub in subdir)
            {
                DirectoryInfo dir = new DirectoryInfo(sub);
                TreeNode nodes = node.Nodes.Add(dir.Name);
                nodes.StateImageIndex = 0;
                nodes.Tag = dir.FullName;
                loadFiles(sub, nodes);
                loadSubDir(sub, nodes);

            }
        }

        private void loadFiles(string path, TreeNode node)
        {
            string[] files = Directory.GetFiles(path, "*.*");
            
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode nodes = node.Nodes.Add(fi.Name);
                nodes.Tag = fi.FullName;
                nodes.StateImageIndex = 1;
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_Area.AppendText("File list: ");
            loadDir(extractZip("test.zip"));    
        }

    }
}
