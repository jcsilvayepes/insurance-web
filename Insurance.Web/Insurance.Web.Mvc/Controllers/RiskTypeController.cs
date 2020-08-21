using Insurance.Web.Mvc.Application.Contracts;
using Insurance.Web.Mvc.Models.RiskViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Insurance.Web.Mvc.Controllers
{

    public class RiskTypeController : Controller
    {
        private readonly IRiskTypeService _service;

        public RiskTypeController(IRiskTypeService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<RiskTypeViewModel> data = default(List<RiskTypeViewModel>);
            data = await _service.GetAllAsync();

            return await Task.FromResult(View(new RiskTypeListModel
            {
                RiskTypes = data
            }));

        }
    }
}
