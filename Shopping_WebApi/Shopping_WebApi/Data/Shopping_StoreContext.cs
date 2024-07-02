using Microsoft.EntityFrameworkCore;
using Shopping_WebApi.Models; 

namespace Shopping_WebApi.Data
{
    public class Shopping_StoreContext : DbContext
    {
        public Shopping_StoreContext(DbContextOptions<Shopping_StoreContext> options)
            : base(options)
        {}
        public DbSet<User> Users { get; set; } 
        public DbSet<RegularUser> RegularUsers { get; set; } 
        public DbSet<StoreManager> StoreManagers { get; set; } 
        public DbSet<SystemManager> SystemManagers { get; set; } 
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; } 
        public DbSet<Cart> Carts { get; set; } 

        
        public DbSet<Category> Categories { get; set; }
        public DbSet<DigitalProduct> DigitalProducts { get; set; }
        public DbSet<PhysicalProduct> PhysicalProducts { get; set; }

        

        
    }
}
