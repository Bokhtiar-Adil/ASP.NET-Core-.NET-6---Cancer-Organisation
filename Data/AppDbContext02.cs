using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Data
{
    public class AppDbContext02 : DbContext
    {
        public AppDbContext02(DbContextOptions<AppDbContext02> options) : base(options) { }

        public DbSet<Doctors> DoctorsList { get; set; }
        public DbSet<TreatmentCenters> TreatmentCentersList { get; set; }
    }
}
