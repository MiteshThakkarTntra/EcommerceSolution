using Ecommerce.API.Data;
using Ecommerce.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.API
{
    public class ProductService
    {

        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
