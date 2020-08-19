using Insurance.Web.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.Web.Infrastructure.Data.Repositories
{
    public class InsuranceCoverageTypeRepository : RepositoryBase<PolicyCoverageTypeEntity, InsuranceDBContext>
    {
        public InsuranceCoverageTypeRepository(InsuranceDBContext context) : base(context)
        {
        }
    }
}
