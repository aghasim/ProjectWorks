using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class MatchingPriceAccepts
    {
        public int MatchingPriceAcceptId { get; set; }
        public int MatchingPriceId { get; set; }
        public int AppUserId { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public DateTime AcceptDate { get; set; }
        public string Comment { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual MatchingPrices MatchingPrice { get; set; }
    }
}
