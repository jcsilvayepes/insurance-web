using Insurance.Web.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.Web.Infrastructure.Data.Repositories
{
    public class PolicyCoverageTypeRepository : RepositoryBase<PolicyCoverageTypeEntity, InsuranceDBContext>
    {
        public PolicyCoverageTypeRepository(InsuranceDBContext context) : base(context)
        {
        }
    }
}
