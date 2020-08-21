﻿using Insurance.Web.Domain.Contracts.Core;
using System.Collections.Generic;

namespace Insurance.Web.Domain.Entities
{
    public class PolicyEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Validity { get; set; }
        public double PolicyPrice { get; set; }
        public RiskTypeEntity RiskType { get; set; }
        public double PercentageCoverage { get; set; }
        public ICollection<CoverageByPolicy> CoverageByPolicy { get; set; }

    }
}
