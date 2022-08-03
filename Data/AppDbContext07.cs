using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Data
{
    public class AppDbContext07 : DbContext
    {
        public AppDbContext07(DbContextOptions<AppDbContext07> options) : base(options) { }

        public DbSet<Events> EventsTable { get; set; } = default!;
    }
}
