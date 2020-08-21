using Insurance.Web.Mvc.Application.Contracts;
using Insurance.Web.Mvc.Models.PolicyViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Insurance.Web.Mvc.Controllers
{
    public class PolicyController : Controller
    {
        private readonly IPolicyService _policyService;

        public PolicyController(IPolicyService policyService)
        {
            _policyService = policyService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create(PolicyViewModel policyViewModel)
        {
            if(policyViewModel == null || string.IsNullOrEmpty(policyViewModel.Name))
                return View();

            if (policyViewModel.RiskType.Id == 4 && policyViewModel.PercentageCoverage < 0.5)
            {
                if (await _policyService.CreateAsync(policyViewModel))
                    return View();
            }

            return View();
        }

    }
}
