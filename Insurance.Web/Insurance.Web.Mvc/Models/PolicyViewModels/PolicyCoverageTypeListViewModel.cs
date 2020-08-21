using System.Collections.Generic;

namespace Insurance.Web.Mvc.Models.PolicyViewModels
{
    public class PolicyCoverageTypeListViewModel
    {
        public IEnumerable<PolicyCoverageTypeViewModel> PolicyCoverageTypes { get; set; }
    }
}
