using Microsoft.EntityFrameworkCore;
using NonProfitSiteV3.Models;

namespace NonProfitSiteV3.Data
{
    public class AppDbContext03 : DbContext
    {
        public AppDbContext03(DbContextOptions<AppDbContext03> options) : base(options) { }

        public DbSet<Doctors> DoctorsList2 { get; set; } = default!;
        public DbSet<TreatmentCenters> TreatmentCentersList2 { get; set; } = default!;
    }
}
