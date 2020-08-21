using Insurance.Web.Mvc.Application.Contracts;
using Insurance.Web.Mvc.Models.PolicyViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Insurance.Web.Mvc.Controllers
{
    public class CoverageTypeController : Controller
    {
        private readonly IPolicyCoverageTypeService _service;

        public CoverageTypeController(IPolicyCoverageTypeService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<PolicyCoverageTypeViewModel> data = default(List<PolicyCoverageTypeViewModel>);

            data = await _service.GetAllAsync();

            return await Task.FromResult(View(new PolicyCoverageTypeListViewModel
            {
                 PolicyCoverageTypes = data
            }));
        }
    }
}
