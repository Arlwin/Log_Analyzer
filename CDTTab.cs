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
        private string tab_name;

        public CDTTab(string name, TabControl tc)
        {
            tab_name = name;
            
            TabPage page = new TabPage();
            page.Text = name;

            tc.TabPages.Add(page);
        }



    }
}
