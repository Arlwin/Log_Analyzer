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
using System.Threading;
using Ionic.Zip;

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

        //Coaleser Form2 = new Coaleser();

        private string extractZip(string path)
        {
            string dest = "";
            int index = path.IndexOf(".");
            string filename = path.Substring(path.LastIndexOf("\\") + 1, index - path.LastIndexOf("\\") - 1);

            if(index > 0)
            {
                //dest = path.Substring(0, index);
                dest = "TEMP\\" + filename;
            }

            using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(path))
            {
                zip.Password = "trend";

                zip.ExtractProgress += new EventHandler<ExtractProgressEventArgs>(zip_ExtractProgress);

                zip.ExtractAll(dest, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
            }

            return dest;
        }
       
        void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.BytesTransferred > 0)
            {
                prog_perFile.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);
            }

            if ((e.EntriesTotal - e.EntriesExtracted) >= 0 && (e.EntriesTotal > 0))
            {
                prog_Open.Value = Convert.ToInt32(100 * e.EntriesExtracted / e.EntriesTotal);

            }
        }

        private void loadDir(string path, Coaleser Form2)
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

        //Location of the file, accessible to anywhere 
        private string full_path = "";

        //Extraction path
        private string extract_path = ""; 
        
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) // START of loading CDT
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                UnzipCDTAsync(openFile.FileName);
                
                getSysInformation gsi = new getSysInformation(extract_path);
                getAgentInformation gai = new getAgentInformation(extract_path, gsi.getSysArch());

                loadSysInformation(gsi);
                loadAgentInformation(gai);

            }
        }

        private void UnzipCDTAsync(String file)
        {
            full_path = file;

            extract_path = extractZip(full_path);
        }

        private void loadAgentInformation(getAgentInformation gai)
        {
            lblAgentVersion_value.Text = gai.getAgentVer();
            lblAgentBuild_value.Text = gai.getAgentBuild();
            lblAgentAddr_value.Text = gai.getServer();
            lblServerHttpPort_value.Text = gai.getServerHTTP();
            lblServerHttpsPort_value.Text = gai.getServerHTTPS();
            lblAgentPort_value.Text = gai.getAgentPort();
            lblUpdateAgentAddr_value.Text = gai.getUpdateAgentAddress();
            lblUpdateAgentPort_value.Text = gai.getUpdateAgentPort();
            lblUpdateAgent_value.Text = gai.getUpdateAgent();
            lblAgentLocation_value.Text = gai.getAgentLocation();
            lblEngineVersion_value.Text = gai.getEngineVersion();
            lblConvenPtnVer_value.Text = gai.getConPtnVersion();
            lblSmartScanPatternVer_value.Text = gai.getSmartPtnVersion();
        }

        private void loadSysInformation(getSysInformation gsi)
        {
            lblHostname_value.Text = gsi.getHostname(); //Host name
            lblIPAddress_value.Text = gsi.getIpAdd(); //Ip Address
            lblGateway_value.Text = gsi.getGateway(); //Gateway
            lblDns_value.Text = gsi.getDNS(); //DNS

            lblOperatingSystem_value.Text = gsi.getOS(); //OS
            lblOSver_value.Text = gsi.getOSver(); //OS Version
            lblSystemArchitecture_value.Text = gsi.getSysArch(); //System Architecture
            lblCPU_value.Text = gsi.getCPU(); //CPU
            lblRam_value.Text = gsi.getRAM(); //RAM
            lblFreeDiskSpace_value.Text = gsi.getDiskSpace(); //Free Disk Space

            //NOTE: Currently, disk space can only print free disk space of FIRST disk drive
        }

        private void coalescerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coaleser Form2 = new Coaleser();
            loadDir(extract_path, Form2);

            Form2.Show();

        }

        private void txt_Fltr_TextChanged(object sender, EventArgs e)
        {

        }
        
        //highlight keyword after typing text on Filter textbox
        //has a bug, it does not include the last character, due to Event KEYDOWN executing AFTER last character is typed

    }
}
