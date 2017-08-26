using System;
using System.Collections.Generic;
using System.Linq;
using GiveAShitBackend.Database;
using GiveAShitBackend.Database.Models;

namespace GiveAShitBackend.Services
{
    public class BarcodeSevice : IBarcodeService
    {
        private readonly GASDbContext _dbContext;


        public BarcodeSevice(GASDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string CreateBarcode(IEnumerable<Product> products)
        {
            List<Product> productsForBarcode = products.Select(product => _dbContext.Products.First(x => x.Id.Equals(product.Id))).ToList();

            Barcode barcode = new Barcode
            {
                Products = productsForBarcode,
                Guid = Guid.NewGuid().ToString()
            };

            _dbContext.Barcodes.Add(barcode);
            _dbContext.SaveChanges();

            return barcode.Guid;
        }
    }
}