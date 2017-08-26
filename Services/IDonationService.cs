using System;
using System.Collections.Generic;
using GiveAShitBackend.Database.Models;

namespace GiveAShitBackend.Services
{
    public interface IDonationService
    {
        string GiveItems(IEnumerable<Product> products);
        string RedemItems(String barcode);
    }
}