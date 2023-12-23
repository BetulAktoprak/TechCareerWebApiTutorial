namespace TechCareerWebApiTutorial.Models
{
    public class ProductService
    {
        

        public static List<Product> GetProducts()
        {
            var products = new List<Product>();

            Category kırtasiyeCategory = new Category(1, "Kitap");

            products.Add(new Product(1, "kitap", 70,kırtasiyeCategory));
            products.Add(new Product(2, "kalem", 40, kırtasiyeCategory));
            products.Add(new Product(3, "silgi", 30, kırtasiyeCategory));
            products.Add(new Product(4, "defter", 60, kırtasiyeCategory));

            return products;
        }
    }
}
