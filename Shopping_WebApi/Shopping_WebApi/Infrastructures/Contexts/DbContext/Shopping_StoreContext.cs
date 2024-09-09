using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Infrastructure.Data.DbContext
{
    public class Shopping_StoreContext(DbContextOptions<Shopping_StoreContext> options) : IdentityDbContext<User>(options)
    {
        public override DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<StoreManager> StoreManagers { get; set; }
        public DbSet<SystemManager> SystemManagers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Cart_Product> CartProducts { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Comment> comments { get; set; }


        public DbSet<Category> Categories { get; set; }
        public DbSet<DigitalProduct> DigitalProducts { get; set; }
        public DbSet<PhysicalProduct> PhysicalProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Cart)
                .WithOne(c => c.Customer)
                .HasForeignKey<Cart>(c => c.CustomerId);


            modelBuilder.Entity<Comment>()
                .HasQueryFilter(c => !c.IsDeleted);




        }
    }
}
