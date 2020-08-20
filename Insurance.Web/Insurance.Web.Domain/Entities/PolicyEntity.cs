using Insurance.Web.Domain.Contracts.Core;

namespace Insurance.Web.Domain.Entities
{
    public class PolicyEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PolicyCoverageTypeEntity PolicyCoverageType { get; set; }
        public int Validity { get; set; }
        public int Coverage { get; set; }
        public double PolicyPrice { get; set; }
        public RiskTypeEntity RiskType { get; set; }

    }
}
