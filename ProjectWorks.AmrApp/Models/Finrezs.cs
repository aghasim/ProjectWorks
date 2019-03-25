using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Finrezs
    {
        public int Id { get; set; }
        public string Firm { get; set; }
        public decimal Margin { get; set; }
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }
        public decimal OtherProfits { get; set; }
        public decimal NetProfit { get; set; }
        public decimal CurrentCapital { get; set; }
        public decimal AverageCapital { get; set; }
        public decimal PreviousNetProfit { get; set; }
        public decimal YearlyProfitRate { get; set; }
        public decimal MonthlyProfitRate { get; set; }
        public decimal OverallMargin { get; set; }
        public int Month { get; set; }
    }
}
