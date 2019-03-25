using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RuleTypes
    {
        public RuleTypes()
        {
            Rules = new HashSet<Rules>();
        }

        public int RuleTypeId { get; set; }
        public string RuleTypeName { get; set; }
        public int FilialId { get; set; }

        public virtual ICollection<Rules> Rules { get; set; }
    }
}
