using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Data
{
    public class AppDbContext01 : DbContext
    {
        public AppDbContext01(DbContextOptions<AppDbContext01> options) : base(options) { }

        public DbSet<FinancialAid> FinancialAidTable { get; set; } = default!;
        public DbSet<BloodDoner> BloodDonerTable { get; set; } = default!;
        public DbSet<VolunteerRequest> VolunteerReqTable { get; set; } = default!;
        public DbSet<NonProfitSiteV3.Models.Doctors>? Doctors { get; set; }
    }
}
