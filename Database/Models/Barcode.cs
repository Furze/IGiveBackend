﻿using System.Collections.Generic;

namespace GiveAShitBackend.Database.Models
{
    public class Barcode
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public IEnumerable<ProductAssignment> Products { get; set; } 
        public User User { get; set; }
    }
}