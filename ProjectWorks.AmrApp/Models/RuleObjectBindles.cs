using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RuleObjectBindles
    {
        public int RuleObjectBindleId { get; set; }
        public int RuleId { get; set; }
        public int ObjectTypeId { get; set; }

        public virtual ObjectTypes ObjectType { get; set; }
        public virtual Rules Rule { get; set; }
    }
}
