using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Analyzer
{
    class CDT_Tab_Template
    {
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
            TabPage tp = new TabPage("Agent Information");
            tp.Name = "AgentInfo";

            //Create the elements inside the page
            List<Control> controls = AgentInfoCreateElements();

            //Add the elements to the page
            addElements(tp, controls);

            return tp;
        }
        private TabPage createKnownErrorsPage()
        {
            TabPage tp = new TabPage("Known Errors");
            tp.Name = "KnownErrors";

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

            // 
            // lblSystemArchitecture_value
            // 
            
            /**
            this.lblSystemArchitecture_value.AutoSize = true;
            this.lblSystemArchitecture_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemArchitecture_value.Location = new System.Drawing.Point(259, 314);
            this.lblSystemArchitecture_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemArchitecture_value.Name = "lblSystemArchitecture_value";
            this.lblSystemArchitecture_value.Size = new System.Drawing.Size(0, 23);
            this.lblSystemArchitecture_value.TabIndex = 26;
            // 
            // lblOSver_value
            // 
            this.lblOSver_value.AutoSize = true;
            this.lblOSver_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSver_value.Location = new System.Drawing.Point(259, 276);
            this.lblOSver_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOSver_value.Name = "lblOSver_value";
            this.lblOSver_value.Size = new System.Drawing.Size(0, 23);
            this.lblOSver_value.TabIndex = 25;
            // 
            // lblOperatingSystem_value
            // 
            this.lblOperatingSystem_value.AutoSize = true;
            this.lblOperatingSystem_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatingSystem_value.Location = new System.Drawing.Point(259, 233);
            this.lblOperatingSystem_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperatingSystem_value.Name = "lblOperatingSystem_value";
            this.lblOperatingSystem_value.Size = new System.Drawing.Size(0, 23);
            this.lblOperatingSystem_value.TabIndex = 24;
            // 
            // lblDns_value
            // 
            this.lblDns_value.AutoSize = true;
            this.lblDns_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDns_value.Location = new System.Drawing.Point(153, 143);
            this.lblDns_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDns_value.Name = "lblDns_value";
            this.lblDns_value.Size = new System.Drawing.Size(0, 23);
            this.lblDns_value.TabIndex = 23;
            // 
            // lblGateway_value
            // 
            this.lblGateway_value.AutoSize = true;
            this.lblGateway_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateway_value.Location = new System.Drawing.Point(153, 106);
            this.lblGateway_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGateway_value.Name = "lblGateway_value";
            this.lblGateway_value.Size = new System.Drawing.Size(0, 23);
            this.lblGateway_value.TabIndex = 22;
            // 
            // lblIPAddress_value
            // 
            this.lblIPAddress_value.AutoSize = true;
            this.lblIPAddress_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress_value.Location = new System.Drawing.Point(153, 69);
            this.lblIPAddress_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPAddress_value.Name = "lblIPAddress_value";
            this.lblIPAddress_value.Size = new System.Drawing.Size(0, 23);
            this.lblIPAddress_value.TabIndex = 21;
            // 
            // lblHostname_value
            // 
            this.lblHostname_value.AutoSize = true;
            this.lblHostname_value.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname_value.Location = new System.Drawing.Point(153, 25);
            this.lblHostname_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostname_value.Name = "lblHostname_value";
            this.lblHostname_value.Size = new System.Drawing.Size(0, 23);
            this.lblHostname_value.TabIndex = 20;




            // 
            // lblOSver
            // 
            this.lblOSver.AutoSize = true;
            this.lblOSver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSver.Location = new System.Drawing.Point(24, 276);
            this.lblOSver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOSver.Name = "lblOSver";
            this.lblOSver.Size = new System.Drawing.Size(118, 23);
            this.lblOSver.TabIndex = 6;
            this.lblOSver.Text = "OS Version:";
            // 
            // lblSystemArchitecture
            // 
            this.lblSystemArchitecture.AutoSize = true;
            this.lblSystemArchitecture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemArchitecture.Location = new System.Drawing.Point(24, 314);
            this.lblSystemArchitecture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemArchitecture.Name = "lblSystemArchitecture";
            this.lblSystemArchitecture.Size = new System.Drawing.Size(209, 23);
            this.lblSystemArchitecture.TabIndex = 5;
            this.lblSystemArchitecture.Text = "System Architecture:";
            // 
            // lblOperatingSystem
            // 
            this.lblOperatingSystem.AutoSize = true;
            this.lblOperatingSystem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatingSystem.Location = new System.Drawing.Point(20, 233);
            this.lblOperatingSystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperatingSystem.Name = "lblOperatingSystem";
            this.lblOperatingSystem.Size = new System.Drawing.Size(188, 23);
            this.lblOperatingSystem.TabIndex = 4;
            this.lblOperatingSystem.Text = "Operating System:";
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateway.Location = new System.Drawing.Point(20, 106);
            this.lblGateway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(109, 23);
            this.lblGateway.TabIndex = 3;
            this.lblGateway.Text = "Gateway:";
            // 
            // lblDns
            // 
            this.lblDns.AutoSize = true;
            this.lblDns.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDns.Location = new System.Drawing.Point(20, 143);
            this.lblDns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDns.Name = "lblDns";
            this.lblDns.Size = new System.Drawing.Size(55, 23);
            this.lblDns.TabIndex = 2;
            this.lblDns.Text = "DNS:";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Location = new System.Drawing.Point(20, 69);
            this.lblIPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(116, 23);
            this.lblIPAddress.TabIndex = 1;
            this.lblIPAddress.Text = "IP Address:";
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname.Location = new System.Drawing.Point(20, 25);
            this.lblHostname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(115, 23);
            this.lblHostname.TabIndex = 0;
            this.lblHostname.Text = "Hostname:";
            
        */


            return controls;
        }
        private List<Control> AgentInfoCreateElements()
        {
            List<Control> controls = new List<Control>();


            return controls;
        }
        private List<Control> KnownErrorsCreateElements()
        {
            List<Control> controls = new List<Control>();


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

    }
}
