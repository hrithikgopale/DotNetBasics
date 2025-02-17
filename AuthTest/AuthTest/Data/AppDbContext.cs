using AuthTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthTest.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }

    }
}
