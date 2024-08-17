using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Shopping_WebApi.Models;

namespace Shopping_WebApi.Data
{
    public class Shopping_StoreContext(DbContextOptions<Shopping_StoreContext> options) : IdentityDbContext<User>(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> RegularUsers { get; set; }
        public DbSet<StoreManager> StoreManagers { get; set; }
        public DbSet<SystemManager> SystemManagers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }


        public DbSet<Category> Categories { get; set; }
        public DbSet<DigitalProduct> DigitalProducts { get; set; }
        public DbSet<PhysicalProduct> PhysicalProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Cart)
                .WithOne(c => c.Owner)
                .HasForeignKey<Cart>(c => c.CustomerId);







        }
    }
}
