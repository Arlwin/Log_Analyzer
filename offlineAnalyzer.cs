using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

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

        //Extract 7z files
        public void Extract7zip(string sourceArchive, string destination)
        {
            string zPath = @"lib\7zip\x64\7za.exe"; //add to proj and set CopyToOuputDir
            try
            {
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = zPath;
                pro.Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", sourceArchive, destination);
                Process x = Process.Start(pro);
                x.WaitForExit();
            }
            catch (System.Exception Ex)
            {
                Console.WriteLine(Ex.Message.ToString());
            }
        }

        //Init
        private void init(String filepath, String codepath)
        {
            //Check first the Event 1 folder
            DirectoryInfo dir = new DirectoryInfo(filepath);

            //Init the codes
            List<string[]> errorCodes = loadCodes(codepath);

            //Get all the debuglogs
            FileInfo[] files = dir.GetFiles("ofcdebug.log*");

            //Reset the Progress bar
            int counter = 0;
            int total = files.Count();
            Form1.setMainProgressBar(counter);

            foreach (var file in files)
            {
                string filename = file.ToString();
                //If 7z file, extract first
                if (file.Extension.Contains(".7z"))
                {
                    //Check first if there is already a folder extracted
                    string extract_folder = $"{filepath}{filename.Substring(0, filename.IndexOf(".7z"))}";
                    if (Directory.Exists(extract_folder))
                    {
                        //If there is, get the log file inside of that folder                         
                        analyzeAsync($"{extract_folder}\\{filename.Substring(0, filename.IndexOf(".7z"))}.log", errorCodes);
                    }
                    else
                    {
                        //If there is none, extract first
                        //Create a new directory
                        string new_folder = Directory.CreateDirectory(filepath + filename.Substring(0, filename.IndexOf(".7z"))).ToString();
                        //Extract to that directory
                        Extract7zip(filepath + filename, filepath + new_folder);

                        //get the log inside the extracted folder
                        analyzeAsync($"{filepath}{new_folder}\\{filename.Substring(0, filename.IndexOf(".7z"))}.log", errorCodes);
                    }

                }
                else
                {
                    analyzeAsync($"{filepath}{file}", errorCodes);
                }

                //Update the progress bar for each file done
                //counter++;
                //Form1.setMainProgressBar(100 * (counter / total));
            }

        }

        //Main function
        //NOTE: Optimized = Check per line instead of per file
        private void analyzeAsync(string filepath, List<string[]> errorCodes)
        {
            //Load the file first
            StreamReader f = new StreamReader(filepath);

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
                    //Update the sub progress bar
                    //Form1.setSubProgressBar(100 * (counter / (errorCodes.Count())));
                }

                counter = 0;
                //Reset the sub
                //Form1.setSubProgressBar(counter);
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

                errorList.Add(new List<string>() { arr[0] }); //Add the error code at the start of the list, should only be called once
                counter++;
            }

            code.Close();

            return codeList;
        }


    }
}
