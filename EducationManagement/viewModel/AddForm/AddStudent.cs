using EducationManagement.extensions;
using MySqlConnector;

namespace EducationManagement.viewModel.AddForm
{
    public partial class AddStudent : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        DataGridView dataGridView;
        Tools tool = new Tools();
        int idTab;
        string prava;

        public AddStudent(DataGridView dataGridView, int idTab, string prava)
        {
            InitializeComponent();
            nameTextBox.AddPlaceholder("Имя");
            lastNameTextBox.AddPlaceholder("Фамилия");
            streetTextBox.AddPlaceholder("Улица");
            homeNumTextBox.AddPlaceholder("Дом");
            /*            
             *            
             *            grupBox.AddPlaceholderComboBox("Номер группы");
             *            
             */
            this.dataGridView = dataGridView;
            this.idTab = idTab;
            dataBase.Connect();
            tool.FillingComboBox(grupBox, "grup", 1);
            this.prava = prava;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (nameTextBox.Text == "Имя" || lastNameTextBox.Text == "Фамилия" || streetTextBox.Text == "Улица" || homeNumTextBox.Text == "Дом" || grupBox.Text == "Номер группы")
                {
                    MessageBox.Show("Нужные данные не введены");
                }
                else
                {
                    dataBase.cn.Close();
                    dataBase.cn.Open();
                    command = new MySqlCommand($"INSERT INTO students (idGrup, stuName, lastName, address) VALUES ((SELECT id FROM grup WHERE number = '{grupBox.Text}'), " +
                        $"'{nameTextBox.Text.Trim()}', '{lastNameTextBox.Text.Trim()}', 'ул. {streetTextBox.Text.Trim()} д. {homeNumTextBox.Text.Trim()}')", dataBase.cn);
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

        private void AddStudent_Load(object sender, EventArgs e)
        {
            if (!tool.checkAdmin(prava))
            {
                MessageBox.Show("У вас нет прав для редактирования данной таблицы");
                this.Close();
            }
        }
    }
}
