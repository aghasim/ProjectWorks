using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RegionLands
    {
        public RegionLands()
        {
            RegionObls = new HashSet<RegionObls>();
        }

        public int Id { get; set; }
        public string LandName { get; set; }
        public string LandShort { get; set; }

        public virtual ICollection<RegionObls> RegionObls { get; set; }
    }
}
