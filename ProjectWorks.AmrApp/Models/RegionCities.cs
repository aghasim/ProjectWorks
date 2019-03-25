using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RegionCities
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CityShort { get; set; }
        public int RegionOblId { get; set; }

        public virtual RegionObls RegionObl { get; set; }
    }
}
