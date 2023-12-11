using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement
{
    public class DataBase
    {
        public MySqlConnection cn;
        MySqlCommand command;
        MySqlDataAdapter dataAdapter;
        DataTable dataTable;
        
        public void Connect()
        {
            cn = new MySqlConnection("server=localhost; port=3306; username=root; password=; database=educationmanagement");
        }

        public void loadDB(DataGridView dataGridView, int id)
        {
            
            try
            {
                cn.Close();
                cn.Open();
                switch (id)
                {
                    case 0:
                        command = new MySqlCommand("SELECT students.id, grup.number, students.stuName, students.lastName, students.address FROM students JOIN grup ON students.idGrup = grup.id", cn);
                        break;
                    case 1:
                        command = new MySqlCommand("SELECT * FROM grup", cn);
                        break;
                    case 2:
                        command = new MySqlCommand("SELECT subjects.id, subjects.name, staff.staffName, staff.lastName FROM subjects JOIN staff ON subjects.idTeacher = staff.id", cn);
                        break;
                    case 3:
                        command = new MySqlCommand("SELECT assessments.id, students.stuName, students.lastName, subjects.name, assessments.assessment FROM assessments" +
                            " JOIN students ON assessments.idStudent = students.id JOIN subjects ON assessments.idSubject = subjects.id;", cn);
                        break;
                    case 4:
                        command = new MySqlCommand("SELECT staff.id, staff.staffName, staff.lastName, positions.name, staff.salary, staff.login, staff.pass FROM staff JOIN positions ON staff.idPositions = positions.id", cn);
                        break;
                    case 5:
                        command = new MySqlCommand("SELECT * FROM positions", cn);
                        break;
                }
                command.ExecuteNonQuery();
                dataTable = new DataTable();
                dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable.DefaultView;
                cn.Close();
                
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
            }
        }


    }

    /*
      вывод таблиц 
      SELECT staff.id, staff.name, staff.lastName, positions.name, staff.salary FROM JOIN positions ON staff.idPositions = positions.id
    */
}
