using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insurance.Web.Mvc.Models.PolicyViewModels
{
    public class CoverageByPolicyViewModel
    {
        public int Id { get; set; }
        public int PolicyCoverageTypeId { get; set; }
        public int InsuranceId { get; set; }
        public virtual PolicyCoverageTypeViewModel PolicyCoverageType { get; set; }
    }
}
