using EducationManagement.extensions;
using EducationManagement.viewModel.AddForm;
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
        int idStaff;
        public MAIN(string positions, int idStaff)
        {
            InitializeComponent();
            this.positons = positions;
            tools = new Tools(positions);
            tools.deletePages(tabControl1);
            dataBase.Connect();
            tabControl1.SelectedIndex = 0;
            dataBase.loadDB(dataGridView1, tabControl1.SelectedIndex);
            this.idStaff = idStaff;
        }


        private void MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataBase.loadDB(dataGridView1, tabControl1.SelectedIndex);
        }

        private void OpenAddForm_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    AddStudent addStudent = new AddStudent(dataGridView1, tabControl1.SelectedIndex);
                    addStudent.Show();
                    break;
                case 1:
                    AddGrup addGrup = new AddGrup(dataGridView1, tabControl1.SelectedIndex);
                    addGrup.Show();
                    break;
                case 2:
                    AddSubject addSubject = new AddSubject(dataGridView1, tabControl1.SelectedIndex, positons);
                    addSubject.Show();
                    break;
                case 3:
                    AddAssessment addAssessment = new AddAssessment(dataGridView1, idStaff, positons, tabControl1.SelectedIndex);
                    addAssessment.Show();
                    break;
                case 4:
                    break;
                case 5:
                    AddPosit addPosit = new AddPosit(dataGridView1,tabControl1.SelectedIndex);
                    addPosit.Show();
                    break;
            }
        }
    }
}
