using System.Collections.Generic;
using Client.Models;

namespace Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
            new Product()
            {
                Name = "Iphone X",
                Description = "Good phone",
                ImageFile = "iphonex.png",
                Category = "Phone",
                Price = 12000.00M
            },
            new Product()
            {
                Name = "Samsung galaxy",
                Description = "Nice phone",
                ImageFile = "samsung-galaxy.png",
                Category = "Phone",
                Price = 9000.00M
            },
            new Product()
            {
                Name = "Xiaomi Mi11",
                Description = "Not bad phone",
                ImageFile = "xiaomi-mi-11.png",
                Category = "Phone",
                Price = 10000.00M
            }
        };
    }
}
