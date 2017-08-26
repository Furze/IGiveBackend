using System.Collections.Generic;

namespace GiveAShitBackend.Database.Models
{
    public class User
    {
        public User()
        {
            blackList = new List<Product>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string CardId { get; set; }
        public IEnumerable<Product> blackList { get; set; }
    }
}