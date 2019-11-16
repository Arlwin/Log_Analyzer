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
using System.Text.RegularExpressions;

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
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           // System.Windows.Forms.Application.Exit();
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
        //Location of the file, accessable to anywhere 
        private string full_path = "CDT-20190426-095153.zip";
        //Extraction path
        private string extract_path = ""; 

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //txt_Area.AppendText("File list: ");

            extract_path = extractZip(full_path);

            loadDir(extract_path); 
        }


        private void tree_FileView_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            txt_Area.Clear();
            TreeNode iterator;

            String path = "";
            String file = "";

            iterator = e.Node;
            file = iterator.Text;

            while (iterator.Parent != null)
            {
                iterator = iterator.Parent;
                path = path.Insert(0, iterator.Text + "\\");
            }
            
            //txt_Area.Text = path + file;

            try
            {
                string[] textlines = File.ReadAllLines(path + file);

                foreach (string line in textlines)
                {
                    // Use a tab to indent each line of the file.
                    txt_Area.AppendText(line + "\n");
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void coalescerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coaleser Form2 = new Coaleser();
            Form2.Show();
        }



        //highlight keyword after typing text on Filter textbox
        //has a bug, it does not include the last character, due to Event KEYDOWN executing AFTER last character is typed
        private void txt_Fltr_KeyDown(object sender, KeyEventArgs e)
        {
            //reset txt_Area after entering new keyword
            string temp = txt_Area.Text;
            txt_Area.Clear();
            txt_Area.Text = temp;

            //match txt_Fltr to texts on txt_Area
            Regex reg = new Regex(txt_Fltr.Text, RegexOptions.IgnoreCase);
            foreach (Match find in reg.Matches(txt_Area.Text))
            {
                txt_Area.Select(find.Index, find.Length);
                txt_Area.SelectionBackColor = Color.Yellow;
            }
        }
    }
}
