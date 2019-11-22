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
            this.pnlSelected = new System.Windows.Forms.Panel();
            this.rtextSelectedFiles = new System.Windows.Forms.RichTextBox();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.c_tree_FileView = new System.Windows.Forms.TreeView();
            this.pnlTextFile = new System.Windows.Forms.Panel();
            this.c_rtxtSearchResult = new System.Windows.Forms.RichTextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.pnlSelected.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.pnlFiles.SuspendLayout();
            this.pnlTextFile.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlSelected);
            this.pnlMain.Controls.Add(this.pnlBtn);
            this.pnlMain.Controls.Add(this.pnlFiles);
            this.pnlMain.Controls.Add(this.pnlTextFile);
            this.pnlMain.Controls.Add(this.pnlSearch);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1217, 679);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlSelected
            // 
            this.pnlSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelected.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlSelected.Controls.Add(this.rtextSelectedFiles);
            this.pnlSelected.Location = new System.Drawing.Point(860, 116);
            this.pnlSelected.Name = "pnlSelected";
            this.pnlSelected.Size = new System.Drawing.Size(354, 272);
            this.pnlSelected.TabIndex = 4;
            // 
            // rtextSelectedFiles
            // 
            this.rtextSelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtextSelectedFiles.Location = new System.Drawing.Point(13, 17);
            this.rtextSelectedFiles.Name = "rtextSelectedFiles";
            this.rtextSelectedFiles.ReadOnly = true;
            this.rtextSelectedFiles.Size = new System.Drawing.Size(332, 240);
            this.rtextSelectedFiles.TabIndex = 0;
            this.rtextSelectedFiles.Text = "";
            // 
            // pnlBtn
            // 
            this.pnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.pnlBtn.Controls.Add(this.btnRemove);
            this.pnlBtn.Controls.Add(this.btnAdd);
            this.pnlBtn.Location = new System.Drawing.Point(788, 116);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(66, 272);
            this.pnlBtn.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(11, 74);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(44, 42);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlFiles
            // 
            this.pnlFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiles.BackColor = System.Drawing.Color.Yellow;
            this.pnlFiles.Controls.Add(this.c_tree_FileView);
            this.pnlFiles.Location = new System.Drawing.Point(3, 116);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(779, 272);
            this.pnlFiles.TabIndex = 2;
            // 
            // c_tree_FileView
            // 
            this.c_tree_FileView.Location = new System.Drawing.Point(12, 17);
            this.c_tree_FileView.Name = "c_tree_FileView";
            this.c_tree_FileView.Size = new System.Drawing.Size(748, 240);
            this.c_tree_FileView.TabIndex = 0;
            this.c_tree_FileView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.c_tree_FileView_AfterSelect);
            // 
            // pnlTextFile
            // 
            this.pnlTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTextFile.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlTextFile.Controls.Add(this.c_rtxtSearchResult);
            this.pnlTextFile.Location = new System.Drawing.Point(3, 394);
            this.pnlTextFile.Name = "pnlTextFile";
            this.pnlTextFile.Size = new System.Drawing.Size(1211, 282);
            this.pnlTextFile.TabIndex = 1;
            // 
            // c_rtxtSearchResult
            // 
            this.c_rtxtSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_rtxtSearchResult.Location = new System.Drawing.Point(9, 17);
            this.c_rtxtSearchResult.Name = "c_rtxtSearchResult";
            this.c_rtxtSearchResult.ReadOnly = true;
            this.c_rtxtSearchResult.Size = new System.Drawing.Size(1193, 256);
            this.c_rtxtSearchResult.TabIndex = 0;
            this.c_rtxtSearchResult.Text = "";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSearch.Controls.Add(this.lblEndDate);
            this.pnlSearch.Controls.Add(this.lblStartDate);
            this.pnlSearch.Controls.Add(this.lblCategory);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.cboCategory);
            this.pnlSearch.Controls.Add(this.dateEnd);
            this.pnlSearch.Controls.Add(this.dateStart);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1211, 107);
            this.pnlSearch.TabIndex = 0;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(378, 61);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(73, 18);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(378, 23);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(78, 18);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(9, 61);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 18);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(9, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 18);
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
            this.cboCategory.Location = new System.Drawing.Point(101, 56);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(249, 26);
            this.cboCategory.TabIndex = 3;
            // 
            // dateEnd
            // 
            this.dateEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(482, 58);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(148, 24);
            this.dateEnd.TabIndex = 2;
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(482, 20);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(148, 24);
            this.dateStart.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(101, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(249, 24);
            this.txtSearch.TabIndex = 0;
            // 
            // Coaleser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 679);
            this.Controls.Add(this.pnlMain);
            this.Name = "Coaleser";
            this.Text = "Coaleser";
            this.pnlMain.ResumeLayout(false);
            this.pnlSelected.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            this.pnlFiles.ResumeLayout(false);
            this.pnlTextFile.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSelected;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Panel pnlFiles;
        private System.Windows.Forms.Panel pnlTextFile;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
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
    }
}