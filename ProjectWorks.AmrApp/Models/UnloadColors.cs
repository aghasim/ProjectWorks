using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class UnloadColors
    {
        public int Id { get; set; }
        public int? DaysCountForPastDate { get; set; }
        public string ColorPastDate { get; set; }
        public int? DaysCountForNonPayments { get; set; }
        public string ColorNonPaymentsInDays { get; set; }
        public DateTime? DefinedDate { get; set; }
        public string ColorDefinedDate { get; set; }
        public int Type { get; set; }
    }
}
