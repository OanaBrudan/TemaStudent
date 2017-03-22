using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace database1
{
    public class MySQLDBManager : IDBManager
    {
        private string connString;

        public MySQLDBManager()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Student> RetrieveStudents()
        {
            IList<Student> studentList = new List<Student>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM student";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.ID = reader.GetInt32("ID");
                        student.Name = reader.GetString("Name");
                        student.BirthDate = reader.GetDateTime("BirthDate");
                        student.Address = reader.GetString("Address");
                        studentList.Add(student);
                    }
                }
            }

            return studentList;
        }

        public void AddStudent(Student student)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO student(id, name, birthdate, address) VALUES(@id, @name, @birthdate, @address)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", student.ID);
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@birthdate", student.BirthDate);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateStudent";

                cmd.Parameters.Add(new MySqlParameter("StudentID", student.ID));
                cmd.Parameters.Add(new MySqlParameter("StudentName", student.Name));
                cmd.Parameters.Add(new MySqlParameter("StudentBirthDate", student.BirthDate));
                cmd.Parameters.Add(new MySqlParameter("StudentAddress", student.Address));

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(Student student)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM student(id) VALUES(@id)";
                //cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", 1);
                
                cmd.ExecuteNonQuery();
            }
            }
        }
    }

