using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using TechCareerWebApiTutorial.Models;

namespace TechCareerWebApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        static List<Product> products;
        public ProductController()
        {
            products = ProductService.GetProducts();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }
        [HttpPost]
        public IActionResult Post(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return StatusCode(StatusCodes.Status201Created, product);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                products.Remove(product);
                return Ok(product);
            }
            
        }
    }
}
