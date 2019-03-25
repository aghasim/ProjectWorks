using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class MatchingPrices
    {
        public MatchingPrices()
        {
            MatchingPriceAccepts = new HashSet<MatchingPriceAccepts>();
        }

        public int MatchingPriceId { get; set; }
        public DateTime Date { get; set; }
        public int Biz { get; set; }
        public int ReceptionCenter { get; set; }
        public int Nomenclatura { get; set; }
        public double? Weight { get; set; }
        public double? Garbage { get; set; }
        public double? Price { get; set; }
        public int AppUserId { get; set; }
        public float? StandartPrice { get; set; }
        public int FilialId { get; set; }
        public float PriceDiff { get; set; }
        public string ImgPath { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual ICollection<MatchingPriceAccepts> MatchingPriceAccepts { get; set; }
    }
}
