using Insurance.Web.Domain.Contracts.Core;

namespace Insurance.Web.Domain.Entities
{
    public class RiskTypeEntity : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
