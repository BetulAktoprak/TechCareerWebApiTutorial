using System.ComponentModel.DataAnnotations;
using TechCareerWebApiTutorial.Models.ORM;

namespace TechCareerWebApiTutorial.Models
{
	public class Client : BaseModel
	{
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public Address? Adress { get; set; }
        public string EMail { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
       
    }
}
