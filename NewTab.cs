using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Analyzer
{
    class NewTab
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

        public NewTab(string name, TabControl current_tc, TabControl template)
        {
            //Init new TabPage to the TabControl
            tab_name = name;
            current_tc.TabPages.Add(tab_name, tab_name);

            //Add all the previous elements to the new tab page
            loadContent(current_tc.TabPages[tab_name]);

            //Set focus to the new tab page
            current_tc.SelectedTab = current_tc.TabPages[tab_name];
        }

        public static bool doesExist(string tp_name, TabControl tc)
        {
            if (tc.TabPages.ContainsKey(tp_name))
                return true;
            return false;
        }

        private void loadContent(TabPage tp)
        {
            CDT_Tab_Template new_tab = new CDT_Tab_Template(tp);
        }
        
    }
}
