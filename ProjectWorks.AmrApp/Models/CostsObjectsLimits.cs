using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CostsObjectsLimits
    {
        public int CostsObjectsLimitId { get; set; }
        public int ExpenditureId { get; set; }
        public int Object1Id { get; set; }
        public int Limit { get; set; }

        public virtual Object1 Object1 { get; set; }
    }
}
