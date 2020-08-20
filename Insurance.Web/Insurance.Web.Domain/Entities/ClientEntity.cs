using Insurance.Web.Domain.Contracts.Core;

namespace Insurance.Web.Domain.Entities
{
    public class ClientEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
