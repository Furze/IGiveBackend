using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiveAShitBackend.Database.Models;
using GiveAShitBackend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GiveAShitBackend.Controllers
{
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {
        private readonly IDonationService _donationService;
       
        public TransactionController(IDonationService donationService)
        {
            _donationService = donationService;
        }

        [HttpPost]
        public string Post([FromBody]Object stupidEndpoint, [FromQuery] int user)
        {
            if (stupidEndpoint is string)
            {
                return _donationService.RedemItems((string) stupidEndpoint);               
            }
            else
            {
               return _donationService.GiveItems((IEnumerable<Product>) stupidEndpoint, user);
            }
        }
    }
}
