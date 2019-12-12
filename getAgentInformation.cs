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

        public String agentfolder { get; set; }

        public getAgentInformation(String path, String sysArch)
        {
            if (sysArch.Contains("x64"))
                reg = "REG-2.reg";
            else
                reg = "REG-1.reg";

            agentfolder = checkAgent(path);

            setAgentVer(path + "\\" + agentfolder + "\\ProductInfo.txt");
            setAgentBuild(path + "\\" + agentfolder + "\\CollectedFile\\Event1\\" + reg);         
            setServer(path + "\\" + agentfolder + "\\CollectedFile\\Event1\\" + reg);
            setServerHTTP(path + "\\" + agentfolder + "\\CollectedFile\\Event1\\" + reg);
            setServerHTTPS(path + "\\" + agentfolder + "\\CollectedFile\\Event1\\" + reg);
            setAgentPort(path + "\\" + agentfolder + "\\CollectedFile\\Event1\\" + reg);
            setUpdateAgent(path + "\\" + agentfolder + "\\CollectedFile\\Event1\\" + reg);
            setUpdateAgentAddress(path + "\\" + agentfolder + "\\CollectedFile\\Event1\\" + reg);
            setUpdateAgentPort(path + "\\" + agentfolder + "\\CollectedFile\\Event1\\" + reg);
            setAgentLocation(path + "\\" + agentfolder + "\\CollectedFile\\Event1\\" + reg);
            setEngineVersion(path + "\\" + agentfolder + "\\ProductInfo.txt");
            setConPtnVersion(path + "\\" + agentfolder + "\\ProductInfo.txt");
            setSmartPtnVersion(path + "\\" + agentfolder + "\\ProductInfo.txt");
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

        //Original Search
        String Search (String file, String text)
        {
            String value = null;
            String line;

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

                        int separator = line.LastIndexOf("=") + 1;

                        value = line.Substring(separator);
                        break;
                    }
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

            f.Close();
            return value;
        }


        
        //Search for Agent Build
        String SearchBuild (String file, String version)
        {
            String value = null;
            String line;

            //Load a file
            StreamReader f = new StreamReader(file);
            {
                //Read each line
                while ((line = f.ReadLine()) != null)
                {
                    //If the line contains text, get the line > break
                    if (line.Contains("HotfixHistory\\" + version + "]"))
                    {
                        //Get value below (HotfixHistory)
                        line = f.ReadLine();

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
            return value;
        }

        //Agent Version
        void setAgentVer(String filedir)
        {
            AgentVer = Search(filedir, "ProductVersion");
        }

        public String getAgentVer()
        {
            switch (AgentVer)
            {
                case "12.0": return "OSCE XG SP1";
                case "13.95": return "Apex One";
                case "14.0": return "Apex One";
                default: return "OSCE XG";
            }
        }


        //Agent Build
        void setAgentBuild(String filedir)
        {
            /*String builds = Search (filedir, "BuildNum");
            int charlength = builds.Length - builds.LastIndexOf(";") - 1;
            AgentBuild = builds.Substring(builds.LastIndexOf(";") + 1);*/
            AgentBuild = Search(filedir, "\"BuildNum\"");
            AgentBuild = AgentBuild.Substring(AgentBuild.IndexOf(":") + 1);
            AgentBuild = (Convert.ToInt32(AgentBuild, 16)).ToString();
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
        void setUpdateAgent(String filedir)
        {
            UpdateAgent = Search(filedir, "\"UpdateAgent\"");
            UpdateAgent = UpdateAgent.Substring(UpdateAgent.IndexOf(":") + 1);
            UpdateAgent = (Convert.ToInt32(UpdateAgent, 16)).ToString();
        }

        public String getUpdateAgent()
        {
            if (UpdateAgent.Equals("0"))
                return "No";
            else
                return "Yes";
        }


        //Update Agent Port
        void setUpdateAgentPort(String filedir)
        {
            UpdateAgentPort = UpdateAgentAddress.Substring(UpdateAgentAddress.LastIndexOf(":") + 1, UpdateAgentAddress.LastIndexOf("/") - UpdateAgentAddress.LastIndexOf(":") - 1);
        }

        public String getUpdateAgentPort()
        {
            if (UpdateAgent.Equals("0"))
                return "N/A";
            else
                return UpdateAgentPort;
        }


        //Update Agent Address
        void setUpdateAgentAddress(String filedir)
        {
            UpdateAgentAddress = Search(filedir, "\"UpdateFrom\"");
        }

        public String getUpdateAgentAddress()
        {
            if (UpdateAgent.Equals("0"))
                return "N/A";
            else
                return UpdateAgentAddress;
        }
        

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
            EngineVersion = Search(filedir, "EngineVersion");
        }

        public String getEngineVersion()
        {
            return EngineVersion;
        }


        //Conventional Pattern Version
        void setConPtnVersion(String filedir)
        {
            ConPtnVersion = Search(filedir, "PatternVersion");
        }

        public String getConPtnVersion()
        {
            return ConPtnVersion;
        }


        //Smart Scan Pattern Version    
        void setSmartPtnVersion(String filedir)
        {
            SmartPtnVersion = Search(filedir, "IcrcPatternVersion");
        }

        public String getSmartPtnVersion()
        {
            return SmartPtnVersion;
        }
    }
}
