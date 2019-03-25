using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class MatchingPriceSettings
    {
        public int MatchingPriceSettingId { get; set; }
        public int Obj { get; set; }
        public int Roles { get; set; }
        public int Admission { get; set; }
    }
}
