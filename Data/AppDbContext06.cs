using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Data
{
    public class AppDbContext06 : DbContext
    {
        public AppDbContext06(DbContextOptions<AppDbContext06> options) : base(options) { }

        public DbSet<VolunteerRegistered> RegisteredVolunteerTable { get; set; } = default!;
    }
}
