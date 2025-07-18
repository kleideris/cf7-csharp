using WebAppStarter_DB.Models;

namespace WebAppStarter_DB.DAO
{
    public interface IStudentDAO
    {
        Student? Insert(Student student);
        void Update(Student student);
        void Delete(int id);
        Student? GetById(int id);
        List<Student> GetAll();
    }
}
