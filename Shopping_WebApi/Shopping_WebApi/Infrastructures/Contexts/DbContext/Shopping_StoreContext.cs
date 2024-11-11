using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Infrastructure.Data.DbContext
{
    public class Shopping_StoreContext : IdentityDbContext<User>
    {
        public Shopping_StoreContext(DbContextOptions<Shopping_StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<StoreManager> StoreManagers { get; set; }
        public DbSet<SystemManager> SystemManagers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DigitalProduct> DigitalProducts { get; set; }
        public DbSet<PhysicalProduct> PhysicalProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Cart)
                .WithOne(cart => cart.Customer)
                .HasForeignKey<Cart>(cart => cart.CustomerId);

            
            modelBuilder.Entity<Comment>()
                .HasQueryFilter(comment => !comment.IsDeleted);

            
            modelBuilder.Entity<User>()
                .Property(u => u.FirstName)
                .IsRequired(); 

          
        }
    }
}
