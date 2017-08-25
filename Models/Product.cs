﻿using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace GiveAShitBackend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Barcode { get; set; }
    }
}