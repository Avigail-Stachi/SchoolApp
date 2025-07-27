using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SchoolApp.DAL
{
    public class StudentDAL
    {
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            using (var conn = new SQLiteConnection(DbManager.GetConnectionString()))
            {
                conn.Open();
                //string query = "SELECT * FROM Students";

                var command = new SQLiteCommand("SELECT * FROM Students", conn);

                var reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        var student = new Student
                        {
                            ID = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            HomePhone = reader.GetString(3),
                            BirthdayYear = reader.GetInt32(4),
                            Class = reader.GetString(5),
                            Address = reader.GetString(6)
                        };
                        students.Add(student);
                    }
                }
            }
            return students;
        }
    }
}
