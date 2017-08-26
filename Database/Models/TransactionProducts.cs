using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiveAShitBackend.Database.Models
{
    public class TransactionProducts
    {
        public int Id { get; set; }
        public  UserTransaction  UserTransactionId{ get; set; }
        public Product ProductId { get; set; }
        public bool Assigned { get; set; }
    }
}
