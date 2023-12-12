using EducationManagement.extensions;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EducationManagement.viewModel.AddForm
{
    public partial class AddStaff : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        DataGridView dataGridView;
        Tools tool = new Tools();
        int idTab;
        public AddStaff(DataGridView dataGridView, int idTab)
        {
            InitializeComponent();
            nameTextBox.AddPlaceholder("Имя");
            lastNameTextBox.AddPlaceholder("Фамилия");
            salaryTextBox.AddPlaceholder("Зарплата");
            loginTextBox.AddPlaceholder("Логин");
            passTextBox.AddPlaceholder("Пароль");
            positBox.AddPlaceHolderComboBox("Должность");
            tool.FillingComboBox(positBox, "positions", 1);
            this.dataGridView = dataGridView;
            this.idTab = idTab;
            dataBase.Connect();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {


                if (nameTextBox.Text == "Имя" || lastNameTextBox.Text == "Фамилия" || salaryTextBox.Text == "Зарплата" || loginTextBox.Text == "Логин"
                    || passTextBox.Text == "Пароль" || positBox.Text == null || positBox.Text == "Должность")
                {
                    MessageBox.Show("Нужные данные не введены");
                }
                else
                {
                    dataBase.cn.Close();
                    dataBase.cn.Open();
                    command = new MySqlCommand($"INSERT INTO staff (staffName, lastName, idPositions, salary, login, pass) " +
                        $"VALUES('{nameTextBox.Text}', '{lastNameTextBox.Text}', (SELECT id FROM positions WHERE name = '{positBox.Text}'), " +
                        $"{salaryTextBox.Text}, '{loginTextBox.Text}', '{passTextBox.Text}');", dataBase.cn);

                    command.ExecuteNonQuery();
                    dataBase.loadDB(dataGridView, idTab);
                    dataBase.cn.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
