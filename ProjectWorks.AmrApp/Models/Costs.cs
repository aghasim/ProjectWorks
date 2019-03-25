using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Costs
    {
        public Costs()
        {
            CostApprovements = new HashSet<CostApprovements>();
        }

        public int CostId { get; set; }
        public string CostTitle { get; set; }
        public decimal Sum { get; set; }
        public DateTime CreateDate { get; set; }
        public int CostPerType { get; set; }
        public string Comment { get; set; }
        public string PhotoPath { get; set; }
        public bool IsDeleted { get; set; }
        public int AppUserId { get; set; }
        public int Object1Id { get; set; }
        public int CostType { get; set; }
        public int? BindleUserId { get; set; }
        public int? BindleObjId { get; set; }
        public int? BindleDepId { get; set; }
        public int FilialId { get; set; }
        public bool IsOverrun { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual Object1 Object1 { get; set; }
        public virtual ICollection<CostApprovements> CostApprovements { get; set; }
    }
}
