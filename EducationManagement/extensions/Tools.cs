using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement.extensions
{
    public class Tools
    {
        bool dostup;
        public Tools()
        {

        }

        public Tools(string prava)
        {
            this.dostup = checkAdmin(prava);
        }

        protected bool checkAdmin(string prava)
        {
            if(prava == "администратор")
            {
                return true;
            }
            else
            {
                return false;
            }
        } 

        public void deletePages(TabControl tabControl)
        {
            if (!dostup)
            {
                tabControl.TabPages.RemoveAt(5);
                tabControl.TabPages.RemoveAt(4);
            }
        }
    }
}
