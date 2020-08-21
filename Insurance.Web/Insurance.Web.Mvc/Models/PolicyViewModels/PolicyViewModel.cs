using Insurance.Web.Mvc.Models.RiskViewModels;
using System.Collections.Generic;

namespace Insurance.Web.Mvc.Models.PolicyViewModels
{
    public class PolicyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Validity { get; set; }
        public double PolicyPrice { get; set; }
        public double PercentageCoverage { get; set; }
        public int RiskType { get; set; }
        public ICollection<CoverageByPolicyViewModel> CoverageByPolicy { get; set; }

    }
}
