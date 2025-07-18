using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using WebAppStarter.DTO;

namespace WebAppStarter.Pages.Students
{
    public class IndexModel : PageModel
    {
        [BindProperty]  // Two-way binding
        public InsertStudentDTO? InsertStudentDTO { get; set; } = new();

        public void OnGet()
        { 
            // Return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TempData["Message"] = $"{InsertStudentDTO?.Firstname} {InsertStudentDTO?.Lastname}" +
                $" added successfully";

            return RedirectToPage("/Students/Success");
        }
    }
}
