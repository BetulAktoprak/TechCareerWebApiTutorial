using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechCareerWebApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public string[] GetCountries()
        {
            string[] countries = new string[] { "AFGANİSTAN" ,"ALMANYA","AMERİKA BİRLEŞİK DEVLETLERİ","AMERİKAN SAMOASI (ABD)","ANDORRA","ANGOLA","ANGUİLLA (Birleşik Krallık)","ANTİGUA ve BARBUDA","ARJANTİN","ARNAVUTLUK","ARUBA (Hollanda)"," AZOR ADALARI (Portekiz)","AVUSTRALYA","AVUSTURYA","AZERBAYCAN","BAHAMALAR","BAHREYN","BANGLADEŞ","BARBADOS" };
            return countries;
        }
    }
}
