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
    public partial class AddPosit : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        DataGridView dataGridView;
        int idTab;

        public AddPosit(DataGridView dataGridView, int idTab)
        {
            InitializeComponent();
            dataBase.Connect();
            this.dataGridView = dataGridView;
            this.idTab = idTab;
            nameTextBox.AddPlaceholder("Название");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {


                if (nameTextBox.Text == "Название")
                {
                    MessageBox.Show("Нужные данные не введены");
                }
                else
                {
                    dataBase.cn.Close();
                    dataBase.cn.Open();
                    command = new MySqlCommand($"INSERT INTO positions (name) VALUES ('{nameTextBox.Text.Trim()}');", dataBase.cn);
                    command.ExecuteNonQuery();
                    dataBase.cn.Close();
                    dataBase.loadDB(dataGridView, idTab);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
