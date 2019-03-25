using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Rules
    {
        public Rules()
        {
            RuleApprovements = new HashSet<RuleApprovements>();
            RuleAwaranesses = new HashSet<RuleAwaranesses>();
            RuleObjectBindles = new HashSet<RuleObjectBindles>();
            RuleRoleBindles = new HashSet<RuleRoleBindles>();
        }

        public int RuleId { get; set; }
        public string RuleTxt { get; set; }
        public string RuleImgPath { get; set; }
        public string RulesKey { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public int RuleTypeId { get; set; }
        public int AppUserId { get; set; }
        public int FilialId { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual RuleTypes RuleType { get; set; }
        public virtual ICollection<RuleApprovements> RuleApprovements { get; set; }
        public virtual ICollection<RuleAwaranesses> RuleAwaranesses { get; set; }
        public virtual ICollection<RuleObjectBindles> RuleObjectBindles { get; set; }
        public virtual ICollection<RuleRoleBindles> RuleRoleBindles { get; set; }
    }
}
