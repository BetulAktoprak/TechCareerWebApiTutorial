namespace TechCareerWebApiTutorial.Models.ORM
{
    public class Employee : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? City { get; set; }
    }
}
