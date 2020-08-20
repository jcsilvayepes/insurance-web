using Insurance.Web.Domain.Entities;

namespace Insurance.Web.Infrastructure.Data.Repositories
{
    public class PolicyRepository : RepositoryBase<PolicyEntity, InsuranceDBContext>
    {
        public PolicyRepository(InsuranceDBContext context) : base(context)
        {
        }
    }
}
