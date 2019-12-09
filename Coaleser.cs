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
    public partial class Coaleser : Form
    {
        public Coaleser()
        {
            InitializeComponent();

           

        }
        
        private void c_tree_FileView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] lines = readText(e);
            c_rtxtSearchResult.Clear();
            writeToTextBox(lines, c_rtxtSearchResult);
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
                textlines = File.ReadAllLines(path + file);

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

            //If textbox / search is empty, do nothing
            if (c_rtxtSearchResult.Text.Equals("") || txtSearch.Text.Trim().Equals(""))
                return;

            string searchText = txtSearch.Text.Trim();
            //Get all the lines with the keyword
            List<string> lines = getLines(c_rtxtSearchResult, searchText);

            //Output the lines to another textbox
            outputLines(lines, rtextSelectedFiles);

            //Highlight the words on that textbox = slow
            //highlightText(rtextSelectedFiles, searchText);

            //When double click, jump to text on original textbox
            //howto
        }

        private List<string> getLines(RichTextBox r, string search)
        {
            List<string> lines = new List<string>();
            
            foreach (var line in r.Lines)
            {
                if((line.ToLower()).Contains(search.ToLower()))
                    lines.Add(line);
            }

            return lines;
        }

        private void outputLines(List<string> lines, RichTextBox r)
        {
            r.Text = string.Join("\n", lines);
        }

        private void highlightText(RichTextBox r, string text)
        {
            int s_start = r.SelectionStart, startIndex = 0, index;

            while ((index = r.Text.ToLower().IndexOf(text.ToLower(), startIndex)) != -1)
            {
                r.Select(index, text.Length);
                r.SelectionBackColor = Color.Yellow;

                startIndex = index + text.Length;
            }

            r.SelectionStart = s_start;
            r.SelectionLength = 0;
        }
    }
}
