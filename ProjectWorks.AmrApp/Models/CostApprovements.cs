using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CostApprovements
    {
        public int CostApprovementId { get; set; }
        public DateTime AproveDate { get; set; }
        public int CostId { get; set; }
        public int AppUserId { get; set; }
        public bool IsAprove { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual Costs Cost { get; set; }
    }
}
