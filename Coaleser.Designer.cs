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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlTextFile = new System.Windows.Forms.Panel();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.pnlSelected = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.rtxtSearchResult = new System.Windows.Forms.RichTextBox();
            this.rtextFileBrowser = new System.Windows.Forms.RichTextBox();
            this.rtextSelectedFiles = new System.Windows.Forms.RichTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlTextFile.SuspendLayout();
            this.pnlFiles.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.pnlSelected.SuspendLayout();
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
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSearch.Controls.Add(this.lblEndDate);
            this.pnlSearch.Controls.Add(this.lblStartDate);
            this.pnlSearch.Controls.Add(this.lblCategory);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.comboBox1);
            this.pnlSearch.Controls.Add(this.dateEnd);
            this.pnlSearch.Controls.Add(this.dateStart);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(3, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1211, 107);
            this.pnlSearch.TabIndex = 0;
            // 
            // pnlTextFile
            // 
            this.pnlTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTextFile.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlTextFile.Controls.Add(this.rtxtSearchResult);
            this.pnlTextFile.Location = new System.Drawing.Point(3, 394);
            this.pnlTextFile.Name = "pnlTextFile";
            this.pnlTextFile.Size = new System.Drawing.Size(1211, 282);
            this.pnlTextFile.TabIndex = 1;
            // 
            // pnlFiles
            // 
            this.pnlFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiles.BackColor = System.Drawing.Color.Yellow;
            this.pnlFiles.Controls.Add(this.rtextFileBrowser);
            this.pnlFiles.Location = new System.Drawing.Point(3, 116);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(779, 272);
            this.pnlFiles.TabIndex = 2;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // rtxtSearchResult
            // 
            this.rtxtSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtSearchResult.Location = new System.Drawing.Point(9, 17);
            this.rtxtSearchResult.Name = "rtxtSearchResult";
            this.rtxtSearchResult.Size = new System.Drawing.Size(1193, 256);
            this.rtxtSearchResult.TabIndex = 0;
            this.rtxtSearchResult.Text = "";
            // 
            // rtextFileBrowser
            // 
            this.rtextFileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtextFileBrowser.Location = new System.Drawing.Point(7, 17);
            this.rtextFileBrowser.Name = "rtextFileBrowser";
            this.rtextFileBrowser.Size = new System.Drawing.Size(744, 240);
            this.rtextFileBrowser.TabIndex = 0;
            this.rtextFileBrowser.Text = "";
            // 
            // rtextSelectedFiles
            // 
            this.rtextSelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtextSelectedFiles.Location = new System.Drawing.Point(13, 17);
            this.rtextSelectedFiles.Name = "rtextSelectedFiles";
            this.rtextSelectedFiles.Size = new System.Drawing.Size(332, 240);
            this.rtextSelectedFiles.TabIndex = 0;
            this.rtextSelectedFiles.Text = "";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(101, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(249, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(482, 20);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(148, 20);
            this.dateStart.TabIndex = 1;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(482, 56);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(148, 20);
            this.dateEnd.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Offline",
            "Update",
            "Smart Scan",
            "Performance",
            "DLP"});
            this.comboBox1.Location = new System.Drawing.Point(101, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(9, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 19);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(9, 55);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 19);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(378, 20);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(93, 19);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(378, 55);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(83, 19);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date:";
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
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlTextFile.ResumeLayout(false);
            this.pnlFiles.ResumeLayout(false);
            this.pnlBtn.ResumeLayout(false);
            this.pnlSelected.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox rtextFileBrowser;
        private System.Windows.Forms.RichTextBox rtxtSearchResult;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
    }
}