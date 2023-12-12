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
    public partial class ChangeAssessment : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        DataGridView dataGridView;
        Tools tool = new Tools();
        int idStaff;
        int nameSub;
        string prava;
        int idTab;
        int idRecor;

        public ChangeAssessment(DataGridView dataGridView, int idStaff, string prava, int idTab, int idRecor)
        {
            InitializeComponent();
            dataBase.Connect();
            this.dataGridView = dataGridView;
            this.idStaff = idStaff;
            this.prava = prava;
            this.idTab = idTab;
            this.idRecor = idRecor;

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.cn.Close();
                dataBase.cn.Open();
                string[] names = StudentBox.Text.Split(' ');
                command = new MySqlCommand($"UPDATE assessments SET stuName = (SELECT id FROM students WHERE stuName = '{names[0]}' AND lastName = '{names[1]}'), " +
                    $"(SELECT id FROM subjects WHERE name = '{subBox.Text}'), {assessmentTextBox.Text.Trim()} WHERE id = {idRecor}", dataBase.cn);
                command.ExecuteNonQuery();
                dataBase.cn.Close();
                dataBase.loadDB(dataGridView, idTab);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ChangeAssessment_Load(object sender, EventArgs e)
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
            if (subBox.Items.Contains(dataGridView.CurrentRow.Cells[2].Value.ToString()))
            {
                MessageBox.Show("Вы не можите редактировать эту запись");
                this.Close();
            }

            StudentBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString() + dataGridView.CurrentRow.Cells[1].Value.ToString();
            subBox.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            assessmentTextBox.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
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
