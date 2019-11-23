using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Log_Analyzer
{
    class getInformation
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

        String dir;

        String NetworkStatus;

        public getInformation(String path)
        {
            dir = path;
            setHostname(dir + "\\System_Info\\SystemInfo_NetworkStatus.txt");
            setIpAdd(dir + "\\System_Info\\SystemInfo_NetworkStatus.txt");
            setGateway(dir + "\\System_Info\\SystemInfo_NetworkStatus.txt");
            setDNS(dir + "\\System_Info\\SystemInfo_NetworkStatus.txt");

            setOS(dir + "\\System_Info\\msinfo.nfo");
            setOSver(dir + "\\System_Info\\msinfo.nfo");
            setSysArch(dir + "\\System_Info\\msinfo.nfo");
            setCPU(dir + "\\System_Info\\msinfo.nfo");
            setRAM(dir + "\\System_Info\\msinfo.nfo");
            setDiskSpace(dir + "\\System_Info\\msinfo.nfo");
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

            //Close files for memory optimization
            f.Close();
            
            //Return value
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
            IpAdd = Search(filedir, "IPv4 Address");
        }

        public string getIpAdd()
        {
            return IpAdd;
        }


        //For Default Gateway
        void setGateway(String filedir)
        {
            Gateway = Search(filedir, "Default Gateway");
        }

        public string getGateway()
        {
            return Gateway;
        }


        //For DNS Server
        void setDNS(String filedir)
        {
            DNS = Search(filedir, "DNS Servers");
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


        //For Operating System
        void setRAM(String filedir)
        {
            RAM = Search(filedir, "[Installed Physical Memory (RAM)]");
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
