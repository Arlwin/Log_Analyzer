using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Log_Analyzer
{
    class UpdateAnalyzer
    {
        HashSet<string> findings = new HashSet<string>();
        List<string> errors = new List<string>();
        List<string[]> updatecsv = new List<string[]>();
 

        string summary = "";

        public UpdateAnalyzer(String filepath, String codepath)
        {
            init(filepath, codepath);
        }

        private void init(String filepath, String codepath)
        {
            //get the tmudump
            StreamReader tmudump = new StreamReader($"{filepath}\\TmuDump.txt");

            //get the update.csv
            updatecsv = loadCodes(codepath);

            string line = "";
            bool addtolastline = false;
            //Iterate
            while ((line = tmudump.ReadLine()) != null)
            {
                if (addtolastline == true && line[0] == ' ')
                {
                    errors[errors.Count -1] = errors.Last() + " " + line.Trim();
                    addtolastline = false;
                    continue;
                }

                if (checkLineforIssues(line))
                {
                    addtolastline = true;
                }

            }

            //Summarize
            summary = "Issues Found: \n===========================================\n\n";

            summary = summary + String.Join("\n", errors);

            summary = summary + "\n===========================================\n\n";

            foreach(var finding in findings)
            {
                summary = summary + finding + "\n";
            }

            tmudump.Close();
        }

        private List<string[]> loadCodes(String path)
        {
            List<string[]> c = new List<string[]>();
            string line;

            StreamReader r = new StreamReader(path);
            while ((line = r.ReadLine()) != null)
            {
                c.Add(line.Split(','));
            }
            
            r.Close();

            return c;
        }

        private bool checkLineforIssues(string line)
        {
            bool add = false;

            if (line.Contains("Err "))
            {
                errors.Add(line);
                 add = true;
            }

            foreach (string[] update in updatecsv)
            {
                if (line.Contains(update[0]))
                    findings.Add(update[1]);

            }

            return add;
        }

        public HashSet<string> getFindings()
        {
            return findings;
        }

        public List<string> getErrors()
        {
            return errors;
        }

        public string getSummary()
        {
            return summary;
        }
    }
}
