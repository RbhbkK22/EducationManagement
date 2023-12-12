using EducationManagement.extensions;
using MySqlConnector;

namespace EducationManagement
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        MySqlCommand command;
        public Form1()
        {
            InitializeComponent();
            dataBase.Connect();
            loginTextBox.AddPlaceholder("Логин");
            passTextBox.AddPlaceholder("Пароль");
        }

        private void autorisBtn_Click(object sender, EventArgs e)
        {
            try
            {


                if (loginTextBox.Text == "Логин" || passTextBox.Text == "Пароль")
                {
                    MessageBox.Show("Введите логин и пароль");
                }
                else
                {


                    string login = loginTextBox.Text;
                    string password = passTextBox.Text;
                    string posit = string.Empty;
                    dataBase.cn.Close();
                    dataBase.cn.Open();
                    command = new MySqlCommand($"SELECT name FROM positions WHERE id = (SELECT idPositions FROM staff WHERE login = '{login}' AND pass = '{password}')", dataBase.cn);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        command = new MySqlCommand($"SELECT name FROM positions WHERE id = (SELECT idPositions FROM staff WHERE login = '{login}' AND pass = '{password}')", dataBase.cn);
                        reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            posit = reader.GetString(0);
                        };
                        reader.Close();
                        command = new MySqlCommand($"SELECT id FROM staff WHERE login = '{login}' AND pass = '{password}'", dataBase.cn);
                        reader = command.ExecuteReader();
                        int id = 0;
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0);
                        }
                        MAIN main = new MAIN(posit, id);
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Логин или пароль введены не верно");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}