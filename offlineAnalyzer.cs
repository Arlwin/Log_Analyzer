using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Log_Analyzer
{
    class offlineAnalyzer
    {
        public List<String[]> errorsFound { get; set; }

        public offlineAnalyzer(String filepath, String codepath)
        {
            analyze(filepath, codepath);
        }

        //Main function
        private void analyze(string filepath, string codepath)
        {
            //Load the file first
            StreamReader f = new StreamReader(filepath);

            List<string[]> errorCodes = loadCodes(codepath);

            foreach (var errorCode in errorCodes)
            {
                checkError(f, errorCode);
                f.BaseStream.Seek(0, SeekOrigin.Begin);
            }
        }

        //Load the codes
        private List<string[]> loadCodes(string codepath)
        {
            StreamReader code = new StreamReader(codepath);
            List<string[]> codeList = new List<string[]>();

            string line;
            int counter = 0;

            while ((line = code.ReadLine()) != null)
            {
                codeList[counter] = line.Split(',');
                counter++;
            }

            return codeList;
        }

        //Search the file for errors inside the codes
        private bool checkError(StreamReader r, string[] errorLine)
        {
            string line;

            while ((line = r.ReadLine()) != null)
            {
                if (line.Contains(errorLine[0]))
                {
                    return true;
                }               
            }

            return false;
        }

    }
}
