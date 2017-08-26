using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiveAShitBackend.Database.Models
{
    public class ProductAssignment
    {
        public enum Status { Pending, Cancelled, Complete} 

        public int Id { get; set; }
        public User UserId { get; set; }
        public TransactionProducts Transaction { get; set; }
        public Status ProductStatus { get; set; }

    }
}
