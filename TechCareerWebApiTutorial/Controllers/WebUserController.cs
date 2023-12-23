using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechCareerWebApiTutorial.Controllers.Models;

namespace TechCareerWebApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebUserController : ControllerBase
    {
        static List<WebUser> webusers;

        //public WebUserController() 
        //{
        //    webusers = WebUserService.GetWebUsers();
        //}
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(webusers);
        }

       
    }
}
