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
    public partial class ChangeStaff : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        DataGridView dataGridView;
        int idTab;
        int idRecord;
        Tools tool = new Tools();

        public ChangeStaff(DataGridView dataGridView, int idTab, int idRecord)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            this.idTab = idTab;
            dataBase.Connect();
            tool.FillingComboBox(positBox, "positions", 1);
            this.idRecord = idRecord;
            Print();
        }

        private void Print()
        {
            nameTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            lastNameTextBox.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            positBox.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            salaryTextBox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            loginTextBox.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            passTextBox.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand($"UPDATE staff SET staffName = '{nameTextBox.Text}', lastName = '{lastNameTextBox.Text}', " +
                    $"idPositions = (SELECT id FROM positions WHERE name = '{positBox.Text}'), salary = {salaryTextBox.Text}, " +
                    $"login = '{loginTextBox.Text}', pass = '{passTextBox.Text}'  WHERE = id = {idRecord}", dataBase.cn);
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
    }
}
