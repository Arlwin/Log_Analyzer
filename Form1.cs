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
            this.FormClosed += new FormClosedEventHandler(f_FormClosed);
        }

        //Delete the TEMP folders when done
        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var dir = new DirectoryInfo(extract_path);
                dir.Delete(true);
            }
            catch (Exception ex)
            {
                //wala lang
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private string extractZip(string path)
        {
            string dest = "";

            try
            {
                int index = path.IndexOf(".");
                string filename = path.Substring(path.LastIndexOf("\\") + 1, index - path.LastIndexOf("\\") - 1);

                if (index > 0)
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

            } catch (Exception ex){
                if (ex.Message.Equals("Ionic.Zip.ZipException"))
                    Console.WriteLine("Please upload proper ZIP");
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
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);

                TreeNode node = Form2.c_tree_FileView.Nodes.Add(dir.Name);
                node.Tag = dir.FullName;
                node.StateImageIndex = 0;
                loadFiles(path, node);
                loadSubDir(path, node);
            }
            catch (Exception ex) { }

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

        //Imported CSV
        private string imported_CSV = "";
                
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
        
        //FOR TESTING ONLY
        private List<List<string>> ErrorsList;

        private void loadKnownError(List<List<String>> errorsList, List<string[]> errorsFound)
        {
            int counter = 0;
            ErrorsList = errorsList;

            foreach (string[] error in errorsFound)
            {
                grid_KnownError.Rows.Add(error[0], error[1], error[2]);
                counter++;
            }

            grid_KnownError.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_KnownError_CellClick);
        }

        private void Grid_KnownError_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string error;

            //Get the row of the current cell selected
            DataGridViewCell cell = grid_KnownError.CurrentRow.Cells[0];
            try
            {
                error = cell.Value.ToString();
            }catch(Exception ex)
            {
                error = ex.ToString();
            }

            //List the errors under the error code
            showErrors(error);
        }

        private void showErrors(string error)
        {
            string errorOutput = "";

            foreach (List<string> errors in ErrorsList)
            {
                if (errors[0].Equals(error))
                    errorOutput = String.Join("\n", errors);
            }

            txtResults.Text = errorOutput;
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
        {       }

        private string getFullPath()
        {
            getSysInformation gsi = new getSysInformation(extract_path);
            getAgentInformation gai = new getAgentInformation(extract_path, gsi.getSysArch());

            return $"{ extract_path }\\{ gai.agentfolder}\\CollectedFile\\";
        }

        //Click button first before analysis
        private void offAnalyze(string path)
        {
            txtResults.Text = ""; //Clear
            if (imported_CSV.Equals(""))
                imported_CSV = "codes.csv";
            
            offlineAnalyzer oa = new offlineAnalyzer($"{path}\\Event1\\", imported_CSV);
            loadKnownError(oa.errorList, oa.errorsFound);
        }

        private void Btn_OffAnalyze_Click(object sender, EventArgs e)
        {
            if (extract_path.Equals(""))
                return;
            offAnalyze(getFullPath());
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imported_CSV = openFile.FileName;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (extract_path.Equals(""))
                return;
            UpdateAnalyze(getFullPath());
        }

        private void UpdateAnalyze(string path)
        {
            UpdateAnalyzer ua = new UpdateAnalyzer($"{path}\\Event5\\", "update.csv");
            txtUpdate.Text = ua.getSummary();
        }

        //highlight keyword after typing text on Filter textbox
        //has a bug, it does not include the last character, due to Event KEYDOWN executing AFTER last character is typed

    }
}
