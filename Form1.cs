﻿using System;
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
        //Location of the file, accessible to anywhere 
        private string full_path = "";

        //Extraction path
        private string extract_path = "";

        //Imported CSVs
        private string imported_CSV_offline = "";
        private string imported_CSV_update = "";

        //For the Known Errors grid
        private List<List<string>> ErrorsList;

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

                var dir = new DirectoryInfo(dest);
                if (dir.Exists)
                    dir.Delete(true);
                
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


        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) // START of loading CDT
        {
            OpenFileDialog openFile = new OpenFileDialog();

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string file_name = openFile.FileName;
                    UnzipCDTAsync(file_name);

                    //Get the tab name
                    int index = file_name.IndexOf(".");
                    string tab_name = file_name.Substring(file_name.LastIndexOf("\\") + 1, index - file_name.LastIndexOf("\\") - 1);

                    //Check if CDT is already loaded
                    if(NewTab.doesExist(tab_name, tabControl1))
                        return;

                    //If not, load another page
                    NewTab new_tab = new NewTab(tab_name, tabControl1, TabSystem);

                    getSysInformation gsi = new getSysInformation($"{extract_path}");
                    getAgentInformation gai = new getAgentInformation($"{extract_path}", gsi.getSysArch());

                    loadSysInformation(gsi, tabControl1.TabPages[tab_name]);
                    loadAgentInformation(gai, tabControl1.TabPages[tab_name]);

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error! Invalid Filetype. Make sure to import ZIP format.");
            }
        }
        
        private void loadKnownError(List<List<String>> errorsList, HashSet<string[]> errorsFound)
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
                //List the errors under the error code
                showErrors(error);
            }
            catch(Exception ex)
            {
                error = "";
            }
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
            //highlightText(txtResults, error);
        }

        //For highlighting the results
        private void highlightText(RichTextBox r, string text)
        {
            int s_start = r.SelectionStart, startIndex = 1, index;

            while ((index = r.Text.ToLower().IndexOf(text.ToLower(), startIndex)) != -1)
            {
                r.Select(index, text.Length);
                r.SelectionBackColor = Color.Yellow;

                startIndex = index + text.Length;
            }

            r.SelectionStart = s_start;
            r.SelectionLength = 0;
        }

        private void UnzipCDTAsync(String file)
        {
            full_path = file;

            extract_path = extractZip(full_path);
        }

        private void loadAgentInformation(getAgentInformation gai, TabPage tp)
        {
            TabControl tc = (TabControl)tp.Controls["TabSystem"];
            TabPage page = (TabPage)tc.TabPages["tab_AgentInfo"];

            page.Controls["lblAgentVersion_value"].Text = gai.getAgentVer();
            page.Controls["lblAgentBuild_value"].Text = gai.getAgentBuild();
            page.Controls["lblAgentAddr_value"].Text = gai.getServer();
            page.Controls["lblServerHttpPort_value"].Text = gai.getServerHTTP();
            page.Controls["lblServerHttpsPort_value"].Text = gai.getServerHTTPS();
            page.Controls["lblAgentPort_value"].Text = gai.getAgentPort();
            page.Controls["lblUpdateAgentAddr_value"].Text = gai.getUpdateAgentAddress();
            page.Controls["lblUpdateAgentPort_value"].Text = gai.getUpdateAgentPort();
            page.Controls["lblUpdateAgent_value"].Text = gai.getUpdateAgent();
            page.Controls["lblAgentLocation_value"].Text = gai.getAgentLocation();
            page.Controls["lblEngineVersion_value"].Text = gai.getEngineVersion();
            page.Controls["lblConvenPtnVer_value"].Text = gai.getConPtnVersion();
            page.Controls["lblSmartScanPatternVer_value"].Text = gai.getSmartPtnVersion();
        }

        private void loadSysInformation(getSysInformation gsi, TabPage tp)
        {
            TabControl tc = (TabControl) tp.Controls["TabSystem"];
            TabPage page = (TabPage) tc.TabPages["tab_SystemInfo"];

            page.Controls["lblHostname_value"].Text = gsi.getHostname(); //Host name
            page.Controls["lblIPAddress_value"].Text = gsi.getIpAdd(); //Ip Address
            page.Controls["lblGateway_value"].Text = gsi.getGateway(); //Gateway
            page.Controls["lblDns_value"].Text = gsi.getDNS(); //DNS
            page.Controls["lblOperatingSystem_value"].Text = gsi.getOS(); //OS
            page.Controls["lblOSver_value"].Text = gsi.getOSver(); //OS Version
            page.Controls["lblSystemArchitecture_value"].Text = gsi.getSysArch(); //System Architecture
            page.Controls["lblCPU_value"].Text = gsi.getCPU(); //CPU
            page.Controls["lblRam_value"].Text = gsi.getRAM(); //RAM
            page.Controls["lblFreeDiskSpace_value"].Text = gsi.getDiskSpace(); //Free Disk Space

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

            if (imported_CSV_offline.Equals(""))
                imported_CSV_offline = "codes.csv";
            
            offlineAnalyzer oa = new offlineAnalyzer($"{path}Event1\\", imported_CSV_offline);
            loadKnownError(oa.errorList, oa.errorsFound);
        }

        private void Btn_OffAnalyze_Click(object sender, EventArgs e)
        {
            clearGrid(grid_KnownError);
            if (extract_path.Equals(""))
                return;
            offAnalyze(getFullPath());
        }

        private void clearGrid(DataGridView d)
        {
            d.Rows.Clear();
            d.Refresh();
        }

         private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (extract_path.Equals(""))
                return;
            UpdateAnalyze(getFullPath());
        }

        private void UpdateAnalyze(string path)
        {
            //Check first if update event exists in CDT
            if (!Directory.Exists($"{ path}\\Event5\\"))
            {
                txtUpdate.Text = "No TmuDump Uploaded";
                return;
            }

            if (imported_CSV_update.Equals(""))
                imported_CSV_update = "update.csv";

            UpdateAnalyzer ua = new UpdateAnalyzer($"{path}\\Event5\\", imported_CSV_update);
            txtUpdate.Text = ua.getSummary();
        }

        private void tabKnownError_Click(object sender, EventArgs e)
        {

        }

        //highlight keyword after typing text on Filter textbox
        //has a bug, it does not include the last character, due to Event KEYDOWN executing AFTER last character is typed

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string codes_zip = openFile.FileName;

                try
                {
                    using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(codes_zip))
                    {
                        zip.Password = "beveko";

                        zip.ExtractAll("TEMP\\Codes", Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                    }
                } catch (Exception ex)
                {
                    if(ex.Message.ToLower().Contains("bad password"))
                    {
                        //Message box
                        Console.WriteLine("Wrong password");
                    }
                }

                imported_CSV_offline = @"TEMP\Codes\offline.csv";
                imported_CSV_update = @"TEMP\Codes\update.csv";
            }
            
        }

    }
}
