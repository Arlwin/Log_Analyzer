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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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

        public void setMainProgressBar(int progress)
        {
            prog_Open.Value = progress;
        }

        public void setSubProgressBar(int progress)
        {
            prog_perFile.Value = progress;
        }

        // START of loading CDT
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            OpenFileDialog openFile = new OpenFileDialog();

          
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
                    NewTab new_tab = new NewTab(tab_name, tabControl1, file_name, this);
                    tabs.Add(new_tab);

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

        private void lblStartPage_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Toolbar_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Gray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Firebrick;
          
        }

        private void picMaximize_MouseHover(object sender, EventArgs e)
        {
            picMaximize.BackColor = Color.Gray;
        }

        private void picMaximize_MouseLeave(object sender, EventArgs e)
        {
            picMaximize.BackColor = Color.Firebrick;
        }

        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            picMinimize.BackColor = Color.Gray;
        }

        private void picMinimize_MouseLeave(object sender, EventArgs e)
        {
            picMinimize.BackColor = Color.Firebrick;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            var msgexit = MessageBox.Show("Are you sure you want to Exit?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msgexit == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
