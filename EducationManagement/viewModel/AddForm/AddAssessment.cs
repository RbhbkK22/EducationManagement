using EducationManagement.extensions;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EducationManagement.viewModel.AddForm
{
    public partial class AddAssessment : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        DataGridView dataGridView;
        Tools tool = new Tools();
        int idStaff;
        int nameSub;
        string prava;
        int idTab;

        public AddAssessment(DataGridView dataGridView, int idStaff, string prava, int idTab)
        {
            InitializeComponent();
            dataBase.Connect();
            this.dataGridView = dataGridView;
            this.idStaff = idStaff;
            this.prava = prava;
            this.idTab = idTab;
            assessmentTextBox.AddPlaceholder("Оценка");
            grupBox.AddPlaceHolderComboBox("Группа");
            subBox.AddPlaceHolderComboBox("Предмет");
            StudentBox.AddPlaceHolderComboBox("Студент");
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (assessmentTextBox.Text == "Оценка" || StudentBox.Text == null || subBox.Text == "Предмет" || StudentBox.Text == null || StudentBox.Text == "Студент")
                {
                    MessageBox.Show("Нужные данные не введены");
                }
                else
                {
                    dataBase.cn.Close();
                    dataBase.cn.Open();
                    string[] names = StudentBox.Text.Split(' ');
                    command = new MySqlCommand($"INSERT INTO assessments(idStudent, idSubject, assessment) " +
                        $"VALUES((SELECT id FROM students WHERE stuName = '{names[0]}' AND lastName = '{names[1]}'), " +
                        $"(SELECT id FROM subjects WHERE name = '{subBox.Text}'), {assessmentTextBox.Text.Trim()})", dataBase.cn);
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

        private void AddAssessment_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            if (!tool.checkAdmin(prava))
            {

                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand($"SELECT * FROM subjects WHERE idTeacher = {idStaff}", dataBase.cn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    subBox.Items.Add(reader.GetValue(1).ToString());
                }
                reader.Close();
                dataBase.cn.Close();
            }
            else
            {
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand($"SELECT * FROM subjects", dataBase.cn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    subBox.Items.Add(reader.GetValue(1).ToString());
                }
                reader.Close();
                dataBase.cn.Close();
            }
            dataBase.cn.Close();
            dataBase.cn.Open();
            command = new MySqlCommand($"SELECT * FROM grup", dataBase.cn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                grupBox.Items.Add($"{reader.GetValue(1)}");
            }
            reader.Close();
            dataBase.cn.Close();
        }

        private void grupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentBox.Items.Clear();
            dataBase.cn.Close();
            dataBase.cn.Open();
            command = new MySqlCommand($"SELECT * FROM students WHERE idGrup = (SELECT id FROM grup WHERE number = '{grupBox.Text}')", dataBase.cn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                StudentBox.Items.Add($"{reader.GetValue(2)} {reader.GetValue(3)}");
            }
            reader.Close();
            dataBase.cn.Close();
        }
    }
}
