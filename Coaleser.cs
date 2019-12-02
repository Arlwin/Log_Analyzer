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
        
        private async void c_tree_FileView_AfterSelect(object sender, TreeViewEventArgs e)
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
                textlines[0] = "Error Reading file";
            }

            return textlines;
        }

        /*private void writeToTextBox(string[] lines, RichTextBox r)
        {
            foreach (var line in lines)
            {
                // Use a tab to indent each line of the file.
                r.AppendText(line + "\n");
            }
        }*/

        private void writeToTextBox(string[] lines, RichTextBox r)
        {
            r.Text = string.Join("\n", lines);
        }


    }
}
