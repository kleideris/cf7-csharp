using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter_DB.DTO;
using WebAppStarter_DB.Models;
using WebAppStarter_DB.Services;

namespace WebAppStarter_DB.Pages.Students
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public StudentUpdateDTO StudentUpdateDTO { get; set; } = new();

        public List<Error> ErrorArray { get; set; } = [];

        private readonly IStudentService _studentService;

        public UpdateModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult OnGet(int id)
        {
            try
            {
                StudentReadOnlyDTO? studentReadOnlyDTO = _studentService.GetStudent(id);
                StudentUpdateDTO = new StudentUpdateDTO()
                {
                    Id = studentReadOnlyDTO.Id,
                    Firstname = studentReadOnlyDTO.Firstname,
                    Lastname = studentReadOnlyDTO.Lastname,
                };
            }
            catch (Exception ex)
            {
                ErrorArray.Add(new Error("", ex.Message, ""));
            }
            return Page();
        }

        public void OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            try
            {
                StudentUpdateDTO.Id = id;
                _studentService.UpdateStudent(StudentUpdateDTO);
                Response.Redirect("/Students/getall");
            }
            catch (Exception ex)
            {
                ErrorArray.Add(new Error("", ex.Message, ""));
            }
        }
    }
}
