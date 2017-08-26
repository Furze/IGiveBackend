using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiveAShitBackend.Database.Models
{
    public class TransactionProducts
    {
        public int Id { get; set; }
        public  UserTransaction  UserTransaction{ get; set; }
        public Product Product { get; set; }
        public bool Assigned { get; set; }
    }
}
