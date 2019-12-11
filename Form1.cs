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
        //Extraction path
        private string extract_path = "";

        //List of Tabs
        private List<NewTab> tabs = new List<NewTab>();

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(f_FormClosed);
            tabControl1.Padding = new Point(12, 4);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += tabControl1_DrawItem;
            tabControl1.MouseDown += tabControl1_MouseDown;
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

        public static void setMainProgressBar(int progress)
        {
            prog_Open.Value = progress;
        }

        public static void setSubProgressBar(int progress)
        {
            prog_perFile.Value = progress;
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
                    {
                        tabControl1.SelectedTab = tabControl1.TabPages[tab_name];
                        return;
                    }

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


        //FOR COALESER
        private void coalescerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coaleser Form2 = new Coaleser();
            //Check if a CDT is loaded
            if (tabControl1.TabPages.Count < 1)
                return;
            //Get the current CDT Tab
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

                CDT_Tab_Template.imported_CSV_offline = @"TEMP\Codes\offline.csv";
                CDT_Tab_Template.imported_CSV_update = @"TEMP\Codes\update.csv";
            }

        }



        //Closing tabs
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = tabControl1.TabPages[e.Index];
            var tabRect = tabControl1.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            var closeImage = Properties.Resources.Close;
            e.Graphics.DrawImage(closeImage, (tabRect.Right - closeImage.Width), tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.Left);
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i <= tabControl1.TabPages.Count - 1; i++)
            {
                var tabRect = tabControl1.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = Properties.Resources.Close;
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    tabControl1.TabPages.RemoveAt(i);
                    break;
                }
            }

        }

    }
}
