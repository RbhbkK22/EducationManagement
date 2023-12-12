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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EducationManagement.viewModel.AddForm
{
    public partial class AddSubject : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        DataGridView dataGridView;
        Tools tools = new Tools();
        int idTab;
        string prava;

        public AddSubject(DataGridView dataGridView, int idTab, string prava)
        {
            InitializeComponent();
            nameTextBox.AddPlaceholder("Название");
            dataBase.Connect();
            tools.FillingComboBox(TecherBox, "staff", 0);
            this.dataGridView = dataGridView;
            this.idTab = idTab;
            this.prava = prava;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (nameTextBox.Text == "Имя" || TecherBox.Text == null)
                {
                    MessageBox.Show("Нужные данные не введены");
                }
                else
                {
                    dataBase.cn.Close();
                    dataBase.cn.Open();
                    command = new MySqlCommand($"INSERT INTO subjects (name, idTeacher) VALUES ('{nameTextBox.Text}', {TecherBox.Text})", dataBase.cn);
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

        private void AddSubject_Load(object sender, EventArgs e)
        {
            if (!tools.checkAdmin(prava))
            {
                MessageBox.Show("У вас нет прав для редактирования данной таблицы");
                this.Close();
            }
        }
    }
}
