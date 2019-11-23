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

        String Hostname = "test";
        String dir;

        String NetworkStatus;

        public getInformation(String path)
        {
            dir = path;
            setHostname();
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
                    line = Regex.Replace(line, @"s", ""); //Removes all whitespaces

                    int colon = line.LastIndexOf(":");
                    int lengthogline = line.Length;

                    value = line.Substring(line.LastIndexOf(":"), line.Length - 1);
                    break;
                }

                counter++;
            }

            //Close files for memory optimization
            file.Close();
            
            //Return value

            return value;
        }

        void setHostname()
        {
            Hostname = Search(dir + "\\System_Info\\SystemInfo_NetworkStatus.txt", "Host Name");
        }

        public string getHostname()
        {
            return Hostname;
        }
    }
}
