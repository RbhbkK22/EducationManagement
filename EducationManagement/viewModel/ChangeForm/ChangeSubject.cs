using EducationManagement.extensions;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationManagement.viewModel.ChangeForm
{
    public partial class ChangeSubject : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        DataGridView dataGridView;
        Tools tools = new Tools();
        int idTab;
        string prava;
        int idRecor;

        public ChangeSubject(DataGridView dataGridView, int idTab, string prava, int idRecor)
        {
            InitializeComponent();
            dataBase.Connect();
            tools.FillingComboBox(TecherBox, "staff", 0);
            this.dataGridView = dataGridView;
            this.idTab = idTab;
            this.prava = prava;
            this.idRecor = idRecor;
            Print();
        }

        private void Print()
        {
            nameTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            TecherBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand($"UPDATA subjects SET name = '{nameTextBox.Text.Trim()}', idTeacher = {TecherBox.Text} WHERE id = {idRecor}", dataBase.cn);
                command.ExecuteNonQuery();
                dataBase.cn.Close();
                dataBase.loadDB(dataGridView, idTab);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ChangeSubject_Load(object sender, EventArgs e)
        {
            if (!tools.checkAdmin(prava))
            {
                MessageBox.Show("У вас нет прав для редактирования данной таблицы");
                this.Close();
            }
        }
    }
}
