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

        String Hostname;
        String IpAdd;
        String Gateway;
        String DNS;

        String dir;

        String NetworkStatus;

        public getInformation(String path)
        {
            dir = path;
            setHostname();
            setIpAdd();
            setGateway();
            setDNS();
        }

        String Search (String txtfile, String text)
        {
            String value = "";
            String line;
            int counter = 0;

            //Load a file
            StreamReader file = new StreamReader(txtfile);

            //Read each line
            while ((line = file.ReadLine()) != null)
            {
                //If the line contains text, get the line > break
                if (line.Contains(text))
                {
                    //Get the value after : on the line
                    line = line.Trim(); //Removes most whitespaces

                    int colon = line.LastIndexOf(":") + 2;

                    value = line.Substring(colon, line.Length - colon);
                    break;
                }

                counter++;
            }

            //Close files for memory optimization
            file.Close();
            
            //Return value
            return value;
        }

        //For HostName
        void setHostname()
        {
            Hostname = Search(dir + "\\System_Info\\SystemInfo_NetworkStatus.txt", "Host Name");
        }

        public string getHostname()
        {
            return Hostname;
        }


        //For Ip Address
        void setIpAdd()
        {
            IpAdd = Search(dir + "\\System_Info\\SystemInfo_NetworkStatus.txt", "IPv4 Address");
        }

        public string getIpAdd()
        {
            return IpAdd;
        }


        //For Default Gateway
        void setGateway()
        {
            Gateway = Search(dir + "\\System_Info\\SystemInfo_NetworkStatus.txt", "Default Gateway");
        }

        public string getGateway()
        {
            return Gateway;
        }


        //For DNS Server
        void setDNS()
        {
            DNS = Search(dir + "\\System_Info\\SystemInfo_NetworkStatus.txt", "DNS Servers");
        }

        public string getDNS()
        {
            return DNS;
        }
    }
}
