using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class ChecklistFreeFines
    {
        public int FineId { get; set; }
        public int IdWhoFine { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal FineSum { get; set; }
        public string CauseFine { get; set; }
        public string WhomFineName { get; set; }
        public int AppUserId { get; set; }

        public virtual AppUsers AppUser { get; set; }
    }
}
