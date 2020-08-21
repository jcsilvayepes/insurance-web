using System.Collections.Generic;

namespace Insurance.Web.Mvc.Models.RiskViewModels
{
    public class RiskTypeListModel
    {
        public IEnumerable<RiskTypeViewModel> RiskTypes { get; set; }
    }
}
