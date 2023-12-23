namespace TechCareerWebApiTutorial.Controllers.Models
{
    public class WebUser
    {
        public WebUser(string email, int id)
        {
            this.Email = email;
            this.Id = id;
        }
        public int Id { get; set; }
        public string? Email { get; set; }
    }
}
