using Microsoft.Data.SqlClient;
using WebAppStarter_DB.Models;
using WebAppStarter_DB.Services.DBHelper;

namespace WebAppStarter_DB.DAO
{
    public class StudentDAOImpl : IStudentDAO
    {

        public Student? Insert(Student student)
        {
            Student? studentToReturn = null ;
            int insertedId = 0;
            string sql1 = @"
                INSERT INTO Students (Firstname, Lastname) 
                VALUES (@Firstname, @Lastname); 
                SELECT SCOPE_IDENTITY();";

            using SqlConnection connection = DBUtil.GetConnection();
            connection.Open();

            using SqlCommand command1 = new(sql1, connection);
            command1.Parameters.AddWithValue("@Firstname", student.Firstname);
            command1.Parameters.AddWithValue("@Lastname", student.Lastname);

            object insertedObject = command1.ExecuteScalar();
            if (insertedObject is not null)
            {
                if (!int.TryParse(insertedObject.ToString(), out insertedId))
                {
                    throw new Exception("Error in inserted id");
                }
            }

            string sql2 = @"
                SELECT * FROM Students 
                WHERE id = @StudentId";
            using SqlCommand command2 = new(sql2, connection);
            command2.Parameters.AddWithValue("@StudentId", insertedId);

            using SqlDataReader reader = command2.ExecuteReader();
            if (reader.Read())
            {
                studentToReturn = new Student()
                {
                    Id = (int)reader["Id"],  //reader.GetInt32(0), or  reader.GetInt32(reader.GetOrdinal("Id));
                    Firstname = (string)reader["Firstname"],
                    Lastname = (string)reader["Lastname"]
                };
            }
            return student;


        }

        public void Update(Student student)
        {
            string sql = @"
                Update Students
                SET Firstname= @Firstname, Lastname = @Lastname
                Where id = @Id";

            using SqlConnection connection = DBUtil.GetConnection();
            connection.Open();

            using SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@Id", student.Id);
            command.Parameters.AddWithValue("@Firstname", student.Firstname);
            command.Parameters.AddWithValue("@Lastname", student.Lastname);

            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            string sql = @"
                DELETE FROM Students
                Where Id = @Id";

            using SqlConnection connection = DBUtil.GetConnection();
            connection.Open();

            using SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public Student? GetById(int id)
        {
            Student? studentToReturn = null;
            string sql = @"
                SELECT * FROM Students
                WHERE Id = @Id";

            using SqlConnection connection = DBUtil.GetConnection();
            connection.Open();

            using SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@Id", id);

            using SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                studentToReturn = new Student()
                {
                    Id = (int)reader["Id"],  //reader.GetInt32(0), or  reader.GetInt32(reader.GetOrdinal("Id));
                    Firstname = (string)reader["Firstname"],
                    Lastname = (string)reader["Lastname"]
                };
            }
            return studentToReturn;
        }

        public List<Student> GetAll()
        {
            string sql = "SELECT * FROM Students";
            List<Student> students = [];

            using SqlConnection connection = DBUtil.GetConnection();
            connection.Open();

            using SqlCommand command = new(sql, connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                students.Add(new Student()
                {
                    Id = (int)reader["id"],
                    Firstname = (string)reader["Firstname"],
                    Lastname = (string)reader["Lastname"]
                });
            }
            return students;
        }

       

     
    }
}
