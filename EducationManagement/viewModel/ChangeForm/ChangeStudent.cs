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
    public partial class ChangeStudent : Form
    {
        Tools tool = new Tools();
        DataBase dataBase = new DataBase();
        DataGridView dataGridView;
        MySqlCommand command;
        int idTab;
        string prava;
        int idRecor;
        public ChangeStudent(DataGridView dataGridView, int idTab, string prava, int idRecor)
        {
            InitializeComponent();
            dataBase.Connect();
            this.dataGridView = dataGridView;
            this.idTab = idTab;
            this.prava = prava;
            this.idRecor = idRecor;
            tool.FillingComboBox(grupBox, "grup", 1);
            Print();
        }

        private void Print()
        {
            grupBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            nameTextBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            lastNameTextBox.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            string[] street = dataGridView.CurrentRow.Cells[4].Value.ToString().Split(' ');
            streetTextBox.Text = street[1];
            homeNumTextBox.Text = street[3];

        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand($"UPDATE students SET idGrup = (SELECT id FROM grup WHERE number = '{grupBox.Text}'),  stuName = '{nameTextBox.Text.Trim()}', " +
                    $"lastName = '{lastNameTextBox.Text.Trim()}', address = 'ул. {streetTextBox.Text.Trim()} д. {homeNumTextBox.Text.Trim()}' WHERE id = {idRecor}", dataBase.cn);
                command.ExecuteNonQuery();
                dataBase.cn.Close();
                dataBase.loadDB(dataGridView, idTab);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeStudent_Load(object sender, EventArgs e)
        {
            if (!tool.checkAdmin(prava))
            {
                MessageBox.Show("У вас нет прав для редактирования данной таблицы");
                this.Close();
            }
        }
    }
}
