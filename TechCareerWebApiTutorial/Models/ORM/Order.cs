using System.ComponentModel.DataAnnotations;

namespace TechCareerWebApiTutorial.Models.ORM
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int TotalPrice { get; set; }
        public List<webUsers> webUsers { get; set; }
    }
}
