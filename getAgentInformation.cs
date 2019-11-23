using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Log_Analyzer
{
    class getAgentInformation
    {

        String reg;

        //From Registry
        String AgentVer;
        String AgentBuild;
        String Server;
        String ServerHTTP;
        String ServerHTTPS;
        String AgentPort;
        String UpdateAgent;
        String UpdateAgentPort;
        String UpdateAgentAddress;
        String AgentLocation;
        String EngineVersion;
        String ConPtnVersion;
        String SmartPtnVersion;

        public getAgentInformation(String path, String sysArch)
        {
            if (sysArch.Contains("x64"))
                reg = "REG-2.reg";
            else
                reg = "REG-1.reg";

            setAgentBuild(path + "\\OSCE_14agent\\CollectedFile\\Event1\\" + reg);
            setAgentVer(path + "\\OSCE_14agent\\CollectedFile\\Event1\\" + reg);
            setServer(path + "\\OSCE_14agent\\CollectedFile\\Event1\\" + reg);
            setServerHTTP(path + "\\OSCE_14agent\\CollectedFile\\Event1\\" + reg);
            setServerHTTPS(path + "\\OSCE_14agent\\CollectedFile\\Event1\\" + reg);
            setAgentPort(path + "\\OSCE_14agent\\CollectedFile\\Event1\\" + reg);
            setAgentLocation(path + "\\OSCE_14agent\\CollectedFile\\Event1\\" + reg);
            setEngineVersion(path + "\\OSCE_14agent\\CollectedFile\\Event1\\" + reg);
            setConPtnVersion(path + "\\OSCE_14agent\\CollectedFile\\Event1\\" + reg);
            setSmartPtnVersion(path + "\\OSCE_14agent\\CollectedFile\\Event1\\" + reg);
        }

        String Search (String file, String text)
        {
            String value = "";
            String line;
            int counter = 0;

            //Load a file
            StreamReader f = new StreamReader(file);

            //Determine the file type
            if (file.Contains(".txt")){

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

                    counter++;
                }
            }

            return value;
        }

        //Agent Version
        void setAgentVer(String filedir)
        {
            if (AgentBuild[0] == '1')
                AgentVer = "OSCE XG";
            else
                AgentVer = "OSCE XG SP1";
        }

        public String getAgentVer()
        {
            return AgentVer;
        }


        //Agent Build
        void setAgentBuild(String filedir)
        {
            String builds = Search(filedir, "\"HotfixInstalled\"");
            int charlength = builds.Length - builds.LastIndexOf(";") - 1;
            AgentBuild = builds.Substring(builds.LastIndexOf(";") + 1);
        }

        public String getAgentBuild()
        {
            return AgentBuild;
        }


        //Server Address
        void setServer(String filedir)
        {
            Server = Search(filedir, "\"Server\"");
        }

        public String getServer()
        {
            return Server;
        }


        //Server HTTP Port
        void setServerHTTP(String filedir)
        {
            ServerHTTP = Search(filedir, "\"ServerPort\"");
            ServerHTTP = ServerHTTP.Substring(ServerHTTP.IndexOf(":") + 1);
            ServerHTTP = (Convert.ToInt32(ServerHTTP, 16)).ToString();
        }

        public String getServerHTTP()
        {
            return ServerHTTP;
        }


        //Server HTTPS Port
        void setServerHTTPS(String filedir)
        {
            ServerHTTPS = Search(filedir, "\"ServerSSLPort\"");
            ServerHTTPS = ServerHTTPS.Substring(ServerHTTPS.IndexOf(":") + 1);
            ServerHTTPS = (Convert.ToInt32(ServerHTTPS, 16)).ToString();
        }

        public String getServerHTTPS()
        {
            return ServerHTTPS;
        }


        //Agent Port
        void setAgentPort(String filedir)
        {
            AgentPort = Search(filedir, "\"LocalServerPort\"");
            AgentPort = AgentPort.Substring(AgentPort.IndexOf(":") + 1);
            AgentPort = (Convert.ToInt32(AgentPort, 16)).ToString();
        }

        public String getAgentPort()
        {
            return AgentPort;
        }


        //Update Agent 



        //Update Agent Port



        //Update Agent Address



        //Agent Location
        void setAgentLocation(String filedir)
        {
            AgentLocation = Search(filedir, "\"CurrentLocation\"");
            AgentLocation = AgentLocation.Substring(AgentLocation.IndexOf(":") + 1);
            AgentLocation = (Convert.ToInt32(AgentLocation, 16)).ToString();
        }

        public String getAgentLocation()
        {
            if (AgentLocation.Equals("1"))
                return "Internal";
            return "External";
        }


        //Engine Version
        void setEngineVersion(String filedir)
        {
            EngineVersion = Search(filedir, "\"EngineMin\"");
        }

        public String getEngineVersion()
        {
            return EngineVersion;
        }


        //Conventional Pattern Version
        void setConPtnVersion(String filedir)
        {
            ConPtnVersion = Search(filedir, "\"EngineMin\"");
        }

        public String getConPtnVersion()
        {
            return ConPtnVersion;
        }


        //Smart Scan Pattern Version    
        void setSmartPtnVersion(String filedir)
        {
            SmartPtnVersion = Search(filedir, "\"EngineMin\"");
        }

        public String getSmartPtnVersion()
        {
            return SmartPtnVersion;
        }
    }
}
