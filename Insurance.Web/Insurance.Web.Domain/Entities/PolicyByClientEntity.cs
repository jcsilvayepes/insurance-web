using Insurance.Web.Domain.Contracts.Core;

namespace Insurance.Web.Domain.Entities
{
    public class PolicyByClientEntity : IEntity
    {
        public int Id { get; set; }
        public ClientEntity Client { get; set; }
        public PolicyEntity Policy { get; set; }
    }
}
