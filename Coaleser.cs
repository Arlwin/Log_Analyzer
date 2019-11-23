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
            c_rtxtSearchResult.Clear();
            TreeNode iterator;

            String path = "";
            String file = "";

            iterator = e.Node;
            file = iterator.Text;

            while (iterator.Parent != null)
            {
                iterator = iterator.Parent;
                path = path.Insert(0, iterator.Text + "\\");
            }

            //txt_Area.Text = path + file;

            try
            {
                string[] textlines = File.ReadAllLines(path + file);

                foreach (string line in textlines)
                {
                    // Use a tab to indent each line of the file.
                    c_rtxtSearchResult.AppendText(line + "\n");
                }
               
            }
            catch (Exception ex)
            {

            }
        }
    }
}
