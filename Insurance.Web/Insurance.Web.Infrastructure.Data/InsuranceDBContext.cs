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
    }
}
