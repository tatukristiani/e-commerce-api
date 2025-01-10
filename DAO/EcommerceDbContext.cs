using EcommerceAPI.DAO.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.DAO
{
    public class EcommerceDbContext : DbContext
    {
        private readonly IConfiguration _config;
        public EcommerceDbContext(IConfiguration config)
        {
            _config = config;
        }

        public DbSet<User> users { get; set; }

        public DbSet<Role> roles { get; set; }

        public DbSet<Order> orders { get; set; }
        public DbSet<Shipment> shipments { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<OrderLine> orderlines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder bldr)
        {
            base.OnConfiguring(bldr);

            bldr.UseNpgsql(_config.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure OrderLine as a keyless entity
            modelBuilder.Entity<OrderLine>()
                .HasNoKey()
                .ToTable("orderlines");
        }
    }
}
