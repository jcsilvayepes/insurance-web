using Insurance.Web.Domain.Entities;

namespace Insurance.Web.Infrastructure.Data.Repositories
{
    public class ClientRepository : RepositoryBase<ClientEntity, InsuranceDBContext>
    {
        public ClientRepository(InsuranceDBContext context) : base(context)
        {
        }
    }
}
