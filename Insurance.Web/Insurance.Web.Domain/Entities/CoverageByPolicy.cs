using Insurance.Web.Domain.Contracts.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance.Web.Domain.Entities
{
    public class CoverageByPolicy : IEntity
    {
        public int Id { get; set; }
        public int PolicyCoverageTypeId { get; set; }
        public int InsuranceId { get; set; }
        public virtual PolicyCoverageTypeEntity PolicyCoverageType { get; set; }
    }
}
