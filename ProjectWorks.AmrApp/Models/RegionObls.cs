using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RegionObls
    {
        public RegionObls()
        {
            RegionCities = new HashSet<RegionCities>();
        }

        public int Id { get; set; }
        public string OblName { get; set; }
        public string OblShort { get; set; }
        public int OblCode { get; set; }
        public int RegionLandId { get; set; }

        public virtual RegionLands RegionLand { get; set; }
        public virtual ICollection<RegionCities> RegionCities { get; set; }
    }
}
