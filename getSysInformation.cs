using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Log_Analyzer
{
    class getSysInformation
    {
        //Network
        String Hostname;
        String IpAdd;
        String Gateway;
        String DNS;

        //System
        String OS;
        String OSver;
        String SysArch;
        String CPU;
        String RAM;
        String DiskSpace;

        //For getting agent values
        String reg;
        public String agentfolder { get; set; }

        public getSysInformation(String path)
        {
            setHostname(path + "\\System_Info\\SystemInfo_NetworkStatus.txt");
            //setIpAdd(path + "\\" + agentfolder + "\\CollectedFile\\Event1\\" + reg);
            //setIpAdd(path + "\\System_Info\\SystemInfo_NetworkStatus.txt");
            //setGateway(path + "\\System_Info\\SystemInfo_NetworkStatus.txt");
            //setDNS(path + "\\System_Info\\SystemInfo_NetworkStatus.txt");

            setOS(path + "\\System_Info\\msinfo.nfo");
            setOSver(path + "\\System_Info\\msinfo.nfo");
            setSysArch(path + "\\System_Info\\msinfo.nfo");
            setCPU(path + "\\System_Info\\msinfo.nfo");
            setRAM(path + "\\System_Info\\msinfo.nfo");
            setDiskSpace(path + "\\System_Info\\msinfo.nfo");

            if (getSysArch().Contains("x64"))
                reg = "REG-2.reg";
            else
                reg = "REG-1.reg";

            agentfolder = checkAgent(path);

            setIpAdd(path + "\\" + agentfolder + "\\CollectedFile\\Event1\\" + reg);
            //setIpAdd(path + "\\System_Info\\SystemInfo_NetworkStatus.txt");
            setGateway(path + "\\System_Info\\SystemInfo_NetworkStatus.txt");
            setDNS(path + "\\System_Info\\SystemInfo_NetworkStatus.txt");
        }

        //Check the folder of agent (osce_14agent or osce_12agent, etc.)
        String checkAgent(String path)
        {
            String value = null;
            String line;

            //Load a file
            StreamReader f = new StreamReader(path + "\\ReadmeFirst.txt");

            //Iterate through the file
            while ((line = f.ReadLine()) != null)
            {
                if (line.Contains("Product diagnosed:"))
                {
                    line = f.ReadLine();
                    line = f.ReadLine();

                    value = line.Trim();
                }
            }

            f.Close();
            return value;
        }

        String Search (String file, String text)
        {
            String value = "";
            String line;
            int counter = 0;

            //Load a file
            StreamReader f = new StreamReader(file);

            //Determine the file type
            if (file.Contains(".txt")) {

                //Read each line
                while ((line = f.ReadLine()) != null)
                {
                    //If the line contains text, get the line > break
                    if (line.Contains(text))
                    {
                        //Get the value after : on the line
                        line = line.Trim(); //Removes most whitespaces

                        int colon = line.LastIndexOf(":") + 2;

                        //If blank
                        if (colon >= line.Length)
                        {
                            value = "N/A";
                            break;
                        }

                        value = line.Substring(colon);

                        break;
                    }

                    counter++;
                }
            }
            else if (file.Contains(".nfo")) {

                //Read each line
                while ((line = f.ReadLine()) != null)
                {
                    //If the line contains text, get the line > break
                    if (line.Contains(text))
                    {
                        //Get the next line
                        line = f.ReadLine();

                        //Get the value between <Value><![CDATA[ and ]]></Value>]]></Value> on the line
                        line = line.Trim(); //Removes most whitespaces

                        value = Regex.Replace(line, Regex.Escape("<Value><![CDATA["), "");
                        value = Regex.Replace(value, Regex.Escape("]]></Value>"), "");
                        break;
                    }

                    counter++;
                }
            }
            else if (file.Contains(".reg")) {

                //Read each line
                while ((line = f.ReadLine()) != null)
                {
                    //If the line contains text, get the line > break
                    if (line.Contains(text))
                    {
                        //Get the value after : on the line
                        line = line.Trim(); //Removes most whitespaces

                        int equal = line.LastIndexOf("=") + 2;

                        if (line.Contains("dword"))
                            value = line.Substring(equal, line.Length - equal);
                        else
                            value = line.Substring(equal, line.Length - equal - 1);
                        break;
                    }
                }
            }

            //Close files for memory optimization
            f.Close();
            
            //Return value
            return value;
        }

        //Search after a string
        String SearchWithStart(String file, String text, String first)
        {
            String value = "";
            bool found = false;

            String line;
            int counter = 0;

            //Load the file
            StreamReader f = new StreamReader(file);

            while ((line = f.ReadLine()) != null)
            {
                //Find the starting point first
                if (line.Contains(first))
                    found = true;

                //If starting point was found, proceed with normal search
                if (found)
                {
                    if (line.Contains(text))
                    {
                        //Get the value after : on the line
                        line = line.Trim(); //Removes most whitespaces

                        int colon = line.LastIndexOf(":") + 2;

                        //If blank
                        if (colon >= line.Length)
                        {
                            value = "N/A";
                            break;
                        }

                        value = line.Substring(colon);

                        break;
                    }
                }

            }

            f.Close();
            return value;
        }

        //For HostName
        void setHostname(String filedir)
        {
            Hostname = Search (filedir, "Host Name");
        }

        public string getHostname()
        {
            return Hostname;
        }


        //For Ip Address
        void setIpAdd(String filedir)
        {
            /*
            IpAdd = Search(filedir, "IPv4 Address");
            if (IpAdd.Equals(""))
                IpAdd = Search(filedir, "IP Address");
            */
            IpAdd = Search(filedir, "\"IP\"");
        }

        public string getIpAdd()
        {
            return IpAdd;
        }


        //For Default Gateway
        void setGateway(String filedir)
        {

            Gateway = SearchWithStart(filedir, "Default Gateway", IpAdd);
            //Gateway = Search(filedir, "Default Gateway");
        }

        public string getGateway()
        {
            return Gateway;
        }


        //For DNS Server
        void setDNS(String filedir)
        {
            //DNS = Search(filedir, "DNS Servers");
            DNS = SearchWithStart(filedir, "DNS Servers", IpAdd);
        }

        public string getDNS()
        {
            return DNS;
        }


        //For Operating System
        void setOS(String filedir)
        {
            OS = Search(filedir, "[OS Name]");
        }

        public string getOS()
        {
            return OS;
        }


        //For Operating System Version
        void setOSver(String filedir)
        {
            OSver = Search(filedir, "[Version]");
        }

        public string getOSver()
        {
            return OSver;
        }


        //For System Architecture
        void setSysArch(String filedir)
        {
            SysArch = Search(filedir, "[System Type]");
        }

        public string getSysArch()
        {
            return SysArch;
        }


        //For CPU
        void setCPU(String filedir)
        {
            CPU = Search(filedir, "[Processor]");
        }

        public string getCPU()
        {
            return CPU;
        }


        //For RAM
        void setRAM(String filedir)
        {
            RAM = Search(filedir, "[Installed Physical Memory (RAM)]");
            if(RAM.Equals(""))
                RAM = Search(filedir, "[Total Physical Memory]");
        }

        public string getRAM()
        {
            return RAM;
        }


        //For Free Disk Space, will need to print for additional disk drives
        void setDiskSpace(String filedir)
        {
            DiskSpace = Search(filedir, "[Free Space]");
        }

        public string getDiskSpace()
        {
            return DiskSpace;
        }
    }
}
