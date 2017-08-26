using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiveAShitBackend.Database.Models;
using GiveAShitBackend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Internal.System.Collections.Sequences;

namespace GiveAShitBackend.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET api/products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAllProducts();
        }

        // GET api/products/5
        [HttpGet("{barcode}")]
        public Product Get(string barcode)
        {
            return _productService.GetProductByBarcode(barcode);
        }

        // POST api/products
        [HttpPost]
        public void Post([FromBody]Product product)
        {
            _productService.AddProduct(product);
        }

        // GET api/products?userId=
        [HttpGet("{userId}")]
        public IEnumerable<Product> Get([FromQuery] int UserId)
        {
           var ProductAssignments = _productService.GetAssignedProducts(UserId);
            List<Product> productList = new List<Product>();


            foreach(ProductAssignment p in ProductAssignments)
            {

                productList.Add(p.Transaction.Product);

            }
            return productList;

            }
         }
    }

