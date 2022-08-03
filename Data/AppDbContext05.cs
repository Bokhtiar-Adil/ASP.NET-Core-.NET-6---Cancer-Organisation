using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Data
{
    public class AppDbContext05 : DbContext
    {
        public AppDbContext05(DbContextOptions<AppDbContext05> options) : base(options) { }

        public DbSet<VolunteerApplicants> VolAppTable { get; set; } = default!;
    }
}
