using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Data
{
    public class AppDbContext04 : DbContext
    {
        public AppDbContext04(DbContextOptions<AppDbContext04> options) : base(options) { }

        public DbSet<Donation> DonationTable { get; set; } = default!;
    }
}
