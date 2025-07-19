using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter_DB.DTO;
using WebAppStarter_DB.Models;
using WebAppStarter_DB.Services;

namespace WebAppStarter_DB.Pages.Students
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public StudentInsertDTO StudentInsertDTO { get; set; } = new();

        public List<Error> ErrorArray { get; set; } = [];

        private readonly IStudentService _studentService;

        public CreateModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void OnGet()
        {
            // return Page();
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            try
            {
                StudentReadOnlyDTO studentReadOnlyDTO = _studentService.InsertStudent(studentInsertDTO);
                Response.Redirect("/Students/getall");
            }
            catch (Exception ex)
            {
                ErrorArray.Add(new Error("", ex.Message, ""));
                return;
            }
        }
    }
}
