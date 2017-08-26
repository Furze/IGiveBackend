using System;
using System.Collections.Generic;
using GiveAShitBackend.Database.Models;

namespace GiveAShitBackend.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductByBarcode(string barcode);
        void AddProduct(Product product);
    }
}