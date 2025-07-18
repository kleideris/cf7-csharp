namespace WebAppStarter_DB.DTO
{
    public class StudentReadOnlyDTO : BaseDTO
    {
        public string Fristname { get; set; }
        public string Lastname { get; set; }

        public StudentReadOnlyDTO() { }

        public StudentReadOnlyDTO(string fristname, string lastname)
        {
            Fristname = fristname;
            Lastname = lastname;
        }
    }
}
