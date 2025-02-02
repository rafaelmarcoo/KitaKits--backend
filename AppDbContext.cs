using KitaKits__backend.Models;
using Microsoft.EntityFrameworkCore;

namespace KitaKits__backend
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
