using EntityMetrodicFitness.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBMatrodicFitness.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        
    }
}
