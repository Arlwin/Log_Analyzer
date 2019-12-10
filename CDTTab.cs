using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Analyzer
{
    class CDTTab
    {
        /*
         * Instantiate the name of the tab
         *  If name exists, return true
         *  If not, return false and proceed to creation
         *  
         * Add all the same items from the original tab
         * 
         */

        private string tab_name;

        public CDTTab(string name, TabControl tc)
        {
            //Add a new TabPage to the TabControl
            tab_name = name;
            tc.TabPages.Add(tab_name, tab_name);

            //Add all the previous elements to the new tab page
            loadContent(tc);

            //Set focus to the new tab page
            tc.SelectedTab = tc.TabPages[tab_name];
        }

        public static bool doesExist(string tp_name, TabControl tc)
        {
            if (tc.TabPages.ContainsKey(tp_name))
                return true;
            return false;
        }

        private void loadContent(TabControl tc)
        {

        }

    }
}
