using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GiveAShitBackend.Database.Models;

namespace GiveAShitBackend.Services
{
    public interface IBarcodeService
    {
        string CreateBarcode(IEnumerable<Product> products);
    }
}