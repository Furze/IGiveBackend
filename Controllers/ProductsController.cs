using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiveAShitBackend.Database.Models;
using GiveAShitBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace GiveAShitBackend.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductService _productService;
        
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET api/product
        [HttpGet]
        public IEnumerable<Product> Get()
        {
           return _productService.GetAllProducts();
        }

        // GET api/product/5
        [HttpGet("{barcode}")]
        public Product Get(string barcode)
        {
            return _productService.GetProductByBarcode(barcode);
        }

        // POST api/product
        [HttpPost]
        public void Post([FromBody]Product product)
        {
            _productService.AddProduct(product);
        }

    }
}
