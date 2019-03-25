using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Reitings
    {
        public int Id { get; set; }
        public string Firm { get; set; }
        public int ReitingType { get; set; }
        public int Month { get; set; }
        public int Scope { get; set; }
        public string BisType { get; set; }
        public int Year { get; set; }
    }
}
