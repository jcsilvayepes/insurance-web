using Insurance.Web.Domain.Entities;
using Insurance.Web.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Insurance.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiskTypeController : DbControllerBase<RiskTypeEntity, RiskTypeRepository>
    {
        #region privates
        private readonly ILogger<RiskTypeController> _logger;
        #endregion
        public RiskTypeController(RiskTypeRepository repository, ILogger<RiskTypeController> logger) : base(repository)
        {
            _logger = logger;
        }
    }
}
