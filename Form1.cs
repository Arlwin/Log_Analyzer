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

        Coaleser Form2 = new Coaleser();

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

            return dest;
        }

        private void loadDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);

            TreeNode node = Form2.c_tree_FileView.Nodes.Add(dir.Name);
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

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) // START of loading CDT
        {
            extract_path = extractZip(full_path);
            loadDir(extract_path);

            getInformation gi = new getInformation(extract_path);
            loadInformation(gi);
        }

        private void loadInformation(getInformation gi)
        {
            lblHostname_value.Text = gi.getHostname(); //Host name
            lblIPAddress_value.Text = gi.getIpAdd(); //Ip Address
            lblGateway_value.Text = gi.getGateway(); //Gateway
            lblDns_value.Text = gi.getDNS(); //DNS
        }

        private void coalescerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Coaleser Form2 = new Coaleser();
            Form2.Show();

        }

        private void txt_Fltr_TextChanged(object sender, EventArgs e)
        {

        }

        
        //highlight keyword after typing text on Filter textbox
        //has a bug, it does not include the last character, due to Event KEYDOWN executing AFTER last character is typed

    }
}
