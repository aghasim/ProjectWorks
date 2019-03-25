using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RuleRoleBindles
    {
        public int RuleRoleBindleId { get; set; }
        public int AppFuncRoleId { get; set; }
        public int RuleId { get; set; }

        public virtual AppFuncRoles AppFuncRole { get; set; }
        public virtual Rules Rule { get; set; }
    }
}
