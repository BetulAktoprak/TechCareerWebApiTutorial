using System.ComponentModel.DataAnnotations;

namespace TechCareerWebApiTutorial.Models.ORM
{
    public class webUsers
    {
        [Key]
        public int webUserId { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int Phone { get; set; }
        public List<Order> Orders { get; set; }
    }
}
