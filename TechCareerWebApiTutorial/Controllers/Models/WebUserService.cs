namespace TechCareerWebApiTutorial.Controllers.Models
{
    public class WebUserService
    {
        public List<WebUser> GetWebUsers()
        {
            var webUsers = new List<WebUser>();
            webUsers.Add(new WebUser("cagatay@mail.com", 1));
            webUsers.Add(new WebUser("ahmet@mail.com", 2));
            webUsers.Add(new WebUser("ece@mail.com", 3));
            return webUsers;
        }
    }
}
