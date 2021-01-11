using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Product.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly List<Product> Products = new List<Product>()
        {
            new Product(){Id=1,Name="Ürün 1",Price=11},
            new Product(){Id=2,Name="Ürün 2",Price=13},
            new Product(){Id=3,Name="Ürün 3",Price=15},
            new Product(){Id=4,Name="Ürün 4",Price=17},
            new Product(){Id=5,Name="Ürün 5",Price=19},
            new Product(){Id=6,Name="Ürün 6",Price=21},
        };
     

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Product> Get()
        {
            var rng = new Random();
            return Products.ToList();
        }
    }
}
