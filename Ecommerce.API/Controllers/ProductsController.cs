using Ecommerce.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductsController(ProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _service.GetAllAsync();
            return Ok(products);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            var created = await _service.AddAsync(product);
            return Ok(created);
        }

    }
}
