using Microsoft.EntityFrameworkCore;

namespace Ghazal.Models
{
    public class GhazalContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductImg> ProductImgs { get; set; }
        public DbSet<ImageMap> ImageMaps { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<WishList> Wishlists { get; set; }
        public DbSet<WishListItem> WishlistItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }




        public GhazalContext() : base() 
        { 
        }
        //public GhazalContext(DbContextOptions<GhazalContext> options)
        //: base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;port=3306;user=root;password=root;database=ghazalfinal",
                new MySqlServerVersion(new Version(9, 0, 0)) 
            );

            base.OnConfiguring(optionsBuilder);
        }
    }
}
