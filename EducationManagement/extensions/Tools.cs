using MySqlConnector;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement.extensions
{
    public class Tools
    {
        bool dostup;
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        public Tools()
        {
            dataBase.Connect();
        }

        public Tools(string prava)
        {
            this.dostup = checkAdmin(prava);
            dataBase.Connect();
        }

        public bool checkAdmin(string prava)
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

        protected List<string> IdsForFilling(string tab, int numColumn)
        {
            List<string> data = new List<string>();
            dataBase.cn.Close();
            dataBase.cn.Open();
            command = new MySqlCommand($"SELECT * FROM {tab}",dataBase.cn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                data.Add(reader.GetValue(numColumn).ToString());
            }
            return data;
        }

        public void FillingComboBox(ComboBox comboBox, string tab, int numColumn)
        {

            comboBox.Items.AddRange(IdsForFilling(tab, numColumn).ToArray());
        }

        public string GetTabName(int idTab)
        {
            switch (idTab)
            {
                case 0:
                    return "students";
                case 1:
                    return "grup";
                case 2:
                    return "subjects";
                case 3:
                    return "assessments";
                case 4:
                    return "staff";
                case 5:
                    return "positions";
            }
            return "";
        }
    }
}
