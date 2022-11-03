using Microsoft.EntityFrameworkCore;
using apiweb.Entities;
using Microsoft.AspNetCore.Identity;

namespace apiweb.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
