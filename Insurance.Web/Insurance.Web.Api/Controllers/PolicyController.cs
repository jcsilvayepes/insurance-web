using Insurance.Web.Domain.Entities;
using Insurance.Web.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Insurance.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : DbControllerBase<PolicyEntity, PolicyRepository>
    {
        #region privates
        private readonly ILogger<PolicyController> _logger;
        #endregion
        public PolicyController(PolicyRepository repository, ILogger<PolicyController> logger) : base(repository)
        {
            _logger = logger;
        }
    }
}
