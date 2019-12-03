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
        public List<String[]> errorsFound = new List<String[]>(); //List of Error Code arrays [Error code, description, solution]

        public List<List<String>> errorList = new List<List<String>>(); //Error lines found for each error

        public offlineAnalyzer(String filepath, String codepath)
        {
            init(filepath, codepath);
        }

        //Init
        private void init(String filepath, String codepath)
        {
            //Check first the Event 1 folder
            DirectoryInfo dir = new DirectoryInfo(filepath);

            //Get all the debuglogs
            FileInfo[] files = dir.GetFiles("ofcdebug*.*");

            int counter = 0;
            foreach (var file in files)
            {
                analyzeAsync($"{filepath}{file}", codepath, counter);
                counter++;
            }
        }


        //Main function
        private void analyze(string filepath, string codepath)
        {
            //Load the file first
            StreamReader f = new StreamReader(filepath);

            //Load the errors
            List<string[]> errorCodes = loadCodes(codepath);

            int counter = 0;

            //Check each error code if it exists on ofcdebug
            foreach (string[] errorCode in errorCodes)
            {
                errorList.Add(new List<String>() { errorCode[0] }); //Add the error code at the start of the list

                if(checkError(f, errorCode, counter))
                {
                    errorsFound.Add(errorCode);
                }

                f.BaseStream.Seek(0, SeekOrigin.Begin);
                counter++;
            }

            //close the file
            f.Close();
        }

        //Main function
        private void analyzeAsync(string filepath, string codepath, int numFiles)
        {
            //Load the file first
            StreamReader f = new StreamReader(filepath);

            //Load the errors
            List<string[]> errorCodes = loadCodes(codepath);

            int counter = 0;

            //Check each error code if it exists on ofcdebug
            foreach (string[] errorCode in errorCodes)
            {
                if (numFiles == 0)
                    errorList.Add(new List<String>() { errorCode[0] }); //Add the error code at the start of the list

                if (checkError(f, errorCode, counter))
                {
                    if (!(errorsFound.Count < 1))
                    {
                        if(!checkErrorsFound(errorCode))
                            errorsFound.Add(errorCode);
                    }
                    else
                    {
                        errorsFound.Add(errorCode);
                    }
                }

                f.BaseStream.Seek(0, SeekOrigin.Begin);
                counter++;
            }

            //close the file
            f.Close();
        }

        //checkErrorsFound
        private bool checkErrorsFound(string[] errorcodes)
        {
            foreach(string[] errors in errorsFound)
            {
                if (errors[0].Equals(errorcodes[0])) //If match
                    return true;
            }
            return false;
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
                codeList.Add(line.Split(','));
                counter++;
            }

            code.Close();

            return codeList;
        }

        //Search the file for errors inside the codes
        private bool checkError(StreamReader r, string[] errorLine, int index)
        {
            string line;
            bool check = false;

            while ((line = r.ReadLine()) != null)
            {
                if (line.Contains(errorLine[0]))
                {
                    check = true;
                    errorList[index].Add(line);
                }               
            }

            return check;
        }

    }
}
