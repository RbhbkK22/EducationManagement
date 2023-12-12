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
    public partial class ChangePosit : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        DataGridView dataGridView;
        int idTab;
        int idRecord;

        public ChangePosit(DataGridView dataGridView, int idTab, int idRecord)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            this.idTab = idTab;
            dataBase.Connect();
            Print();
            this.idRecord = idRecord;
        }

        private void Print()
        {
            nameTextBox.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.cn.Close();
                dataBase.cn.Open();
                command = new MySqlCommand($"UPDETE positions SET name = '{nameTextBox.Text}' WHERE id = {idRecord}", dataBase.cn);
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
