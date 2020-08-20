using Insurance.Web.Domain.Entities;

namespace Insurance.Web.Infrastructure.Data.Repositories
{
    public class PolicyByClientRepository : RepositoryBase<PolicyByClientEntity, InsuranceDBContext>
    {
        public PolicyByClientRepository(InsuranceDBContext context) : base(context)
        {
        }
    }
}
