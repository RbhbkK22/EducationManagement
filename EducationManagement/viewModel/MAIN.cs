using EducationManagement.extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationManagement
{
    public partial class MAIN : Form
    {
        string positons;
        DataBase dataBase = new DataBase();
        Tools tools;
        public MAIN(string positions)
        {
            InitializeComponent();
            this.positons = positions;
            tools = new Tools(positions);
            tools.deletePages(tabControl1);
            dataBase.Connect();
            tabControl1.SelectedIndex = 0;
            dataBase.loadDB(dataGridView1, tabControl1.SelectedIndex);

        }


        private void MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.loadDB(dataGridView1, comboBox1.SelectedIndex);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataBase.loadDB(dataGridView1, tabControl1.SelectedIndex);
        }




        /*        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
                {
                    dataBase.loadDB(dataGridView1, comboBox1.SelectedIndex);
                }*/
    }
}
