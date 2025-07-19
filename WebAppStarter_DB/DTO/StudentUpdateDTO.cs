using System.ComponentModel.DataAnnotations;

namespace WebAppStarter_DB.DTO
{
    public class StudentUpdateDTO : BaseDTO
    {
        [Required(ErrorMessage = "Firstname is required.")]
        [MinLength(2, ErrorMessage = "Firstname must be at least 2 character long.")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required.")]
        [MinLength(2, ErrorMessage = "Lastname must be at least 2 character long.")]
        public string? Lastname { get; set; }

        public StudentUpdateDTO() { }

        public StudentUpdateDTO(int id, string? firstname, string? lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
