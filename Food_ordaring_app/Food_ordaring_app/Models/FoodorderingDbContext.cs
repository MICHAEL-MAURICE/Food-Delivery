using Food_ordaring_app.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace food_ordering_app.Models
{
    public class FoodorderingDbContext:IdentityDbContext
    {


        public virtual DbSet<AppUser> Users{ get; set; }

        public virtual DbSet<Product> Products{ get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<ProductOrder> ProductOrder { get; set; }
        public FoodorderingDbContext(DbContextOptions<FoodorderingDbContext> options) : base(options)
        {
        }

    }
}
