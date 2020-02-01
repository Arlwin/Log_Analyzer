using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Analyzer
{
    class NewTab
    {
        /*
         * Instantiate the name of the tab
         *  If name exists, return true
         *  If not, return false and proceed to creation
         *  
         * Add all the same items from the original tab
         * 
         */

        //The current form
        Form1 mainform;

        //The tab name
        public string tab_name { get; set; }
        public string full_path { get; set; }
        public string extract_path { get; set; }

        CDT_Tab_Template new_tab;
        public NewTab(string name, TabControl current_tc, string file_name, Form1 mainForm)
        {
            //Get the current form
            mainform = mainForm;

            //Init new TabPage to the TabControl
            tab_name = name;

            //Try to extract the given filepath
            UnzipCDTAsync(file_name);

            //Try to get information
            getSysInformation gsi = new getSysInformation($"{extract_path}");
            getAgentInformation gai = new getAgentInformation($"{extract_path}", gsi.getSysArch());

            //Add all the previous elements to the new tab page
            current_tc.TabPages.Add(tab_name, tab_name);
            loadContent(current_tc.TabPages[tab_name]);

            //Add some default file paths to the CDT 
            new_tab.extract_path = extract_path;
            new_tab.full_path = full_path;

            //Populate the tabs
            loadSysInformation(gsi, current_tc.TabPages[tab_name]);
            loadAgentInformation(gai, current_tc.TabPages[tab_name]);

            //Set focus to the new tab page
            current_tc.SelectedTab = current_tc.TabPages[tab_name];
        }

        public static bool doesExist(string tp_name, TabControl tc)
        {
            if (tc.TabPages.ContainsKey(tp_name))
                return true;
            return false;
        }

        private void loadContent(TabPage tp)
        {
            new_tab = new CDT_Tab_Template(tp);
        }


        //EXTRACTION METHODS
        private void UnzipCDTAsync(String file)
        {
            full_path = file;

            extract_path = extractZip(full_path);

            //If sobrang isang folder sa loob
            if (Directory.GetDirectories(extract_path).Length < 2)
            {
                string[] directories = Directory.GetDirectories(extract_path);
                extract_path = directories[0];
            }
        }

        private string extractZip(string path)
        {
            string dest = "";

            try
            {
                int index = path.LastIndexOf(".");
                string filename = path.Substring(path.LastIndexOf("\\") + 1, index - path.LastIndexOf("\\") - 1);

                if (index > 0)
                {
                    //dest = path.Substring(0, index);
                    dest = "TEMP\\" + filename;
                }

                var dir = new DirectoryInfo(dest);
                if (dir.Exists)
                    dir.Delete(true);

                using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(path))
                {
                    zip.Password = "trend";

                    zip.ExtractProgress += new EventHandler<ExtractProgressEventArgs>(zip_ExtractProgress);

                    zip.ExtractAll(dest, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);

                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Ionic.Zip.ZipException"))
                    Console.WriteLine("Please upload proper ZIP");
            }

            return dest;
        }

        private void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.BytesTransferred > 0)
            {
                //prog_perFile.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);
                mainform.setSubProgressBar(Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer));
            }

            if ((e.EntriesTotal - e.EntriesExtracted) >= 0 && (e.EntriesTotal > 0))
            {
                mainform.setMainProgressBar(Convert.ToInt32(100 * e.EntriesExtracted / e.EntriesTotal));

            }
        }



        //LOADING INFO METHODS
        private void loadAgentInformation(getAgentInformation gai, TabPage tp)
        {
            TabControl tc = (TabControl)tp.Controls["TabSystem"];
            TabPage page = (TabPage)tc.TabPages["tab_AgentInfo"];

            page.Controls["lblAgentVersion_value"].Text = gai.getAgentVer();
            page.Controls["lblAgentBuild_value"].Text = gai.getAgentBuild();
            page.Controls["lblAgentAddr_value"].Text = gai.getServer();
            page.Controls["lblServerHttpPort_value"].Text = gai.getServerHTTP();
            page.Controls["lblServerHttpsPort_value"].Text = gai.getServerHTTPS();
            page.Controls["lblAgentPort_value"].Text = gai.getAgentPort();
            page.Controls["lblUpdateAgentAddr_value"].Text = gai.getUpdateAgentAddress();
            page.Controls["lblUpdateAgentPort_value"].Text = gai.getUpdateAgentPort();
            page.Controls["lblUpdateAgent_value"].Text = gai.getUpdateAgent();
            page.Controls["lblAgentLocation_value"].Text = gai.getAgentLocation();
            page.Controls["lblEngineVersion_value"].Text = gai.getEngineVersion();
            page.Controls["lblConvenPtnVer_value"].Text = gai.getConPtnVersion();
            page.Controls["lblSmartScanPatternVer_value"].Text = gai.getSmartPtnVersion();
        }

        private void loadSysInformation(getSysInformation gsi, TabPage tp)
        {
            TabControl tc = (TabControl)tp.Controls["TabSystem"];
            TabPage page = (TabPage)tc.TabPages["tab_SystemInfo"];

            page.Controls["lblHostname_value"].Text = gsi.getHostname(); //Host name
            page.Controls["lblIPAddress_value"].Text = gsi.getIpAdd(); //Ip Address
            page.Controls["lblGateway_value"].Text = gsi.getGateway(); //Gateway
            page.Controls["lblDns_value"].Text = gsi.getDNS(); //DNS
            page.Controls["lblOperatingSystem_value"].Text = gsi.getOS(); //OS
            page.Controls["lblOSver_value"].Text = gsi.getOSver(); //OS Version
            page.Controls["lblSystemArchitecture_value"].Text = gsi.getSysArch(); //System Architecture
            page.Controls["lblCPU_value"].Text = gsi.getCPU(); //CPU
            page.Controls["lblRam_value"].Text = gsi.getRAM(); //RAM
            page.Controls["lblFreeDiskSpace_value"].Text = gsi.getDiskSpace(); //Free Disk Space

            //NOTE: Currently, disk space can only print free disk space of FIRST disk drive
        }
    }
}
