﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiveAShitBackend.Database.Models
{
    public class ProductAssignment
    {
        public enum Status { Pending, Cancelled, Complete} 

        public int Id { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public User DonatedBy { get; set; }
        public bool Completed { get; set; }
    }
}
