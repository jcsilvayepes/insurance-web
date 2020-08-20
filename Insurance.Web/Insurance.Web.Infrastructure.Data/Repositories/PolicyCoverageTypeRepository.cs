using Insurance.Web.Domain.Entities;

namespace Insurance.Web.Infrastructure.Data.Repositories
{
    public class PolicyCoverageTypeRepository : RepositoryBase<PolicyCoverageTypeEntity, InsuranceDBContext>
    {
        public PolicyCoverageTypeRepository(InsuranceDBContext context) : base(context)
        {
        }
    }
}
