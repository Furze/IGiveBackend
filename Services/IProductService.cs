using System;
using System.Collections.Generic;
using GiveAShitBackend.Database.Models;

namespace GiveAShitBackend.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductByBarcode(string barcode);
        IEnumerable<ProductAssignment> GetAssignedProducts(int UserId);
        void AddProduct(Product product);
    }
}