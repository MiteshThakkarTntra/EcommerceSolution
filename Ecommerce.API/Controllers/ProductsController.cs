using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(ProductService productService) : ControllerBase
    {

        private readonly ProductService _productService = productService;

        [HttpGet]
        public IActionResult Get()
        {
            var products = _productService.GetProduct();
            return Ok(products);
        }
    }
}
