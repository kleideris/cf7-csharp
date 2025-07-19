using WebAppStarter_DB.DTO;

namespace WebAppStarter_DB.Services
{
    public interface IStudentService
    {
        StudentReadOnlyDTO? InsertStudent(StudentInsertDTO studentReadOnlyDTO);
        void UpdateStudent(StudentUpdateDTO studentUpdateDTO);
        void DeleteStudent(int id);
        StudentReadOnlyDTO? GetStudent(int id);
        List<StudentReadOnlyDTO> GetAllStudents();
    }
}
