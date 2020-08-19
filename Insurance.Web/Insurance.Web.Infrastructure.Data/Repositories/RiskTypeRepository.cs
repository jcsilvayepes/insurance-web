using Insurance.Web.Domain.Entities;

namespace Insurance.Web.Infrastructure.Data.Repositories
{
    public class RiskTypeRepository : RepositoryBase<RiskTypeEntity, InsuranceDBContext>
    {
        public RiskTypeRepository(InsuranceDBContext context) : base(context)
        {
        }
    }
}
