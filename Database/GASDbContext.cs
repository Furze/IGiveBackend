using GiveAShitBackend.Database.Models;
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
        public virtual DbSet<ProductAssignment>ProductAssignments {get;set;}
        public virtual DbSet<ProductCategory>ProductCategories { get; set; }
        public virtual DbSet<TransactionProducts> TransactionProducts { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<UserTransaction> UserTransactions { get; set; }
        public virtual DbSet<Barcode> Barcodes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}