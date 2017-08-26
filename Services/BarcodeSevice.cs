using System;
using System.Collections.Generic;
using System.Linq;
using GiveAShitBackend.Database;
using GiveAShitBackend.Database.Models;
using Microsoft.CodeAnalysis.CSharp;

namespace GiveAShitBackend.Services
{
    public class BarcodeSevice : IBarcodeService
    {
        private readonly GASDbContext _dbContext;


        public BarcodeSevice(GASDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string CreateBarcode(IEnumerable<Product> products, int userId)
        {
            List<ProductAssignment> productAssignments = new List<ProductAssignment>();
            foreach (var product in products)
            {
               productAssignments.Add(_dbContext.ProductAssignments.First(x => (x.Id.Equals(product.Id) && x.User.Id == userId)));
            }

            var barcode = new Barcode
            {   
                
                Products = productAssignments,
                Guid = Guid.NewGuid().ToString()
            };

            _dbContext.Barcodes.Add(barcode);
            _dbContext.SaveChanges();

            return barcode.Guid;
        }
    }
}