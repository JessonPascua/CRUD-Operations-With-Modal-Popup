using CRUD_Operations_With_Modal_Popup.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Operations_With_Modal_Popup.Data
{
    public class HealthCareDbContext : DbContext
    {
        public HealthCareDbContext(DbContextOptions<HealthCareDbContext> options)
            : base(options)
        {
        }
        public DbSet<Patients> Patients { get; set; } = default!;
        public DbSet<Physicians> Physicians { get; set; } = default!;
        public DbSet<Specializations> Specializations { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
