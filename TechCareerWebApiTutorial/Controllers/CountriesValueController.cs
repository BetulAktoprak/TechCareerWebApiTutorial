using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechCareerWebApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesValueController : ControllerBase
    {
        [HttpGet]
        public string GetCountries(int id)
        {
            string[] countries = new string[] { "AFGANİSTAN", "ALMANYA", "AMERİKA BİRLEŞİK DEVLETLERİ", "AMERİKAN SAMOASI (ABD)", "ANDORRA", "ANGOLA", "ANGUİLLA (Birleşik Krallık)", "ANTİGUA ve BARBUDA", "ARJANTİN", "ARNAVUTLUK", "ARUBA (Hollanda)", " AZOR ADALARI (Portekiz)", "AVUSTRALYA", "AVUSTURYA", "AZERBAYCAN", "BAHAMALAR", "BAHREYN", "BANGLADEŞ", "BARBADOS" };
            if(id < 0 || id > countries.Length )
            {
                return "index hatası";
            }
            else
            {
                //id+countries.Length
                return countries[id];
            }
            
        }
    }
}
