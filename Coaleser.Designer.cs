namespace Log_Analyzer
{
    partial class Coaleser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.c_rtxtSearchResult = new System.Windows.Forms.RichTextBox();
            this.rtextSelectedFiles = new System.Windows.Forms.RichTextBox();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.c_tree_FileView = new System.Windows.Forms.TreeView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabControlFile = new System.Windows.Forms.TabControl();
            this.tabpageNew = new System.Windows.Forms.TabPage();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlFiles.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.tabControlFile.SuspendLayout();
            this.tabpageNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer);
            this.pnlMain.Controls.Add(this.pnlFiles);
            this.pnlMain.Controls.Add(this.pnlSearch);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1351, 612);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(325, 144);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splitContainer.Panel1.Controls.Add(this.tabControlFile);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splitContainer.Panel2.Controls.Add(this.rtextSelectedFiles);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainer.Size = new System.Drawing.Size(1013, 455);
            this.splitContainer.SplitterDistance = 260;
            this.splitContainer.TabIndex = 1;
            // 
            // c_rtxtSearchResult
            // 
            this.c_rtxtSearchResult.BackColor = System.Drawing.Color.White;
            this.c_rtxtSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_rtxtSearchResult.Location = new System.Drawing.Point(16, 27);
            this.c_rtxtSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.c_rtxtSearchResult.Name = "c_rtxtSearchResult";
            this.c_rtxtSearchResult.ReadOnly = true;
            this.c_rtxtSearchResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.c_rtxtSearchResult.Size = new System.Drawing.Size(552, 150);
            this.c_rtxtSearchResult.TabIndex = 0;
            this.c_rtxtSearchResult.Text = "";
            this.c_rtxtSearchResult.WordWrap = false;
            // 
            // rtextSelectedFiles
            // 
            this.rtextSelectedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtextSelectedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtextSelectedFiles.Location = new System.Drawing.Point(4, 4);
            this.rtextSelectedFiles.Margin = new System.Windows.Forms.Padding(4);
            this.rtextSelectedFiles.Name = "rtextSelectedFiles";
            this.rtextSelectedFiles.ReadOnly = true;
            this.rtextSelectedFiles.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtextSelectedFiles.Size = new System.Drawing.Size(1003, 181);
            this.rtextSelectedFiles.TabIndex = 0;
            this.rtextSelectedFiles.Text = "";
            this.rtextSelectedFiles.WordWrap = false;
            this.rtextSelectedFiles.DoubleClick += new System.EventHandler(this.RtextSelectedFiles_DoubleClick);
            // 
            // pnlFiles
            // 
            this.pnlFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFiles.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlFiles.Controls.Add(this.c_tree_FileView);
            this.pnlFiles.Location = new System.Drawing.Point(4, 143);
            this.pnlFiles.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(312, 465);
            this.pnlFiles.TabIndex = 2;
            // 
            // c_tree_FileView
            // 
            this.c_tree_FileView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_tree_FileView.Location = new System.Drawing.Point(9, 4);
            this.c_tree_FileView.Margin = new System.Windows.Forms.Padding(4);
            this.c_tree_FileView.Name = "c_tree_FileView";
            this.c_tree_FileView.Size = new System.Drawing.Size(297, 452);
            this.c_tree_FileView.TabIndex = 0;
            this.c_tree_FileView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.c_tree_FileView_AfterSelect);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.Firebrick;
            this.pnlSearch.Controls.Add(this.btn_Search);
            this.pnlSearch.Controls.Add(this.lblEndDate);
            this.pnlSearch.Controls.Add(this.lblStartDate);
            this.pnlSearch.Controls.Add(this.lblCategory);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.cboCategory);
            this.pnlSearch.Controls.Add(this.dateEnd);
            this.pnlSearch.Controls.Add(this.dateStart);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(4, 4);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1343, 132);
            this.pnlSearch.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(457, 28);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 28);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(603, 75);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 24);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(603, 28);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 24);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(12, 75);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 24);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(12, 28);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 24);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search:";
            // 
            // cboCategory
            // 
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Offline",
            "Update",
            "Smart Scan",
            "Performance",
            "DLP"});
            this.cboCategory.Location = new System.Drawing.Point(116, 71);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(331, 32);
            this.cboCategory.TabIndex = 3;
            // 
            // dateEnd
            // 
            this.dateEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(741, 71);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(196, 29);
            this.dateEnd.TabIndex = 2;
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(741, 25);
            this.dateStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(196, 29);
            this.dateStart.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(116, 27);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(331, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // tabControlFile
            // 
            this.tabControlFile.Controls.Add(this.tabpageNew);
            this.tabControlFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFile.Location = new System.Drawing.Point(4, 4);
            this.tabControlFile.Name = "tabControlFile";
            this.tabControlFile.SelectedIndex = 0;
            this.tabControlFile.Size = new System.Drawing.Size(1003, 250);
            this.tabControlFile.TabIndex = 0;
            // 
            // tabpageNew
            // 
            this.tabpageNew.Controls.Add(this.c_rtxtSearchResult);
            this.tabpageNew.Location = new System.Drawing.Point(4, 25);
            this.tabpageNew.Name = "tabpageNew";
            this.tabpageNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageNew.Size = new System.Drawing.Size(995, 221);
            this.tabpageNew.TabIndex = 1;
            this.tabpageNew.Text = "empty";
            this.tabpageNew.UseVisualStyleBackColor = true;
            // 
            // Coaleser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 612);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Coaleser";
            this.Text = "Coaleser";
            this.pnlMain.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlFiles.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.tabControlFile.ResumeLayout(false);
            this.tabpageNew.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFiles;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.RichTextBox rtextSelectedFiles;
        private System.Windows.Forms.RichTextBox c_rtxtSearchResult;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        public System.Windows.Forms.TreeView c_tree_FileView;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabControl tabControlFile;
        private System.Windows.Forms.TabPage tabpageNew;
    }
}