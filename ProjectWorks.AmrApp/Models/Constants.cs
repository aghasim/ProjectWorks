using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Constants
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public double VariablesPerTon { get; set; }
        public double Permanents { get; set; }
        public double OtherRevenuesMinusExpenses { get; set; }
        public double AvgCapitalYear { get; set; }
        public double ProfitBeginningYear { get; set; }
        public double GrossMargin { get; set; }
        public double VolumeLcm { get; set; }
        public double MarginLcm { get; set; }
        public double VolumeLchm { get; set; }
        public double MarginLchm { get; set; }
        public double VolumeRzm { get; set; }
        public double MarginRzm { get; set; }
        public double VolumeKatanka { get; set; }
        public double MarginKatanka { get; set; }
        public double VolumeKatod { get; set; }
        public double MarginKatod { get; set; }
        public double MonthsPassed { get; set; }
    }
}
