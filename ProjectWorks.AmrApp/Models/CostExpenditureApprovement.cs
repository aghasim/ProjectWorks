using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CostExpenditureApprovement
    {
        public int CostApprovementId { get; set; }
        public DateTime AproveDate { get; set; }
        public int Object1Id { get; set; }
        public int AppUserId { get; set; }
        public bool IsAprovement { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual Object1 Object1 { get; set; }
    }
}
