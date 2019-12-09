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
        //public List<String[]> errorsFound = new List<String[]>(); //List of Error Code arrays [Error code, description, solution]
        public HashSet<String[]> errorsFound = new HashSet<String[]>(); //Set of Error Code arrays [Error code, description, solution]

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

            //Check if debug logs are zipped

            //Get all the debuglogs
            FileInfo[] files = dir.GetFiles("ofcdebug.log*");

            int counter = 0;
            foreach (var file in files)
            {   
                /*
                if (file.Extension.Contains("7z"))
                {
                    using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(file))
                    {
                        zip.Password = "trend";

                        zip.ExtractProgress += new EventHandler<ExtractProgressEventArgs>(zip_ExtractProgress);

                        zip.ExtractAll(dest, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                    }
                } */       
                analyzeAsync($"{filepath}{file}", codepath, counter);
                counter++;
            }
        }

        //Main function
        //NOTE: Optimized = Check per line instead of per file
        private void analyzeAsync(string filepath, string codepath, int numFiles)
        {
            //Load the file first
            StreamReader f = new StreamReader(filepath);

            //Load the errors
            List<string[]> errorCodes = loadCodes(codepath);

            int counter = 0;
            string line;

            //Iterate through the given debug log
            //Check each line if error code is present
            while ((line = f.ReadLine()) != null)
            {
                //If present, add the error code to the errors found
                //Add the line to the errors list
                foreach (string[] error in errorCodes)
                {
                    if ((line.ToLower()).Contains(error[0].ToLower()))
                    {
                        errorsFound.Add(error);
                        errorList[counter].Add(line);
                    }
                    counter++;
                }
                counter = 0;
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
                string[] arr = line.Split(',');

                codeList.Add(arr);
                errorList.Add(new List<string>() { arr[0] }); //Add the error code at the start of the list
                counter++;
            }

            code.Close();

            return codeList;
        }
        
        /*
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
        }*/

    }
}
