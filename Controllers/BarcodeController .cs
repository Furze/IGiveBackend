using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiveAShitBackend.Database.Models;
using GiveAShitBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace GiveAShitBackend.Controllers
{
    [Route("api/[controller]")]
    public class BarcodeController : Controller
    {
        private readonly IBarcodeService _barcodeService;
       
        public BarcodeController(IBarcodeService barcodeService)
        {
            _barcodeService = barcodeService;
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]IEnumerable<Product> products, [FromQuery] int user)
        {
            return _barcodeService.CreateBarcode(products, user);
        }
    }
}
