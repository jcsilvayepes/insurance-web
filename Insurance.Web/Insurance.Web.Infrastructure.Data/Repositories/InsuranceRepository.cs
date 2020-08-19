using Insurance.Web.Domain.Entities;

namespace Insurance.Web.Infrastructure.Data.Repositories
{
    public class InsuranceRepository : RepositoryBase<PolicyEntity, InsuranceDBContext>
    {
        public InsuranceRepository(InsuranceDBContext context) : base(context)
        {
        }
    }
}
