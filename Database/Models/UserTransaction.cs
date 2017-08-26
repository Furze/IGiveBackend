using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiveAShitBackend.Database.Models
{
    public class UserTransaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string BarCode { get; set; }
        public DateTime Date { get; set; }
        public String Location { get; set; }
    }
}
