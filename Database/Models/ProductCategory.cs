using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiveAShitBackend.Database.Models
{
    public class ProductCategory
    {
        public enum ProductType { Fruit, Vegetables, Bakery, Meat}


        public Product ProductId { get; set; }
        public ProductType Type { get; set; }
    }
}
