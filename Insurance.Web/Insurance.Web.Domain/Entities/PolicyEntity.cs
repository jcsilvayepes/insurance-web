using Insurance.Web.Domain.Contracts.Core;

namespace Insurance.Web.Domain.Entities
{
    public class PolicyEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PolicyCoverageTypeEntity InsuranceCoverageType { get; set; }
        public int Validity { get; set; }
        public int CoverageMonth { get; set; }
        public double InsurancePrice { get; set; }
        public RiskTypeEntity RiskType { get; set; }

    }
}
