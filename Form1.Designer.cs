namespace Log_Analyzer
{
    partial class Form1
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.prog_perFile = new System.Windows.Forms.ProgressBar();
            this.pnl_Toolbar = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabSystem = new System.Windows.Forms.TabControl();
            this.tabSystemInfo = new System.Windows.Forms.TabPage();
            this.lblFreeDiskSpace_value = new System.Windows.Forms.Label();
            this.lblRam_value = new System.Windows.Forms.Label();
            this.lblCPU_value = new System.Windows.Forms.Label();
            this.lblSystemArchitecture_value = new System.Windows.Forms.Label();
            this.lblOSver_value = new System.Windows.Forms.Label();
            this.lblOperatingSystem_value = new System.Windows.Forms.Label();
            this.lblDns_value = new System.Windows.Forms.Label();
            this.lblGateway_value = new System.Windows.Forms.Label();
            this.lblIPAddress_value = new System.Windows.Forms.Label();
            this.lblHostname_value = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblFreeDiskSpace = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblOSver = new System.Windows.Forms.Label();
            this.lblSystemArchitecture = new System.Windows.Forms.Label();
            this.lblOperatingSystem = new System.Windows.Forms.Label();
            this.lblGateway = new System.Windows.Forms.Label();
            this.lblDns = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblHostname = new System.Windows.Forms.Label();
            this.tabAgentInfo = new System.Windows.Forms.TabPage();
            this.lblSmartScanPatternVer_value = new System.Windows.Forms.Label();
            this.lblConvenPtnVer_value = new System.Windows.Forms.Label();
            this.lblEngineVersion_value = new System.Windows.Forms.Label();
            this.lblAgentLocation_value = new System.Windows.Forms.Label();
            this.lblUpdateAgentAddr_value = new System.Windows.Forms.Label();
            this.lblUpdateAgentPort_value = new System.Windows.Forms.Label();
            this.lblUpdateAgent_value = new System.Windows.Forms.Label();
            this.lblAgentPort_value = new System.Windows.Forms.Label();
            this.lblServerHttpsPort_value = new System.Windows.Forms.Label();
            this.lblServerHttpPort_value = new System.Windows.Forms.Label();
            this.lblAgentAddr_value = new System.Windows.Forms.Label();
            this.lblAgentBuild_value = new System.Windows.Forms.Label();
            this.lblAgentVersion_value = new System.Windows.Forms.Label();
            this.lblAgentLocation = new System.Windows.Forms.Label();
            this.lblSmartScanPatternVer = new System.Windows.Forms.Label();
            this.lblConvenPtnVer = new System.Windows.Forms.Label();
            this.lblEngineVersion = new System.Windows.Forms.Label();
            this.lblUpdateAgentPort = new System.Windows.Forms.Label();
            this.lblServerHttpsPort = new System.Windows.Forms.Label();
            this.lblServerHttpPort = new System.Windows.Forms.Label();
            this.lblUpdateAgentAddr = new System.Windows.Forms.Label();
            this.lblUpdateAgent = new System.Windows.Forms.Label();
            this.lblAgentPort = new System.Windows.Forms.Label();
            this.lblAgentVersion = new System.Windows.Forms.Label();
            this.lblAgentBuild = new System.Windows.Forms.Label();
            this.lblAgentAddr = new System.Windows.Forms.Label();
            this.tabKnownError = new System.Windows.Forms.TabPage();
            this.grid_KnownError = new System.Windows.Forms.DataGridView();
            this.colErrorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnl_Filter = new System.Windows.Forms.Panel();
            this.prog_Open = new System.Windows.Forms.ProgressBar();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txt_Fltr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coalescerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.pnl_Toolbar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabSystem.SuspendLayout();
            this.tabSystemInfo.SuspendLayout();
            this.tabAgentInfo.SuspendLayout();
            this.tabKnownError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KnownError)).BeginInit();
            this.pnl_Filter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.prog_perFile);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnl_Toolbar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnl_Filter);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1303, 655);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1303, 679);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // prog_perFile
            // 
            this.prog_perFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prog_perFile.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prog_perFile.Location = new System.Drawing.Point(0, 645);
            this.prog_perFile.Name = "prog_perFile";
            this.prog_perFile.Size = new System.Drawing.Size(1303, 10);
            this.prog_perFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prog_perFile.TabIndex = 41;
            // 
            // pnl_Toolbar
            // 
            this.pnl_Toolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Toolbar.BackColor = System.Drawing.Color.DarkRed;
            this.pnl_Toolbar.Controls.Add(this.tabControl1);
            this.pnl_Toolbar.Location = new System.Drawing.Point(3, 109);
            this.pnl_Toolbar.Name = "pnl_Toolbar";
            this.pnl_Toolbar.Size = new System.Drawing.Size(1297, 543);
            this.pnl_Toolbar.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1291, 531);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TabSystem);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1283, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabSystem
            // 
            this.TabSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSystem.Controls.Add(this.tabSystemInfo);
            this.TabSystem.Controls.Add(this.tabAgentInfo);
            this.TabSystem.Controls.Add(this.tabKnownError);
            this.TabSystem.Location = new System.Drawing.Point(3, 3);
            this.TabSystem.Name = "TabSystem";
            this.TabSystem.SelectedIndex = 0;
            this.TabSystem.Size = new System.Drawing.Size(1274, 496);
            this.TabSystem.TabIndex = 0;
            // 
            // tabSystemInfo
            // 
            this.tabSystemInfo.AllowDrop = true;
            this.tabSystemInfo.Controls.Add(this.lblFreeDiskSpace_value);
            this.tabSystemInfo.Controls.Add(this.lblRam_value);
            this.tabSystemInfo.Controls.Add(this.lblCPU_value);
            this.tabSystemInfo.Controls.Add(this.lblSystemArchitecture_value);
            this.tabSystemInfo.Controls.Add(this.lblOSver_value);
            this.tabSystemInfo.Controls.Add(this.lblOperatingSystem_value);
            this.tabSystemInfo.Controls.Add(this.lblDns_value);
            this.tabSystemInfo.Controls.Add(this.lblGateway_value);
            this.tabSystemInfo.Controls.Add(this.lblIPAddress_value);
            this.tabSystemInfo.Controls.Add(this.lblHostname_value);
            this.tabSystemInfo.Controls.Add(this.lblCPU);
            this.tabSystemInfo.Controls.Add(this.lblFreeDiskSpace);
            this.tabSystemInfo.Controls.Add(this.lblRam);
            this.tabSystemInfo.Controls.Add(this.lblOSver);
            this.tabSystemInfo.Controls.Add(this.lblSystemArchitecture);
            this.tabSystemInfo.Controls.Add(this.lblOperatingSystem);
            this.tabSystemInfo.Controls.Add(this.lblGateway);
            this.tabSystemInfo.Controls.Add(this.lblDns);
            this.tabSystemInfo.Controls.Add(this.lblIPAddress);
            this.tabSystemInfo.Controls.Add(this.lblHostname);
            this.tabSystemInfo.Location = new System.Drawing.Point(4, 22);
            this.tabSystemInfo.Name = "tabSystemInfo";
            this.tabSystemInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystemInfo.Size = new System.Drawing.Size(1266, 470);
            this.tabSystemInfo.TabIndex = 0;
            this.tabSystemInfo.Text = "System Information";
            this.tabSystemInfo.UseVisualStyleBackColor = true;
            // 
            // lblFreeDiskSpace_value
            // 
            this.lblFreeDiskSpace_value.AutoSize = true;
            this.lblFreeDiskSpace_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeDiskSpace_value.Location = new System.Drawing.Point(194, 353);
            this.lblFreeDiskSpace_value.Name = "lblFreeDiskSpace_value";
            this.lblFreeDiskSpace_value.Size = new System.Drawing.Size(0, 21);
            this.lblFreeDiskSpace_value.TabIndex = 29;
            // 
            // lblRam_value
            // 
            this.lblRam_value.AutoSize = true;
            this.lblRam_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam_value.Location = new System.Drawing.Point(194, 323);
            this.lblRam_value.Name = "lblRam_value";
            this.lblRam_value.Size = new System.Drawing.Size(0, 21);
            this.lblRam_value.TabIndex = 28;
            // 
            // lblCPU_value
            // 
            this.lblCPU_value.AutoSize = true;
            this.lblCPU_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU_value.Location = new System.Drawing.Point(194, 289);
            this.lblCPU_value.Name = "lblCPU_value";
            this.lblCPU_value.Size = new System.Drawing.Size(0, 21);
            this.lblCPU_value.TabIndex = 27;
            // 
            // lblSystemArchitecture_value
            // 
            this.lblSystemArchitecture_value.AutoSize = true;
            this.lblSystemArchitecture_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemArchitecture_value.Location = new System.Drawing.Point(194, 255);
            this.lblSystemArchitecture_value.Name = "lblSystemArchitecture_value";
            this.lblSystemArchitecture_value.Size = new System.Drawing.Size(0, 21);
            this.lblSystemArchitecture_value.TabIndex = 26;
            // 
            // lblOSver_value
            // 
            this.lblOSver_value.AutoSize = true;
            this.lblOSver_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSver_value.Location = new System.Drawing.Point(194, 224);
            this.lblOSver_value.Name = "lblOSver_value";
            this.lblOSver_value.Size = new System.Drawing.Size(0, 21);
            this.lblOSver_value.TabIndex = 25;
            // 
            // lblOperatingSystem_value
            // 
            this.lblOperatingSystem_value.AutoSize = true;
            this.lblOperatingSystem_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatingSystem_value.Location = new System.Drawing.Point(194, 189);
            this.lblOperatingSystem_value.Name = "lblOperatingSystem_value";
            this.lblOperatingSystem_value.Size = new System.Drawing.Size(0, 21);
            this.lblOperatingSystem_value.TabIndex = 24;
            // 
            // lblDns_value
            // 
            this.lblDns_value.AutoSize = true;
            this.lblDns_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDns_value.Location = new System.Drawing.Point(115, 116);
            this.lblDns_value.Name = "lblDns_value";
            this.lblDns_value.Size = new System.Drawing.Size(0, 21);
            this.lblDns_value.TabIndex = 23;
            // 
            // lblGateway_value
            // 
            this.lblGateway_value.AutoSize = true;
            this.lblGateway_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateway_value.Location = new System.Drawing.Point(115, 86);
            this.lblGateway_value.Name = "lblGateway_value";
            this.lblGateway_value.Size = new System.Drawing.Size(0, 21);
            this.lblGateway_value.TabIndex = 22;
            // 
            // lblIPAddress_value
            // 
            this.lblIPAddress_value.AutoSize = true;
            this.lblIPAddress_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress_value.Location = new System.Drawing.Point(115, 56);
            this.lblIPAddress_value.Name = "lblIPAddress_value";
            this.lblIPAddress_value.Size = new System.Drawing.Size(0, 21);
            this.lblIPAddress_value.TabIndex = 21;
            // 
            // lblHostname_value
            // 
            this.lblHostname_value.AutoSize = true;
            this.lblHostname_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname_value.Location = new System.Drawing.Point(115, 20);
            this.lblHostname_value.Name = "lblHostname_value";
            this.lblHostname_value.Size = new System.Drawing.Size(0, 21);
            this.lblHostname_value.TabIndex = 20;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(18, 289);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(47, 21);
            this.lblCPU.TabIndex = 19;
            this.lblCPU.Text = "CPU:";
            // 
            // lblFreeDiskSpace
            // 
            this.lblFreeDiskSpace.AutoSize = true;
            this.lblFreeDiskSpace.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeDiskSpace.Location = new System.Drawing.Point(18, 353);
            this.lblFreeDiskSpace.Name = "lblFreeDiskSpace";
            this.lblFreeDiskSpace.Size = new System.Drawing.Size(134, 21);
            this.lblFreeDiskSpace.TabIndex = 8;
            this.lblFreeDiskSpace.Text = "Free Disk Space:";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.Location = new System.Drawing.Point(18, 323);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(52, 21);
            this.lblRam.TabIndex = 7;
            this.lblRam.Text = "RAM:";
            // 
            // lblOSver
            // 
            this.lblOSver.AutoSize = true;
            this.lblOSver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSver.Location = new System.Drawing.Point(18, 224);
            this.lblOSver.Name = "lblOSver";
            this.lblOSver.Size = new System.Drawing.Size(95, 21);
            this.lblOSver.TabIndex = 6;
            this.lblOSver.Text = "OS Version:";
            // 
            // lblSystemArchitecture
            // 
            this.lblSystemArchitecture.AutoSize = true;
            this.lblSystemArchitecture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemArchitecture.Location = new System.Drawing.Point(18, 255);
            this.lblSystemArchitecture.Name = "lblSystemArchitecture";
            this.lblSystemArchitecture.Size = new System.Drawing.Size(172, 21);
            this.lblSystemArchitecture.TabIndex = 5;
            this.lblSystemArchitecture.Text = "System Architecture:";
            // 
            // lblOperatingSystem
            // 
            this.lblOperatingSystem.AutoSize = true;
            this.lblOperatingSystem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatingSystem.Location = new System.Drawing.Point(15, 189);
            this.lblOperatingSystem.Name = "lblOperatingSystem";
            this.lblOperatingSystem.Size = new System.Drawing.Size(154, 21);
            this.lblOperatingSystem.TabIndex = 4;
            this.lblOperatingSystem.Text = "Operating System:";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateway.Location = new System.Drawing.Point(15, 86);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(89, 21);
            this.lblGateway.TabIndex = 3;
            this.lblGateway.Text = "Gateway:";
            // 
            // lblDns
            // 
            this.lblDns.AutoSize = true;
            this.lblDns.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDns.Location = new System.Drawing.Point(15, 116);
            this.lblDns.Name = "lblDns";
            this.lblDns.Size = new System.Drawing.Size(46, 21);
            this.lblDns.TabIndex = 2;
            this.lblDns.Text = "DNS:";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Location = new System.Drawing.Point(15, 56);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(94, 21);
            this.lblIPAddress.TabIndex = 1;
            this.lblIPAddress.Text = "IP Address:";
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname.Location = new System.Drawing.Point(15, 20);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(94, 21);
            this.lblHostname.TabIndex = 0;
            this.lblHostname.Text = "Hostname:";
            // 
            // tabAgentInfo
            // 
            this.tabAgentInfo.Controls.Add(this.lblSmartScanPatternVer_value);
            this.tabAgentInfo.Controls.Add(this.lblConvenPtnVer_value);
            this.tabAgentInfo.Controls.Add(this.lblEngineVersion_value);
            this.tabAgentInfo.Controls.Add(this.lblAgentLocation_value);
            this.tabAgentInfo.Controls.Add(this.lblUpdateAgentAddr_value);
            this.tabAgentInfo.Controls.Add(this.lblUpdateAgentPort_value);
            this.tabAgentInfo.Controls.Add(this.lblUpdateAgent_value);
            this.tabAgentInfo.Controls.Add(this.lblAgentPort_value);
            this.tabAgentInfo.Controls.Add(this.lblServerHttpsPort_value);
            this.tabAgentInfo.Controls.Add(this.lblServerHttpPort_value);
            this.tabAgentInfo.Controls.Add(this.lblAgentAddr_value);
            this.tabAgentInfo.Controls.Add(this.lblAgentBuild_value);
            this.tabAgentInfo.Controls.Add(this.lblAgentVersion_value);
            this.tabAgentInfo.Controls.Add(this.lblAgentLocation);
            this.tabAgentInfo.Controls.Add(this.lblSmartScanPatternVer);
            this.tabAgentInfo.Controls.Add(this.lblConvenPtnVer);
            this.tabAgentInfo.Controls.Add(this.lblEngineVersion);
            this.tabAgentInfo.Controls.Add(this.lblUpdateAgentPort);
            this.tabAgentInfo.Controls.Add(this.lblServerHttpsPort);
            this.tabAgentInfo.Controls.Add(this.lblServerHttpPort);
            this.tabAgentInfo.Controls.Add(this.lblUpdateAgentAddr);
            this.tabAgentInfo.Controls.Add(this.lblUpdateAgent);
            this.tabAgentInfo.Controls.Add(this.lblAgentPort);
            this.tabAgentInfo.Controls.Add(this.lblAgentVersion);
            this.tabAgentInfo.Controls.Add(this.lblAgentBuild);
            this.tabAgentInfo.Controls.Add(this.lblAgentAddr);
            this.tabAgentInfo.Location = new System.Drawing.Point(4, 22);
            this.tabAgentInfo.Name = "tabAgentInfo";
            this.tabAgentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgentInfo.Size = new System.Drawing.Size(1266, 470);
            this.tabAgentInfo.TabIndex = 1;
            this.tabAgentInfo.Text = "Agent Information";
            this.tabAgentInfo.UseVisualStyleBackColor = true;
            // 
            // lblSmartScanPatternVer_value
            // 
            this.lblSmartScanPatternVer_value.AutoSize = true;
            this.lblSmartScanPatternVer_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmartScanPatternVer_value.Location = new System.Drawing.Point(902, 121);
            this.lblSmartScanPatternVer_value.Name = "lblSmartScanPatternVer_value";
            this.lblSmartScanPatternVer_value.Size = new System.Drawing.Size(0, 21);
            this.lblSmartScanPatternVer_value.TabIndex = 39;
            // 
            // lblConvenPtnVer_value
            // 
            this.lblConvenPtnVer_value.AutoSize = true;
            this.lblConvenPtnVer_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenPtnVer_value.Location = new System.Drawing.Point(902, 85);
            this.lblConvenPtnVer_value.Name = "lblConvenPtnVer_value";
            this.lblConvenPtnVer_value.Size = new System.Drawing.Size(0, 21);
            this.lblConvenPtnVer_value.TabIndex = 38;
            // 
            // lblEngineVersion_value
            // 
            this.lblEngineVersion_value.AutoSize = true;
            this.lblEngineVersion_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineVersion_value.Location = new System.Drawing.Point(902, 52);
            this.lblEngineVersion_value.Name = "lblEngineVersion_value";
            this.lblEngineVersion_value.Size = new System.Drawing.Size(0, 21);
            this.lblEngineVersion_value.TabIndex = 37;
            // 
            // lblAgentLocation_value
            // 
            this.lblAgentLocation_value.AutoSize = true;
            this.lblAgentLocation_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentLocation_value.Location = new System.Drawing.Point(902, 19);
            this.lblAgentLocation_value.Name = "lblAgentLocation_value";
            this.lblAgentLocation_value.Size = new System.Drawing.Size(0, 21);
            this.lblAgentLocation_value.TabIndex = 36;
            // 
            // lblUpdateAgentAddr_value
            // 
            this.lblUpdateAgentAddr_value.AutoSize = true;
            this.lblUpdateAgentAddr_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAgentAddr_value.Location = new System.Drawing.Point(236, 306);
            this.lblUpdateAgentAddr_value.Name = "lblUpdateAgentAddr_value";
            this.lblUpdateAgentAddr_value.Size = new System.Drawing.Size(0, 21);
            this.lblUpdateAgentAddr_value.TabIndex = 35;
            // 
            // lblUpdateAgentPort_value
            // 
            this.lblUpdateAgentPort_value.AutoSize = true;
            this.lblUpdateAgentPort_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAgentPort_value.Location = new System.Drawing.Point(236, 270);
            this.lblUpdateAgentPort_value.Name = "lblUpdateAgentPort_value";
            this.lblUpdateAgentPort_value.Size = new System.Drawing.Size(0, 21);
            this.lblUpdateAgentPort_value.TabIndex = 34;
            // 
            // lblUpdateAgent_value
            // 
            this.lblUpdateAgent_value.AutoSize = true;
            this.lblUpdateAgent_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAgent_value.Location = new System.Drawing.Point(236, 231);
            this.lblUpdateAgent_value.Name = "lblUpdateAgent_value";
            this.lblUpdateAgent_value.Size = new System.Drawing.Size(0, 21);
            this.lblUpdateAgent_value.TabIndex = 33;
            // 
            // lblAgentPort_value
            // 
            this.lblAgentPort_value.AutoSize = true;
            this.lblAgentPort_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentPort_value.Location = new System.Drawing.Point(236, 196);
            this.lblAgentPort_value.Name = "lblAgentPort_value";
            this.lblAgentPort_value.Size = new System.Drawing.Size(0, 21);
            this.lblAgentPort_value.TabIndex = 32;
            // 
            // lblServerHttpsPort_value
            // 
            this.lblServerHttpsPort_value.AutoSize = true;
            this.lblServerHttpsPort_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerHttpsPort_value.Location = new System.Drawing.Point(236, 158);
            this.lblServerHttpsPort_value.Name = "lblServerHttpsPort_value";
            this.lblServerHttpsPort_value.Size = new System.Drawing.Size(0, 21);
            this.lblServerHttpsPort_value.TabIndex = 31;
            // 
            // lblServerHttpPort_value
            // 
            this.lblServerHttpPort_value.AutoSize = true;
            this.lblServerHttpPort_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerHttpPort_value.Location = new System.Drawing.Point(236, 121);
            this.lblServerHttpPort_value.Name = "lblServerHttpPort_value";
            this.lblServerHttpPort_value.Size = new System.Drawing.Size(0, 21);
            this.lblServerHttpPort_value.TabIndex = 30;
            // 
            // lblAgentAddr_value
            // 
            this.lblAgentAddr_value.AutoSize = true;
            this.lblAgentAddr_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentAddr_value.Location = new System.Drawing.Point(236, 88);
            this.lblAgentAddr_value.Name = "lblAgentAddr_value";
            this.lblAgentAddr_value.Size = new System.Drawing.Size(0, 21);
            this.lblAgentAddr_value.TabIndex = 29;
            // 
            // lblAgentBuild_value
            // 
            this.lblAgentBuild_value.AutoSize = true;
            this.lblAgentBuild_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentBuild_value.Location = new System.Drawing.Point(236, 52);
            this.lblAgentBuild_value.Name = "lblAgentBuild_value";
            this.lblAgentBuild_value.Size = new System.Drawing.Size(0, 21);
            this.lblAgentBuild_value.TabIndex = 28;
            // 
            // lblAgentVersion_value
            // 
            this.lblAgentVersion_value.AutoSize = true;
            this.lblAgentVersion_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentVersion_value.Location = new System.Drawing.Point(236, 19);
            this.lblAgentVersion_value.Name = "lblAgentVersion_value";
            this.lblAgentVersion_value.Size = new System.Drawing.Size(0, 21);
            this.lblAgentVersion_value.TabIndex = 27;
            // 
            // lblAgentLocation
            // 
            this.lblAgentLocation.AutoSize = true;
            this.lblAgentLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentLocation.Location = new System.Drawing.Point(653, 19);
            this.lblAgentLocation.Name = "lblAgentLocation";
            this.lblAgentLocation.Size = new System.Drawing.Size(137, 21);
            this.lblAgentLocation.TabIndex = 26;
            this.lblAgentLocation.Text = "Agent Location:";
            // 
            // lblSmartScanPatternVer
            // 
            this.lblSmartScanPatternVer.AutoSize = true;
            this.lblSmartScanPatternVer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmartScanPatternVer.Location = new System.Drawing.Point(653, 121);
            this.lblSmartScanPatternVer.Name = "lblSmartScanPatternVer";
            this.lblSmartScanPatternVer.Size = new System.Drawing.Size(225, 21);
            this.lblSmartScanPatternVer.TabIndex = 25;
            this.lblSmartScanPatternVer.Text = "Smart Scan Pattern Version:";
            // 
            // lblConvenPtnVer
            // 
            this.lblConvenPtnVer.AutoSize = true;
            this.lblConvenPtnVer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenPtnVer.Location = new System.Drawing.Point(653, 85);
            this.lblConvenPtnVer.Name = "lblConvenPtnVer";
            this.lblConvenPtnVer.Size = new System.Drawing.Size(243, 21);
            this.lblConvenPtnVer.TabIndex = 24;
            this.lblConvenPtnVer.Text = "Conventional Pattern Version:";
            // 
            // lblEngineVersion
            // 
            this.lblEngineVersion.AutoSize = true;
            this.lblEngineVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineVersion.Location = new System.Drawing.Point(653, 52);
            this.lblEngineVersion.Name = "lblEngineVersion";
            this.lblEngineVersion.Size = new System.Drawing.Size(126, 21);
            this.lblEngineVersion.TabIndex = 23;
            this.lblEngineVersion.Text = "Engine Version:";
            // 
            // lblUpdateAgentPort
            // 
            this.lblUpdateAgentPort.AutoSize = true;
            this.lblUpdateAgentPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAgentPort.Location = new System.Drawing.Point(20, 270);
            this.lblUpdateAgentPort.Name = "lblUpdateAgentPort";
            this.lblUpdateAgentPort.Size = new System.Drawing.Size(165, 21);
            this.lblUpdateAgentPort.TabIndex = 22;
            this.lblUpdateAgentPort.Text = "Update Agent Port:";
            // 
            // lblServerHttpsPort
            // 
            this.lblServerHttpsPort.AutoSize = true;
            this.lblServerHttpsPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerHttpsPort.Location = new System.Drawing.Point(20, 158);
            this.lblServerHttpsPort.Name = "lblServerHttpsPort";
            this.lblServerHttpsPort.Size = new System.Drawing.Size(145, 21);
            this.lblServerHttpsPort.TabIndex = 21;
            this.lblServerHttpsPort.Text = "Server HTTPS Port:";
            // 
            // lblServerHttpPort
            // 
            this.lblServerHttpPort.AutoSize = true;
            this.lblServerHttpPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerHttpPort.Location = new System.Drawing.Point(20, 121);
            this.lblServerHttpPort.Name = "lblServerHttpPort";
            this.lblServerHttpPort.Size = new System.Drawing.Size(137, 21);
            this.lblServerHttpPort.TabIndex = 20;
            this.lblServerHttpPort.Text = "Server HTTP Port:";
            // 
            // lblUpdateAgentAddr
            // 
            this.lblUpdateAgentAddr.AutoSize = true;
            this.lblUpdateAgentAddr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAgentAddr.Location = new System.Drawing.Point(20, 306);
            this.lblUpdateAgentAddr.Name = "lblUpdateAgentAddr";
            this.lblUpdateAgentAddr.Size = new System.Drawing.Size(196, 21);
            this.lblUpdateAgentAddr.TabIndex = 19;
            this.lblUpdateAgentAddr.Text = "Update Agent Address:";
            // 
            // lblUpdateAgent
            // 
            this.lblUpdateAgent.AutoSize = true;
            this.lblUpdateAgent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAgent.Location = new System.Drawing.Point(20, 231);
            this.lblUpdateAgent.Name = "lblUpdateAgent";
            this.lblUpdateAgent.Size = new System.Drawing.Size(130, 21);
            this.lblUpdateAgent.TabIndex = 18;
            this.lblUpdateAgent.Text = "Update Agent:";
            // 
            // lblAgentPort
            // 
            this.lblAgentPort.AutoSize = true;
            this.lblAgentPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentPort.Location = new System.Drawing.Point(20, 196);
            this.lblAgentPort.Name = "lblAgentPort";
            this.lblAgentPort.Size = new System.Drawing.Size(100, 21);
            this.lblAgentPort.TabIndex = 17;
            this.lblAgentPort.Text = "Agent Port:";
            // 
            // lblAgentVersion
            // 
            this.lblAgentVersion.AutoSize = true;
            this.lblAgentVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentVersion.Location = new System.Drawing.Point(20, 19);
            this.lblAgentVersion.Name = "lblAgentVersion";
            this.lblAgentVersion.Size = new System.Drawing.Size(120, 21);
            this.lblAgentVersion.TabIndex = 16;
            this.lblAgentVersion.Text = "Agent Version";
            // 
            // lblAgentBuild
            // 
            this.lblAgentBuild.AutoSize = true;
            this.lblAgentBuild.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentBuild.Location = new System.Drawing.Point(20, 52);
            this.lblAgentBuild.Name = "lblAgentBuild";
            this.lblAgentBuild.Size = new System.Drawing.Size(105, 21);
            this.lblAgentBuild.TabIndex = 15;
            this.lblAgentBuild.Text = "Agent Build:";
            // 
            // lblAgentAddr
            // 
            this.lblAgentAddr.AutoSize = true;
            this.lblAgentAddr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentAddr.Location = new System.Drawing.Point(20, 88);
            this.lblAgentAddr.Name = "lblAgentAddr";
            this.lblAgentAddr.Size = new System.Drawing.Size(128, 21);
            this.lblAgentAddr.TabIndex = 14;
            this.lblAgentAddr.Text = "Server Address:";
            // 
            // tabKnownError
            // 
            this.tabKnownError.Controls.Add(this.grid_KnownError);
            this.tabKnownError.Location = new System.Drawing.Point(4, 22);
            this.tabKnownError.Name = "tabKnownError";
            this.tabKnownError.Size = new System.Drawing.Size(1266, 470);
            this.tabKnownError.TabIndex = 2;
            this.tabKnownError.Text = "Known Error";
            this.tabKnownError.UseVisualStyleBackColor = true;
            // 
            // grid_KnownError
            // 
            this.grid_KnownError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_KnownError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_KnownError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colErrorCode,
            this.colDescription,
            this.colSolution});
            this.grid_KnownError.Location = new System.Drawing.Point(25, 30);
            this.grid_KnownError.Name = "grid_KnownError";
            this.grid_KnownError.Size = new System.Drawing.Size(902, 303);
            this.grid_KnownError.TabIndex = 0;
            // 
            // colErrorCode
            // 
            this.colErrorCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colErrorCode.HeaderText = "Error Code";
            this.colErrorCode.Name = "colErrorCode";
            this.colErrorCode.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colSolution
            // 
            this.colSolution.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSolution.HeaderText = "Solution";
            this.colSolution.Name = "colSolution";
            this.colSolution.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1283, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnl_Filter
            // 
            this.pnl_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Filter.BackColor = System.Drawing.Color.Azure;
            this.pnl_Filter.Controls.Add(this.prog_Open);
            this.pnl_Filter.Controls.Add(this.btnFilter);
            this.pnl_Filter.Controls.Add(this.txt_Fltr);
            this.pnl_Filter.Controls.Add(this.label1);
            this.pnl_Filter.Location = new System.Drawing.Point(3, 3);
            this.pnl_Filter.Name = "pnl_Filter";
            this.pnl_Filter.Size = new System.Drawing.Size(1297, 100);
            this.pnl_Filter.TabIndex = 0;
            // 
            // prog_Open
            // 
            this.prog_Open.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prog_Open.Location = new System.Drawing.Point(14, 55);
            this.prog_Open.Name = "prog_Open";
            this.prog_Open.Size = new System.Drawing.Size(676, 23);
            this.prog_Open.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prog_Open.TabIndex = 40;
            this.prog_Open.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(365, 15);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "button1";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // txt_Fltr
            // 
            this.txt_Fltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fltr.Location = new System.Drawing.Point(66, 13);
            this.txt_Fltr.Name = "txt_Fltr";
            this.txt_Fltr.Size = new System.Drawing.Size(254, 24);
            this.txt_Fltr.TabIndex = 2;
            this.txt_Fltr.TextChanged += new System.EventHandler(this.txt_Fltr_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.formatToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coalescerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // coalescerToolStripMenuItem
            // 
            this.coalescerToolStripMenuItem.Name = "coalescerToolStripMenuItem";
            this.coalescerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.coalescerToolStripMenuItem.Text = "Coalescer";
            this.coalescerToolStripMenuItem.Click += new System.EventHandler(this.coalescerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 679);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Analyzer V1 Beta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.pnl_Toolbar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TabSystem.ResumeLayout(false);
            this.tabSystemInfo.ResumeLayout(false);
            this.tabSystemInfo.PerformLayout();
            this.tabAgentInfo.ResumeLayout(false);
            this.tabAgentInfo.PerformLayout();
            this.tabKnownError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KnownError)).EndInit();
            this.pnl_Filter.ResumeLayout(false);
            this.pnl_Filter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel pnl_Toolbar;
        private System.Windows.Forms.Panel pnl_Filter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Fltr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl TabSystem;
        private System.Windows.Forms.TabPage tabSystemInfo;
        private System.Windows.Forms.TabPage tabAgentInfo;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coalescerToolStripMenuItem;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.Label lblDns;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.Label lblOSver;
        private System.Windows.Forms.Label lblSystemArchitecture;
        private System.Windows.Forms.Label lblOperatingSystem;
        private System.Windows.Forms.Label lblFreeDiskSpace;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblUpdateAgentPort;
        private System.Windows.Forms.Label lblServerHttpsPort;
        private System.Windows.Forms.Label lblServerHttpPort;
        private System.Windows.Forms.Label lblUpdateAgentAddr;
        private System.Windows.Forms.Label lblUpdateAgent;
        private System.Windows.Forms.Label lblAgentPort;
        private System.Windows.Forms.Label lblAgentVersion;
        private System.Windows.Forms.Label lblAgentBuild;
        private System.Windows.Forms.Label lblAgentAddr;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblAgentLocation;
        private System.Windows.Forms.Label lblSmartScanPatternVer;
        private System.Windows.Forms.Label lblConvenPtnVer;
        private System.Windows.Forms.Label lblEngineVersion;
        private System.Windows.Forms.Label lblHostname_value;
        private System.Windows.Forms.Label lblIPAddress_value;
        private System.Windows.Forms.Label lblDns_value;
        private System.Windows.Forms.Label lblGateway_value;
        private System.Windows.Forms.Label lblFreeDiskSpace_value;
        private System.Windows.Forms.Label lblRam_value;
        private System.Windows.Forms.Label lblCPU_value;
        private System.Windows.Forms.Label lblSystemArchitecture_value;
        private System.Windows.Forms.Label lblOSver_value;
        private System.Windows.Forms.Label lblOperatingSystem_value;
        private System.Windows.Forms.Label lblSmartScanPatternVer_value;
        private System.Windows.Forms.Label lblConvenPtnVer_value;
        private System.Windows.Forms.Label lblEngineVersion_value;
        private System.Windows.Forms.Label lblAgentLocation_value;
        private System.Windows.Forms.Label lblUpdateAgentAddr_value;
        private System.Windows.Forms.Label lblUpdateAgentPort_value;
        private System.Windows.Forms.Label lblUpdateAgent_value;
        private System.Windows.Forms.Label lblAgentPort_value;
        private System.Windows.Forms.Label lblServerHttpsPort_value;
        private System.Windows.Forms.Label lblServerHttpPort_value;
        private System.Windows.Forms.Label lblAgentAddr_value;
        private System.Windows.Forms.Label lblAgentBuild_value;
        private System.Windows.Forms.Label lblAgentVersion_value;
        private System.Windows.Forms.ProgressBar prog_Open;
        private System.Windows.Forms.ProgressBar prog_perFile;
        private System.Windows.Forms.TabPage tabKnownError;
        private System.Windows.Forms.DataGridView grid_KnownError;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolution;
    }
}

