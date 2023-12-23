namespace TechCareerWebApiTutorial.Models
{
    public class Product
    {
       

        public Product(int id, string? name, int unitprice, Category category)
        {
            Id = id;
            Name = name;
            UnitPrice = unitprice;
            Category = category;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int UnitPrice { get; set; }
        public Category Category { get; set; }
       
    }
}
