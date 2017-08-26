using System;
using System.Collections.Generic;
using System.Linq;
using GiveAShitBackend.Database;
using GiveAShitBackend.Database.Models;

namespace GiveAShitBackend.Services
{
    public class ProductService : IProductService
    {
        private readonly GASDbContext _dbContext;
        public ProductService(GASDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                return _dbContext.Products;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("Failed to get users");
            }
           
        }

        public IEnumerable<ProductAssignment> GetAssignedProducts(int UserId)
        {

            try
            {
                return _dbContext.ProductAssignments.Where(x => x.UserId.Id == UserId);


            }catch (Exception e)
            {
                throw e;

            }

        }

        public Product GetProductByBarcode(string barcode)
        {
            return _dbContext.Products.First(x => x.Barcode.Equals(barcode));
        }

        public void AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }
    }
}