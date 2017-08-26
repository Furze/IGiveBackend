﻿using GiveAShitBackend.Database.Models;
using Microsoft.EntityFrameworkCore;


namespace GiveAShitBackend.Database
{
    public class GASDbContext : DbContext
    {
        public GASDbContext(DbContextOptions<GASDbContext> options) : base(options)
        {
        }
       
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}