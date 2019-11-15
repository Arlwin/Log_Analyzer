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
            DragItem();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           // System.Windows.Forms.Application.Exit();
        }

        private void DragItem()
        {

            txt_Fltr.Text = "pota ka";

        }

        private void tabPage3_DragDrop(object sender, DragEventArgs e)
        {
            DragItem();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_Area.AppendText("File list: ");

            ZipArchive zip = ZipFile.OpenRead("test.zip");
            foreach (ZipArchiveEntry entry in zip.Entries)
            {
                txt_Area.AppendText("\r\n > " + entry.FullName);
            } 
        }

    }
}