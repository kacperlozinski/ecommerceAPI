using Microsoft.EntityFrameworkCore;

namespace ecommerceAPI.Entities
{
    public class EcommerceDbContext : DbContext
    {
        private string _connectionString = "Server=localhost,1433;Database=Ecommerce;User Id=sa;Password=Kacper123;TrustServerCertificate=True;";
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
