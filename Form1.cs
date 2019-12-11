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
        //Location of the file, accessible to anywhere 
        private string full_path = "";

        //Extraction path
        private string extract_path = "";

        //Imported CSVs
        private string imported_CSV_offline = "";
        private string imported_CSV_update = "";

        //For the Known Errors grid
        private List<List<string>> ErrorsList;

        //List of Tabs
        private List<NewTab> tabs = new List<NewTab>();

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


        public static void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
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

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) // START of loading CDT
        {
            OpenFileDialog openFile = new OpenFileDialog();

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string file_name = openFile.FileName;

                    //Get the tab name
                    int index = file_name.IndexOf(".");
                    string tab_name = file_name.Substring(file_name.LastIndexOf("\\") + 1, index - file_name.LastIndexOf("\\") - 1);

                    //Check if CDT is already loaded
                    if (NewTab.doesExist(tab_name, tabControl1))
                        return;

                    //If not, load another page
                    NewTab new_tab = new NewTab(tab_name, tabControl1, file_name);
                    tabs.Add(new_tab);

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error! Invalid Filetype. Make sure to import ZIP format.");
            }
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

        //FOR COALESER
        private void coalescerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coaleser Form2 = new Coaleser();
            string current_tab = tabControl1.SelectedTab.Name;
            foreach (NewTab tab in tabs)
                if (current_tab.Equals(tab.tab_name))
                    extract_path = tab.extract_path;

            loadDir(extract_path, Form2);

            Form2.Show();

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

        private string getFullPath()
        {
            getSysInformation gsi = new getSysInformation(extract_path);
            getAgentInformation gai = new getAgentInformation(extract_path, gsi.getSysArch());

            return $"{ extract_path }\\{ gai.agentfolder}\\CollectedFile\\";
        }


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
                CDT_Tab_Template.imported_CSV_offline = @"TEMP\Codes\offline.csv";
                CDT_Tab_Template.imported_CSV_update = @"TEMP\Codes\update.csv";
            }

        }

    }
}
