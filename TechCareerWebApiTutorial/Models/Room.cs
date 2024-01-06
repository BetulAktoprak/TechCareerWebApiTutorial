using System.ComponentModel.DataAnnotations;
using TechCareerWebApiTutorial.Models.ORM;

namespace TechCareerWebApiTutorial.Models
{
	public class Room : BaseModel
	{
		[MaxLength(50)]
        public string Name { get; set; }
		
		
		
    }
}
