using System.Collections.Generic;
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

        public string GiveItems(IEnumerable<Product> products)
        {
            throw new System.NotImplementedException();
        }

        public string RedemItems(string barcode)
        {
            throw new System.NotImplementedException();
        }
    }
}