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

namespace EducationManagement.viewModel.AddForm
{
    public partial class AddGrup : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        DataGridView dataGridView;
        Tools tool = new Tools();
        string prava;
        int idTab;
        public AddGrup(DataGridView dataGridView, int idTab, string prava)
        {
            InitializeComponent();
            numberGrupTextBox.AddPlaceholder("Номер группы");
            dataBase.Connect();
            this.dataGridView = dataGridView;
            this.idTab = idTab;
            this.prava = prava;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberGrupTextBox.Text == "Номер группы")
                {
                    MessageBox.Show("Нужные данные не введены");
                }
                else
                {
                    dataBase.cn.Close();
                    dataBase.cn.Open();
                    command = new MySqlCommand($"INSERT INTO grup (number) VALUES ('{numberGrupTextBox.Text.Trim()}');", dataBase.cn);
                    command.ExecuteNonQuery();
                    dataBase.cn.Close();
                    dataBase.loadDB(dataGridView, idTab);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddGrup_Load(object sender, EventArgs e)
        {
            if (!tool.checkAdmin(prava))
            {
                MessageBox.Show("У вас нет прав для редактирования данной таблицы");
                this.Close();
            }
        }
    }
}
