using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace big_foot.Data
{
    public class BigfootDbContext : IdentityDbContext<Customer>
    {
        public BigfootDbContext(DbContextOptions<BigfootDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}