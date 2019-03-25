using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class FlowOfFunds
    {
        public int FlowOfFundId { get; set; }
        public DateTime Date { get; set; }
        public int FromWhom { get; set; }
        public int? ToWhom { get; set; }
        public int Vid { get; set; }
        public double In { get; set; }
        public double Out { get; set; }
        public int Status { get; set; }
        public double Summa { get; set; }
        public string Comments { get; set; }
        public string Confirmation { get; set; }
        public DateTime? DateConfirmation { get; set; }
        public int FilialId { get; set; }
    }
}
