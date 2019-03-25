using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RuleApprovements
    {
        public int RuleApprovementId { get; set; }
        public DateTime ApprovementDate { get; set; }
        public bool IsApprovement { get; set; }
        public int RuleId { get; set; }
        public int AppUserId { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual Rules Rule { get; set; }
    }
}
