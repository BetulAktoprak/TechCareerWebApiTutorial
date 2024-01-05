using System.ComponentModel.DataAnnotations;
using TechCareerWebApiTutorial.Models.ORM;

namespace TechCareerWebApiTutorial.Models
{
	public class Company : BaseModel
	{
        [MaxLength(100)]
        public string Name { get; set; }
        public Address? Address { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
