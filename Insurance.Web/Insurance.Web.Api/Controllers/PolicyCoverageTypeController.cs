using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insurance.Web.Domain.Entities;
using Insurance.Web.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Insurance.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyCoverageTypeController : DbControllerBase<PolicyCoverageTypeEntity, PolicyCoverageTypeRepository>
    {
        #region privates
        private readonly ILogger<PolicyCoverageTypeController> _logger;
        #endregion
        public PolicyCoverageTypeController(PolicyCoverageTypeRepository repository, ILogger<PolicyCoverageTypeController> logger) : base(repository)
        {
            _logger = logger;
        }
    }
}
