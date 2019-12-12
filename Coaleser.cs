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
using System.Diagnostics;


namespace Log_Analyzer
{
    public partial class Coaleser : Form
    {

        private TabPage previousTabPage = new TabPage();
        private TabPage current_searchedTabPage = new TabPage();

        public Coaleser()
        {
            InitializeComponent();
            tabControlFile.Padding = new Point(12, 4);
            tabControlFile.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlFile.DrawItem += tabControlFile_DrawItem;
            tabControlFile.MouseDown += tabControlFile_MouseDown;

            rtextSelectedFiles.Text = "";
        }
        
        private void c_tree_FileView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] lines = checkIfZip(e);
            //rtextSelectedFiles.Text = "";

            if (lines == null)
                lines = readText(e);

            if (e.Node.Nodes.Count > 1)
            {
            }
            else
            {
                var text_box = newTabPage(e.Node.Text);

                //c_rtxtSearchResult.Clear();
                // writeToTextBox(lines, c_rtxtSearchResult);
                text_box.Clear();
                writeToTextBox(lines, text_box);
            }
        }

        private RichTextBox newTabPage(string name)
        {
            //If selected existing key, focus on that key
            if (tabControlFile.TabPages.ContainsKey(name))
            {
                tabControlFile.SelectedTab = tabControlFile.TabPages[name];
                return (RichTextBox) tabControlFile.TabPages[name].Controls[0];

            }

            //Add new key and name
            tabControlFile.TabPages.Add(name, name);
            Console.WriteLine(tabControlFile.TabPages[name]);

            tabControlFile.SelectedTab = tabControlFile.TabPages[name];

            //Focus on new tab key
            tabControlFile.SelectedTab = tabControlFile.TabPages[name];

            //Create a textbox
            RichTextBox new_rtxtSearchResult = new RichTextBox();

            //Design
            new_rtxtSearchResult.BackColor = System.Drawing.Color.White;
            new_rtxtSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            new_rtxtSearchResult.Location = new System.Drawing.Point(16, 27);
            new_rtxtSearchResult.Margin = new System.Windows.Forms.Padding(4);
            new_rtxtSearchResult.Dock = DockStyle.Fill;
            new_rtxtSearchResult.Name = $"{name}_textbox";
            new_rtxtSearchResult.ReadOnly = true;
            new_rtxtSearchResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            new_rtxtSearchResult.Size = new System.Drawing.Size(552, 150);
            new_rtxtSearchResult.TabIndex = 0;
            new_rtxtSearchResult.Text = "";
            new_rtxtSearchResult.WordWrap = false;


            //Add the textbox to the tab
            tabControlFile.TabPages[name].Controls.Add(new_rtxtSearchResult);

            //Return the textbox created
            return new_rtxtSearchResult;
        }


        private string[] checkIfZip(TreeViewEventArgs e)
        {
            if (!(e.Node.FullPath.Contains(".7z")))
            {
                return null;
            }

            TreeNode iterator;

            String path = "TEMP\\";
            String file = "";

            iterator = e.Node;
            file = iterator.Text;

            while (iterator.Parent != null)
            {
                iterator = iterator.Parent;
                path = path.Insert(path.IndexOf("\\") + 1, iterator.Text + "\\");
            }

            if(Directory.Exists(path + file.Substring(0, file.IndexOf(".7z"))))
            {
                return System.IO.File.ReadAllLines($"{path}\\{file.Substring(0, file.IndexOf(".7z"))}\\{file.Substring(0, file.IndexOf(".7z"))}.log");
            }

            string new_folder = System.IO.Directory.CreateDirectory(path + file.Substring(0, file.IndexOf(".7z"))).ToString();
            Extract7zip(path + file, path + new_folder);
 
            return System.IO.File.ReadAllLines($"{path}{new_folder}\\{new_folder}.log");
        }

        public void Extract7zip(string sourceArchive, string destination)
        {
            string zPath = @"lib\7zip\x64\7za.exe"; //add to proj and set CopyToOuputDir
            try
            {
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = zPath;
                pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sourceArchive, destination);
                Process x = Process.Start(pro);
                x.WaitForExit();
            }
            catch (System.Exception Ex)
            {
                //c_rtxtSearchResult.Text = Ex.Message.ToString();
            }
        }

        private string[] readText(TreeViewEventArgs e)
        {
            TreeNode iterator;
            string[] textlines = null;

            String path = "TEMP\\";
            String file = "";

            iterator = e.Node;
            file = iterator.Text;

            while (iterator.Parent != null)
            {
                iterator = iterator.Parent;
                path = path.Insert(path.IndexOf("\\") + 1, iterator.Text + "\\");
            }

            try
            {
                textlines = System.IO.File.ReadAllLines(path + file);

            }
            catch (Exception ex)
            {
                textlines = new string[] { "" };
            }

            return textlines;
        }

        private void writeToTextBox(string[] lines, RichTextBox r)
        {
            r.Text = string.Join("\n", lines);
        }

        //Search function
        private void Btn_Search_Click(object sender, EventArgs e)
        {
           var c_rtxtSearchResult = (RichTextBox) tabControlFile.SelectedTab.Controls[0];

            //If textbox / search is empty, do nothing
            /*if (c_rtxtSearchResult.Text.Equals("") || txtSearch.Text.Trim().Equals(""))
                return;
                */

            if (c_rtxtSearchResult.Text.Equals("") || txtSearch.Text.Trim().Equals(""))
                return;

            string searchText = txtSearch.Text.Trim();
            //Get all the lines with the keyword
            List<string> lines = getLines((RichTextBox) tabControlFile.SelectedTab.Controls[0], searchText);

            //Output the lines to another textbox
            outputLines(lines, rtextSelectedFiles);

            //Highlight the words on that textbox = slow
            //highlightText(rtextSelectedFiles, searchText);

            //Used in Double Click function
            previousTabPage = tabControlFile.SelectedTab;

            //Used in closing windows
            current_searchedTabPage = tabControlFile.SelectedTab;
        }

        private List<string> getLines(RichTextBox r, string search)
        {
            List<string> lines = new List<string>();

            int counter = 0; //For the caching
            foreach (var line in r.Lines)
            {
                if ((line.ToLower()).Contains(search.ToLower()))
                {
                    switch (counter.ToString().Length)
                    {
                        case 1:
                            lines.Add($"00000{counter.ToString()} ||  {line}");
                            break;

                        case 2:
                            lines.Add($"0000{counter.ToString()} ||  {line}");
                            break;

                        case 3:
                            lines.Add($"000{counter.ToString()} ||  {line}");
                            break;

                        case 4:
                            lines.Add($"00{counter.ToString()} ||  {line}");
                            break;

                        case 5:
                            lines.Add($"0{counter.ToString()} ||  {line}");
                            break;

                        case 6:
                            lines.Add($"{counter.ToString()} ||  {line}");
                            break;

                        default:
                            lines.Add($"{counter.ToString()}||  {line}");
                            break;
                    }
                }

                counter++;
            }

            return lines;
        }

        private void outputLines(List<string> lines, RichTextBox r)
        {
            r.Text = string.Join("\n", lines);
        }

        private void RtextSelectedFiles_DoubleClick(object sender, EventArgs e)
        {
            if (!tabControlFile.SelectedTab.Text.Equals(previousTabPage.Text))
            {
                tabControlFile.SelectedTab = previousTabPage;
            }

            var c_rtxtSearchResult = (RichTextBox)tabControlFile.SelectedTab.Controls[0];

            //If no entry, do nothing
            if (rtextSelectedFiles.Text.Equals(""))
                return;

            //For highlighting
            c_rtxtSearchResult.SelectAll();
            c_rtxtSearchResult.SelectionBackColor = Color.White;
            c_rtxtSearchResult.DeselectAll();
            
            int line_number = rtextSelectedFiles.GetLineFromCharIndex(rtextSelectedFiles.SelectionStart); //Get the line index of the selected word
            string line = rtextSelectedFiles.Lines[line_number].Trim(); //removed white spaces

            //Try to use caching to get the line number immediately
            //Faster but not instant 
            string string_line_number = line.Substring(0, line.IndexOf(" ")); //Get the number from the line before the ||
            int real_line_number = Int32.Parse(string_line_number); //Conver string to int
            int index_of_line = c_rtxtSearchResult.GetFirstCharIndexFromLine(real_line_number); //Get the index from the line number

            if (index_of_line - 50 < 0)
                c_rtxtSearchResult.Select(index_of_line, line.Length - 10); //Select the index with length of the line
            else
                c_rtxtSearchResult.Select(index_of_line - 50, line.Length - 10); //Select the index with length of the line

            Console.WriteLine(line);

            //Jump to selected
            c_rtxtSearchResult.ScrollToCaret();

            //Highlight the text
            c_rtxtSearchResult.Select(index_of_line, line.Length - 10);
            c_rtxtSearchResult.SelectionBackColor = Color.Yellow;

        }

        private void tabControlFile_DrawItem(object sender, DrawItemEventArgs e)
        {

            var tabPage = this.tabControlFile.TabPages[e.Index];
            var tabRect = this.tabControlFile.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            var closeImage = Properties.Resources.Close;
            e.Graphics.DrawImage(closeImage, (tabRect.Right - closeImage.Width), tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,tabRect, tabPage.ForeColor, TextFormatFlags.Left);
        }

        private void tabControlFile_MouseDown(object sender, MouseEventArgs e)
        {
            for(var i = 0; i <= tabControlFile.TabPages.Count - 1; i++)
                {
                    var tabRect = tabControlFile.GetTabRect(i);
                    tabRect.Inflate(-2, -2);
                    var closeImage = Properties.Resources.Close;
                    var imageRect = new Rectangle(
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                        closeImage.Width,
                        closeImage.Height);
                    if (imageRect.Contains(e.Location))
                    {
                        if (current_searchedTabPage.Name.Equals(tabControlFile.TabPages[i].Name))
                            rtextSelectedFiles.Text = "";

                        tabControlFile.TabPages.RemoveAt(i);
                        break;
                    }
                }

        }

    }
}
