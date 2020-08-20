using Insurance.Web.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Web.Infrastructure.Data
{
    public class InsuranceDBContext : DbContext
    {
        public DbSet<PolicyEntity> Insurances { get; set; }
        public InsuranceDBContext(DbContextOptions<InsuranceDBContext> options) : base(options)
        {

        }

        #region Seedings
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<RiskTypeEntity>().HasData(
                 new RiskTypeEntity
                 {
                     Id = 1,
                     Description = "Low"
                 },
                 new RiskTypeEntity
                 {
                     Id = 2,
                     Description = "Mid"
                 },
                 new RiskTypeEntity
                 {
                     Id = 3,
                     Description = "Mid-low"
                 },
                 new RiskTypeEntity
                 {
                     Id = 4,
                     Description = "High"
                 }

                );

            modelBuilder.Entity<PolicyCoverageTypeEntity>().HasData(
                new PolicyCoverageTypeEntity
                {
                    Id = 1,
                    Description = "Earthquake"
                },
                new PolicyCoverageTypeEntity
                {
                    Id = 2,
                    Description = "Fire"
                },
                new PolicyCoverageTypeEntity
                {
                    Id = 3,
                    Description = "Theft"
                },
                new PolicyCoverageTypeEntity
                {
                    Id = 4,
                    Description = "Loss"
                }
                );
        }
        #endregion

    }
}
