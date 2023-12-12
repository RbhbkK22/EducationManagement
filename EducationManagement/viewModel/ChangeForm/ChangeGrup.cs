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

namespace EducationManagement.viewModel.ChengeForm
{
    public partial class ChangeGrup : Form
    {
        Tools tool = new Tools();
        DataBase dataBase = new DataBase();
        DataGridView dataGridView;
        MySqlCommand command;
        int idTab;
        string prava;
        int idRecor;

        public ChangeGrup(DataGridView dataGridView, int idTab, string prava, int idRecor)
        {
            InitializeComponent();
            dataBase.Connect();
            this.dataGridView = dataGridView;
            this.idTab = idTab;
            this.prava = prava;
            this.idRecor = idRecor;
            Print();
        }

        private void Print()
        {
            numberGrupTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand($"UPDATE grup SET number = '{numberGrupTextBox.Text}' WHERE id = {idRecor}", dataBase.cn);
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

        private void ChangeGrup_Load(object sender, EventArgs e)
        {
            if (!tool.checkAdmin(prava))
            {
                MessageBox.Show("У вас нет прав для редактирования данной таблицы");
                this.Close();
            }
        }
    }
}
