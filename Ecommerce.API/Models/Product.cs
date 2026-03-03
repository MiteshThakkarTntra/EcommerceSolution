using System.ComponentModel.DataAnnotations;

namespace Ecommerce.API.Models
{
    public class Product
    {
        public int  Id { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
