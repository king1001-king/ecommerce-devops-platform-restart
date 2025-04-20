using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var products = new[]
            {
                new { Id = 1, Name = "Laptop", Price = 70000 },
                new { Id = 2, Name = "Smartphone", Price = 25000 },
                new { Id = 3, Name = "Headphones", Price = 2000 }
            };

            return Ok(products);
        }
    }
}
