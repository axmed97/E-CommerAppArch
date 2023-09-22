using Microsoft.EntityFrameworkCore;

namespace WebAPITest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Hero> Heroes { get; set; }
    }
}
