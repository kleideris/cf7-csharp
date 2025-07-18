using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter.DTO;
using WebAppStarter.Models;

namespace WebAppStarter.Pages.Students
{
    public class ViewStudentsModel : PageModel
    {
        public List<StudentReadOnlyDTO> StudentsReadOnlyDTOs { get; set; } = [
            MapStudentToDTO(new Student() {Id = 1, Firstname = "Γιώργος", Lastname = "Φράγκος"}),
            MapStudentToDTO(new Student() {Id = 2, Firstname = "Κώστας", Lastname = "Ανδρούτσος"}),
            MapStudentToDTO(new Student() {Id = 3, Firstname = "Άννα", Lastname = "Γιαννούτσου"})
        ];


        public IActionResult OnGet()
        {
            if (Request.Query.TryGetValue("lastname", out var lastname))
            {
                StudentsReadOnlyDTOs = StudentsReadOnlyDTOs.Where(s => s.Lastname == lastname).ToList();
                return Page();
            }
            return Page();
        }

        private static StudentReadOnlyDTO MapStudentToDTO(Student student)
        {
            return new StudentReadOnlyDTO()
            {
                Id = student.Id,
                Firstname = student.Firstname,
                Lastname = student.Lastname
            };
        }
    }
}
