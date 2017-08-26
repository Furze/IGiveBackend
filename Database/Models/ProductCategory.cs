using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiveAShitBackend.Database.Models
{
    public class ProductCategory
    {
        public enum ProductType { Fruit, Vegetables, Bakery, Meat}

        public int Id { get; set; }
        public Product Product{ get; set; }
        public ProductType Type { get; set; }
    }
}
