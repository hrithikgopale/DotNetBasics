

using CoreDbApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreDbApp1.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }   
    }
}

public DbSet <User> Users { get; set; }