namespace Ecommerce.API
{
    public class ProductService
    {
        public List<string> GetProduct()
        {
            return new List<string>
            {
                "Laptop",
                "Phone",
                "Tablet"
            };
        }
    }
}
