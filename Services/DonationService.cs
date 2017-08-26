using System.Collections.Generic;
using System.Linq;
using GiveAShitBackend.Database;
using GiveAShitBackend.Database.Models;

namespace GiveAShitBackend.Services
{
    public class DonationService : IDonationService
    {
        private readonly GASDbContext _dbContext;

        public DonationService(GASDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string GiveItems(IEnumerable<Product> products, int userId)
        {
            var user = _dbContext.Users.First(x => x.Id.Equals(userId));
            var userToGiveTo = _dbContext.Users.First(x => x.Name.Equals("Drew"));

            foreach (var product in products)
            {
                _dbContext.ProductAssignments.Add(new ProductAssignment
                {
                    DonatedBy = user,
                    User = userToGiveTo,
                    Product = product,
                    Completed = false
                });
            }
            _dbContext.SaveChanges();
            return "Success";
        }

        public string RedemItems(string barcodeId)
        {
            var barcode = _dbContext.Barcodes.First(x => x.Guid.Equals(barcodeId));
            foreach (var product in barcode.Products)
            {
                var productToMark = _dbContext.ProductAssignments.First(x => x.Product.Id.Equals(product.Id));
                productToMark.Completed = true;
                _dbContext.ProductAssignments.Update(productToMark);
                _dbContext.SaveChanges();
            }
            return "Success";

        }
    }
}