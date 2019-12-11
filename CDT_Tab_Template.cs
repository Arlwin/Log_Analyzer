using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Analyzer
{
    class CDT_Tab_Template
    {
        //For the files per each CDT
        //Location of the file, accessible to anywhere 
        public string full_path { get; set; }

        //Extraction path
        public string extract_path { get; set; }

        //Imported CSVs [STATIC | For all CDTs]
        public static string imported_CSV_offline { get; set; }
        public static string imported_CSV_update { get; set; }

        //For the Known Errors grid
        private List<List<string>> ErrorsList;

        //DECLARATIONS of elements
        DataGridView grid_KnownError;
        RichTextBox txtResults;


        public CDT_Tab_Template(TabPage tp)
        {
            //Create the tab control
            TabControl tc = createTabControl();

            //Add the tab control to the TabPage
            tp.Controls.Add(tc);
        }




        private TabControl createTabControl()
        {
            TabControl tc = new TabControl();

            //Design the Tab Control
            tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            tc.Location = new System.Drawing.Point(4, 4);
            tc.Margin = new System.Windows.Forms.Padding(4);
            tc.Name = "TabSystem";
            tc.SelectedIndex = 0;
            tc.Size = new System.Drawing.Size(1276, 766);
            tc.TabIndex = 0;

            //Add the system information page
            tc.TabPages.Add(createSysInfoPage());

            //Add the agent information page
            tc.TabPages.Add(createAgentInfoPage());

            //Add the known errors page
            tc.TabPages.Add(createKnownErrorsPage());

            //Add the update issues page
            tc.TabPages.Add(createUpdateIssuePage());

            return tc;
        }

        //For tab pages
        private TabPage createSysInfoPage()
        {
            TabPage tp = new TabPage();

            //Design the page
            tp.AllowDrop = true;
            tp.Location = new System.Drawing.Point(4, 25);
            tp.Margin = new System.Windows.Forms.Padding(4);
            tp.Name = "tab_SystemInfo";
            tp.Padding = new System.Windows.Forms.Padding(4);
            tp.Size = new System.Drawing.Size(1268, 737);
            tp.TabIndex = 0;
            tp.Text = "System Information";
            tp.UseVisualStyleBackColor = true;

            //Create the elements inside the page
            List<Control> controls = SysInfoCreateElements();

            //Add the elements to the page
            addElements(tp, controls);

            return tp;
        }
        private TabPage createAgentInfoPage()
        {
            TabPage tp = new TabPage();

            //Design the page
            tp.Location = new System.Drawing.Point(4, 25);
            tp.Margin = new System.Windows.Forms.Padding(4);
            tp.Name = "tab_AgentInfo";
            tp.Padding = new System.Windows.Forms.Padding(4);
            tp.Size = new System.Drawing.Size(1136, 737);
            tp.TabIndex = 1;
            tp.Text = "Agent Information";
            tp.UseVisualStyleBackColor = true;

            //Create the elements inside the page
            List<Control> controls = AgentInfoCreateElements();

            //Add the elements to the page
            addElements(tp, controls);

            return tp;
        }
        private TabPage createKnownErrorsPage()
        {
            TabPage tp = new TabPage();

            //Design the page
            tp.Location = new System.Drawing.Point(4, 25);
            tp.Margin = new System.Windows.Forms.Padding(4);
            tp.Name = "tab_KnownError";
            tp.Size = new System.Drawing.Size(1136, 737);
            tp.TabIndex = 2;
            tp.Text = "Known Error";
            tp.UseVisualStyleBackColor = true;

            //Create the elements inside the page
            List<Control> controls = KnownErrorsCreateElements();

            //Add the elements to the page
            addElements(tp, controls);

            return tp;
        }
        private TabPage createUpdateIssuePage()
        {
            TabPage tp = new TabPage("Update Issues");
            tp.Name = "UpdateIssues";

            //Create the elements inside the page
            List<Control> controls = UpdateIssueCreateElements();

            //Add the elements to the page
            addElements(tp, controls);

            return tp;
        }



        //For Elements
        private List<Control> SysInfoCreateElements()
        {
            List<Control> controls = new List<Control>();

            
            // lblFreeDiskSpace
            Label lblFreeDiskSpace = new Label();
            //Design
            lblFreeDiskSpace.AutoSize = true;
            lblFreeDiskSpace.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFreeDiskSpace.Location = new System.Drawing.Point(24, 434);
            lblFreeDiskSpace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFreeDiskSpace.Name = "lblFreeDiskSpace";
            lblFreeDiskSpace.Size = new System.Drawing.Size(169, 23);
            lblFreeDiskSpace.TabIndex = 8;
            lblFreeDiskSpace.Text = "Free Disk Space:";

            // lblFreeDiskSpace_value
            Label lblFreeDiskSpace_value = new Label();
            //Design
            lblFreeDiskSpace_value.AutoSize = true;
            lblFreeDiskSpace_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblFreeDiskSpace_value.Location = new System.Drawing.Point(259, 434);
            lblFreeDiskSpace_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFreeDiskSpace_value.Name = "lblFreeDiskSpace_value";
            lblFreeDiskSpace_value.Size = new System.Drawing.Size(0, 23);
            lblFreeDiskSpace_value.TabIndex = 29;

            //Add to controls
            controls.Add(lblFreeDiskSpace);
            controls.Add(lblFreeDiskSpace_value);


            // lblRam
            Label lblRam = new Label();
            //Design
            lblRam.AutoSize = true;
            lblRam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRam.Location = new System.Drawing.Point(24, 398);
            lblRam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRam.Name = "lblRam";
            lblRam.Size = new System.Drawing.Size(59, 23);
            lblRam.TabIndex = 7;
            lblRam.Text = "RAM:";

            // lblRam_value
            Label lblRam_value = new Label();
            // Design
            lblRam_value.AutoSize = true;
            lblRam_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRam_value.Location = new System.Drawing.Point(259, 398);
            lblRam_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRam_value.Name = "lblRam_value";
            lblRam_value.Size = new System.Drawing.Size(0, 23);
            lblRam_value.TabIndex = 28;

            //Add to controls
            controls.Add(lblRam);
            controls.Add(lblRam_value);


            // lblCPU
            Label lblCPU = new Label();
            // Design
            lblCPU.AutoSize = true;
            lblCPU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCPU.Location = new System.Drawing.Point(24, 356);
            lblCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new System.Drawing.Size(56, 23);
            lblCPU.TabIndex = 19;
            lblCPU.Text = "CPU:";

            // lblCPU_value
            Label lblCPU_value = new Label();
            // Design
            lblCPU_value.AutoSize = true;
            lblCPU_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCPU_value.Location = new System.Drawing.Point(259, 356);
            lblCPU_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCPU_value.Name = "lblCPU_value";
            lblCPU_value.Size = new System.Drawing.Size(0, 23);
            lblCPU_value.TabIndex = 27;

            //Add to controls
            controls.Add(lblCPU);
            controls.Add(lblCPU_value);



            // lblSystemArchitecture
            Label lblSystemArchitecture = new Label();
            // Design 
            lblSystemArchitecture.AutoSize = true;
            lblSystemArchitecture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSystemArchitecture.Location = new System.Drawing.Point(24, 314);
            lblSystemArchitecture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSystemArchitecture.Name = "lblSystemArchitecture";
            lblSystemArchitecture.Size = new System.Drawing.Size(209, 23);
            lblSystemArchitecture.TabIndex = 5;
            lblSystemArchitecture.Text = "System Architecture:";

            // lblSystemArchitecture_value
            Label lblHostname = new Label();
            // Design
            lblHostname.AutoSize = true;
            lblHostname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHostname.Location = new System.Drawing.Point(20, 25);
            lblHostname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHostname.Name = "lblHostname";
            lblHostname.Size = new System.Drawing.Size(115, 23);
            lblHostname.TabIndex = 0;
            lblHostname.Text = "Hostname:";

            // lblHostname_value
            Label lblHostname_value = new Label();
            // Design
            lblHostname_value.AutoSize = true;
            lblHostname_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblHostname_value.Location = new System.Drawing.Point(153, 25);
            lblHostname_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHostname_value.Name = "lblHostname_value";
            lblHostname_value.Size = new System.Drawing.Size(0, 23);
            lblHostname_value.TabIndex = 20;

            //Add to controls
            controls.Add(lblHostname);
            controls.Add(lblHostname_value);



            return controls;
        }
        private List<Control> AgentInfoCreateElements()
        {
            List<Control> controls = new List<Control>();


            // lblSmartScanPatternVer
            Label lblSmartScanPatternVer = new Label();
            // Design
            lblSmartScanPatternVer.AutoSize = true;
            lblSmartScanPatternVer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSmartScanPatternVer.Location = new System.Drawing.Point(871, 149);
            lblSmartScanPatternVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSmartScanPatternVer.Name = "lblSmartScanPatternVer";
            lblSmartScanPatternVer.Size = new System.Drawing.Size(279, 23);
            lblSmartScanPatternVer.TabIndex = 25;
            lblSmartScanPatternVer.Text = "Smart Scan Pattern Version:";

            // lblSmartScanPatternVer_value
            Label lblSmartScanPatternVer_value = new Label();
            // Design
            lblSmartScanPatternVer_value.AutoSize = true;
            lblSmartScanPatternVer_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSmartScanPatternVer_value.Location = new System.Drawing.Point(1203, 149);
            lblSmartScanPatternVer_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSmartScanPatternVer_value.Name = "lblSmartScanPatternVer_value";
            lblSmartScanPatternVer_value.Size = new System.Drawing.Size(0, 23);
            lblSmartScanPatternVer_value.TabIndex = 39;

            //Add to controls
            controls.Add(lblSmartScanPatternVer);
            controls.Add(lblSmartScanPatternVer_value);


            // lblConvenPtnVer
            Label lblConvenPtnVer = new Label();
            // Design 
            lblConvenPtnVer.AutoSize = true;
            lblConvenPtnVer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblConvenPtnVer.Location = new System.Drawing.Point(871, 105);
            lblConvenPtnVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblConvenPtnVer.Name = "lblConvenPtnVer";
            lblConvenPtnVer.Size = new System.Drawing.Size(301, 23);
            lblConvenPtnVer.TabIndex = 24;
            lblConvenPtnVer.Text = "Conventional Pattern Version:";

            // lblConvenPtnVer_value
            Label lblConvenPtnVer_value = new Label();
            // Design 
            lblConvenPtnVer_value.AutoSize = true;
            lblConvenPtnVer_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblConvenPtnVer_value.Location = new System.Drawing.Point(1203, 105);
            lblConvenPtnVer_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblConvenPtnVer_value.Name = "lblConvenPtnVer_value";
            lblConvenPtnVer_value.Size = new System.Drawing.Size(0, 23);
            lblConvenPtnVer_value.TabIndex = 38;

            //Add to controls
            controls.Add(lblConvenPtnVer);
            controls.Add(lblConvenPtnVer_value);


            // lblEngineVersion
            Label lblEngineVersion = new Label();
            // Design 
            lblEngineVersion.AutoSize = true;
            lblEngineVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEngineVersion.Location = new System.Drawing.Point(871, 64);
            lblEngineVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEngineVersion.Name = "lblEngineVersion";
            lblEngineVersion.Size = new System.Drawing.Size(155, 23);
            lblEngineVersion.TabIndex = 23;
            lblEngineVersion.Text = "Engine Version:";

            // lblEngineVersion_value
            Label lblEngineVersion_value = new Label();
            // Design
            lblEngineVersion_value.AutoSize = true;
            lblEngineVersion_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEngineVersion_value.Location = new System.Drawing.Point(1203, 64);
            lblEngineVersion_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEngineVersion_value.Name = "lblEngineVersion_value";
            lblEngineVersion_value.Size = new System.Drawing.Size(0, 23);
            lblEngineVersion_value.TabIndex = 37;

            //Add to controls
            controls.Add(lblEngineVersion);
            controls.Add(lblEngineVersion_value);


            // lblAgentLocation
            Label lblAgentLocation = new Label();
            // Design
            lblAgentLocation.AutoSize = true;
            lblAgentLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAgentLocation.Location = new System.Drawing.Point(871, 23);
            lblAgentLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAgentLocation.Name = "lblAgentLocation";
            lblAgentLocation.Size = new System.Drawing.Size(165, 23);
            lblAgentLocation.TabIndex = 26;
            lblAgentLocation.Text = "Agent Location:";

            // lblAgentLocation_value
            Label lblAgentLocation_value = new Label();
            // Design 
            lblAgentLocation_value.AutoSize = true;
            lblAgentLocation_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAgentLocation_value.Location = new System.Drawing.Point(1203, 23);
            lblAgentLocation_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAgentLocation_value.Name = "lblAgentLocation_value";
            lblAgentLocation_value.Size = new System.Drawing.Size(0, 23);
            lblAgentLocation_value.TabIndex = 36;

            //Add to controls
            controls.Add(lblAgentLocation);
            controls.Add(lblAgentLocation_value);


            // lblUpdateAgentAddr
            Label lblUpdateAgentAddr = new Label();
            // Design
            lblUpdateAgentAddr.AutoSize = true;
            lblUpdateAgentAddr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUpdateAgentAddr.Location = new System.Drawing.Point(27, 377);
            lblUpdateAgentAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUpdateAgentAddr.Name = "lblUpdateAgentAddr";
            lblUpdateAgentAddr.Size = new System.Drawing.Size(240, 23);
            lblUpdateAgentAddr.TabIndex = 19;
            lblUpdateAgentAddr.Text = "Update Agent Address:";

            // lblUpdateAgentAddr_value
            Label lblUpdateAgentAddr_value = new Label();
            // Design
            lblUpdateAgentAddr_value.AutoSize = true;
            lblUpdateAgentAddr_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUpdateAgentAddr_value.Location = new System.Drawing.Point(315, 377);
            lblUpdateAgentAddr_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUpdateAgentAddr_value.Name = "lblUpdateAgentAddr_value";
            lblUpdateAgentAddr_value.Size = new System.Drawing.Size(0, 23);
            lblUpdateAgentAddr_value.TabIndex = 35;

            //Add to controls
            controls.Add(lblUpdateAgentAddr);
            controls.Add(lblUpdateAgentAddr_value);


            // lblUpdateAgentPort
            Label lblUpdateAgentPort = new Label();
            // Design
            lblUpdateAgentPort.AutoSize = true;
            lblUpdateAgentPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUpdateAgentPort.Location = new System.Drawing.Point(27, 332);
            lblUpdateAgentPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUpdateAgentPort.Name = "lblUpdateAgentPort";
            lblUpdateAgentPort.Size = new System.Drawing.Size(200, 23);
            lblUpdateAgentPort.TabIndex = 22;
            lblUpdateAgentPort.Text = "Update Agent Port:";

            // lblUpdateAgentPort_value
            Label lblUpdateAgentPort_value = new Label();
            // 
            lblUpdateAgentPort_value.AutoSize = true;
            lblUpdateAgentPort_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUpdateAgentPort_value.Location = new System.Drawing.Point(315, 332);
            lblUpdateAgentPort_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUpdateAgentPort_value.Name = "lblUpdateAgentPort_value";
            lblUpdateAgentPort_value.Size = new System.Drawing.Size(0, 23);
            lblUpdateAgentPort_value.TabIndex = 34;

            //Add to controls
            controls.Add(lblUpdateAgentPort);
            controls.Add(lblUpdateAgentPort_value);


            // lblUpdateAgent
            Label lblUpdateAgent = new Label();
            // Design
            lblUpdateAgent.AutoSize = true;
            lblUpdateAgent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUpdateAgent.Location = new System.Drawing.Point(27, 284);
            lblUpdateAgent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUpdateAgent.Name = "lblUpdateAgent";
            lblUpdateAgent.Size = new System.Drawing.Size(156, 23);
            lblUpdateAgent.TabIndex = 18;
            lblUpdateAgent.Text = "Update Agent:";

            // lblUpdateAgent_value
            Label lblUpdateAgent_value = new Label();
            // Design 
            lblUpdateAgent_value.AutoSize = true;
            lblUpdateAgent_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUpdateAgent_value.Location = new System.Drawing.Point(315, 284);
            lblUpdateAgent_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUpdateAgent_value.Name = "lblUpdateAgent_value";
            lblUpdateAgent_value.Size = new System.Drawing.Size(0, 23);
            lblUpdateAgent_value.TabIndex = 33;

            //Add to controls
            controls.Add(lblUpdateAgent);
            controls.Add(lblUpdateAgent_value);


            // lblAgentPort
            Label lblAgentPort = new Label();
            // Design
            lblAgentPort.AutoSize = true;
            lblAgentPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAgentPort.Location = new System.Drawing.Point(27, 241);
            lblAgentPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAgentPort.Name = "lblAgentPort";
            lblAgentPort.Size = new System.Drawing.Size(119, 23);
            lblAgentPort.TabIndex = 17;
            lblAgentPort.Text = "Agent Port:";

            // lblAgentPort_value
            Label lblAgentPort_value = new Label();
            // Design
            lblAgentPort_value.AutoSize = true;
            lblAgentPort_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAgentPort_value.Location = new System.Drawing.Point(315, 241);
            lblAgentPort_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAgentPort_value.Name = "lblAgentPort_value";
            lblAgentPort_value.Size = new System.Drawing.Size(0, 23);
            lblAgentPort_value.TabIndex = 32;

            //Add to controls
            controls.Add(lblAgentPort);
            controls.Add(lblAgentPort_value);


            // lblServerHttpsPort
            Label lblServerHttpsPort = new Label();
            // Design
            lblServerHttpsPort.AutoSize = true;
            lblServerHttpsPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblServerHttpsPort.Location = new System.Drawing.Point(27, 194);
            lblServerHttpsPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblServerHttpsPort.Name = "lblServerHttpsPort";
            lblServerHttpsPort.Size = new System.Drawing.Size(178, 23);
            lblServerHttpsPort.TabIndex = 21;
            lblServerHttpsPort.Text = "Server HTTPS Port:";

            // lblServerHttpsPort_value
            Label lblServerHttpsPort_value = new Label();
            // Design
            lblServerHttpsPort_value.AutoSize = true;
            lblServerHttpsPort_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblServerHttpsPort_value.Location = new System.Drawing.Point(315, 194);
            lblServerHttpsPort_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblServerHttpsPort_value.Name = "lblServerHttpsPort_value";
            lblServerHttpsPort_value.Size = new System.Drawing.Size(0, 23);
            lblServerHttpsPort_value.TabIndex = 31;

            //Add to controls
            controls.Add(lblServerHttpsPort);
            controls.Add(lblServerHttpsPort_value);


            // lblServerHttpPort
            Label lblServerHttpPort = new Label();
            // Design
            lblServerHttpPort.AutoSize = true;
            lblServerHttpPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblServerHttpPort.Location = new System.Drawing.Point(27, 149);
            lblServerHttpPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblServerHttpPort.Name = "lblServerHttpPort";
            lblServerHttpPort.Size = new System.Drawing.Size(168, 23);
            lblServerHttpPort.TabIndex = 20;
            lblServerHttpPort.Text = "Server HTTP Port:";

            // lblServerHttpPort_value
            Label lblServerHttpPort_value = new Label();
            // Design
            lblServerHttpPort_value.AutoSize = true;
            lblServerHttpPort_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblServerHttpPort_value.Location = new System.Drawing.Point(315, 149);
            lblServerHttpPort_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblServerHttpPort_value.Name = "lblServerHttpPort_value";
            lblServerHttpPort_value.Size = new System.Drawing.Size(0, 23);
            lblServerHttpPort_value.TabIndex = 30;

            //Add to controls
            controls.Add(lblServerHttpPort);
            controls.Add(lblServerHttpPort_value);


            // lblAgentAddr
            Label lblAgentAddr = new Label();
            // Design
            lblAgentAddr.AutoSize = true;
            lblAgentAddr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAgentAddr.Location = new System.Drawing.Point(27, 108);
            lblAgentAddr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAgentAddr.Name = "lblAgentAddr";
            lblAgentAddr.Size = new System.Drawing.Size(160, 23);
            lblAgentAddr.TabIndex = 14;
            lblAgentAddr.Text = "Server Address:";

            // lblAgentAddr_value
            Label lblAgentAddr_value = new Label();
            // Design
            lblAgentAddr_value.AutoSize = true;
            lblAgentAddr_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAgentAddr_value.Location = new System.Drawing.Point(315, 108);
            lblAgentAddr_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAgentAddr_value.Name = "lblAgentAddr_value";
            lblAgentAddr_value.Size = new System.Drawing.Size(0, 23);
            lblAgentAddr_value.TabIndex = 29;

            //Add to controls
            controls.Add(lblAgentAddr);
            controls.Add(lblAgentAddr_value);


            // lblAgentBuild
            Label lblAgentBuild = new Label();
            // Design
            lblAgentBuild.AutoSize = true;
            lblAgentBuild.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAgentBuild.Location = new System.Drawing.Point(27, 64);
            lblAgentBuild.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAgentBuild.Name = "lblAgentBuild";
            lblAgentBuild.Size = new System.Drawing.Size(126, 23);
            lblAgentBuild.TabIndex = 15;
            lblAgentBuild.Text = "Agent Build:";

            // lblAgentBuild_value
            Label lblAgentBuild_value = new Label();
            // Design
            lblAgentBuild_value.AutoSize = true;
            lblAgentBuild_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAgentBuild_value.Location = new System.Drawing.Point(315, 64);
            lblAgentBuild_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAgentBuild_value.Name = "lblAgentBuild_value";
            lblAgentBuild_value.Size = new System.Drawing.Size(0, 23);
            lblAgentBuild_value.TabIndex = 28;

            //Add to controls
            controls.Add(lblAgentBuild);
            controls.Add(lblAgentBuild_value);


            // lblAgentVersion
            Label lblAgentVersion = new Label();
            // Design
            lblAgentVersion.AutoSize = true;
            lblAgentVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAgentVersion.Location = new System.Drawing.Point(27, 23);
            lblAgentVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAgentVersion.Name = "lblAgentVersion";
            lblAgentVersion.Size = new System.Drawing.Size(146, 23);
            lblAgentVersion.TabIndex = 16;
            lblAgentVersion.Text = "Agent Version";

            // lblAgentVersion_value
            Label lblAgentVersion_value = new Label();
            // Design
            lblAgentVersion_value.AutoSize = true;
            lblAgentVersion_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAgentVersion_value.Location = new System.Drawing.Point(315, 23);
            lblAgentVersion_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAgentVersion_value.Name = "lblAgentVersion_value";
            lblAgentVersion_value.Size = new System.Drawing.Size(0, 23);
            lblAgentVersion_value.TabIndex = 27;

            //Add to controls
            controls.Add(lblAgentVersion);
            controls.Add(lblAgentVersion_value);


            return controls;
        }
        private List<Control> KnownErrorsCreateElements()
        {
            List<Control> controls = new List<Control>();


            //COLUMNS
            // colErrorCode
            DataGridViewTextBoxColumn colErrorCode = new DataGridViewTextBoxColumn();
            // Design
            colErrorCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colErrorCode.HeaderText = "Error Code";
            colErrorCode.MinimumWidth = 6;
            colErrorCode.Name = "colErrorCode";
            colErrorCode.ReadOnly = true;

            // colDescription
            DataGridViewTextBoxColumn colDescription = new DataGridViewTextBoxColumn();
            // Design
            colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colDescription.HeaderText = "Description";
            colDescription.MinimumWidth = 6;
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;

            // colSolution
            DataGridViewTextBoxColumn colSolution = new DataGridViewTextBoxColumn();
            // Design
            colSolution.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colSolution.HeaderText = "Solution";
            colSolution.MinimumWidth = 6;
            colSolution.Name = "colSolution";
            colSolution.ReadOnly = true;

            //DATA GRID
            // grid_KnownError
            grid_KnownError = new DataGridView();
            // Design
            grid_KnownError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            grid_KnownError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_KnownError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colErrorCode,
                colDescription,
                colSolution
            });
            grid_KnownError.Location = new System.Drawing.Point(4, 4);
            grid_KnownError.Margin = new System.Windows.Forms.Padding(4);
            grid_KnownError.Name = "grid_KnownError";
            grid_KnownError.RowHeadersWidth = 51;
            grid_KnownError.Size = new System.Drawing.Size(894, 403);
            grid_KnownError.TabIndex = 0;

            //GRID PANEL
            // pnlErrorGrid
            Panel pnlErrorGrid = new Panel();
            // Design
            pnlErrorGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            pnlErrorGrid.Controls.Add(grid_KnownError);
            pnlErrorGrid.Location = new System.Drawing.Point(3, 12);
            pnlErrorGrid.Name = "pnlErrorGrid";
            pnlErrorGrid.Size = new System.Drawing.Size(902, 423);
            pnlErrorGrid.TabIndex = 3;

            //Add to Controls
            controls.Add(pnlErrorGrid);


            // txtResults
            txtResults = new RichTextBox();
            // Design
            txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            txtResults.Location = new System.Drawing.Point(4, 14);
            txtResults.Margin = new System.Windows.Forms.Padding(4);
            txtResults.Name = "txtResults";
            txtResults.Size = new System.Drawing.Size(877, 265);
            txtResults.TabIndex = 2;
            txtResults.Text = "";

            // pnlSelectedError
            Panel pnlSelectedError = new Panel();
            // Design
            pnlSelectedError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            pnlSelectedError.Controls.Add(txtResults);
            pnlSelectedError.Location = new System.Drawing.Point(7, 441);
            pnlSelectedError.Name = "pnlSelectedError";
            pnlSelectedError.Size = new System.Drawing.Size(898, 293);
            pnlSelectedError.TabIndex = 1;

            //Add to controls
            controls.Add(pnlSelectedError);


            // btn_OffAnalyze
            Button btn_OffAnalyze = new Button();
            // Design
            btn_OffAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btn_OffAnalyze.Location = new System.Drawing.Point(933, 12);
            btn_OffAnalyze.Margin = new System.Windows.Forms.Padding(4);
            btn_OffAnalyze.Name = "btn_OffAnalyze";
            btn_OffAnalyze.Size = new System.Drawing.Size(141, 37);
            btn_OffAnalyze.TabIndex = 1;
            btn_OffAnalyze.Text = "Check";
            btn_OffAnalyze.UseVisualStyleBackColor = true;
            btn_OffAnalyze.Click += new System.EventHandler(Btn_OffAnalyze_Click);

            //Add to controls
            controls.Add(btn_OffAnalyze);

            return controls;
        }
        private List<Control> UpdateIssueCreateElements()
        {
            List<Control> controls = new List<Control>();

            return controls;
        }


        private void addElements(TabPage tp, List<Control> controls)
        {
            foreach (Control c in controls)
            {
                tp.Controls.Add(c);
            }
        }


        //METHODS
        //FOR OFFLINE ANALYZE
        private void Btn_OffAnalyze_Click(object sender, EventArgs e)
        {
            clearGrid(this.grid_KnownError);
            if (extract_path.Equals(""))
                return;
            offAnalyze(getFullPath());
        }

        private void clearGrid(DataGridView d)
        {
            d.Rows.Clear();
            d.Refresh();
        }

        private void offAnalyze(string path)
        {
            txtResults.Text = ""; //Clear

            if (imported_CSV_offline.Equals(""))
                imported_CSV_offline = "codes.csv";

            offlineAnalyzer oa = new offlineAnalyzer($"{path}Event1\\", imported_CSV_offline);
            loadKnownError(oa.errorList, oa.errorsFound);
        }

        private string getFullPath()
        {
            getSysInformation gsi = new getSysInformation(extract_path);
            getAgentInformation gai = new getAgentInformation(extract_path, gsi.getSysArch());

            return $"{ extract_path }\\{ gai.agentfolder}\\CollectedFile\\";
        }

        private void loadKnownError(List<List<String>> errorsList, HashSet<string[]> errorsFound)
        {
            int counter = 0;
            ErrorsList = errorsList;

            foreach (string[] error in errorsFound)
            {
                grid_KnownError.Rows.Add(error[0], error[1], error[2]);
                counter++;
            }

            grid_KnownError.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_KnownError_CellClick);
        }

        private void Grid_KnownError_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string error;

            //Get the row of the current cell selected
            DataGridViewCell cell = grid_KnownError.CurrentRow.Cells[0];
            try
            {
                error = cell.Value.ToString();
                //List the errors under the error code
                showErrors(error);
            }
            catch (Exception ex)
            {
                error = "";
            }
        }

        private void showErrors(string error)
        {
            string errorOutput = "";

            foreach (List<string> errors in ErrorsList)
            {
                if (errors[0].Equals(error))
                    errorOutput = String.Join("\n", errors);
            }

            txtResults.Text = errorOutput;
            //highlightText(txtResults, error);
        }



        //FOR UPDATE ISSUES

            /*
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (extract_path.Equals(""))
                return;
            UpdateAnalyze(getFullPath());
        }
        */
        /*
        private void UpdateAnalyze(string path)
        {
            //Check first if update event exists in CDT
            if (!Directory.Exists($"{ path}\\Event5\\"))
            {
                txtUpdate.Text = "No TmuDump Uploaded";
                return;
            }

            if (imported_CSV_update.Equals(""))
                imported_CSV_update = "update.csv";

            UpdateAnalyzer ua = new UpdateAnalyzer($"{path}\\Event5\\", imported_CSV_update);
            txtUpdate.Text = ua.getSummary();
        }*/


    }
}
