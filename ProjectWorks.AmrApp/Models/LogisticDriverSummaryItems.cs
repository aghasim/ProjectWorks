using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LogisticDriverSummaryItems
    {
        public int Id { get; set; }
        public int? DriverId { get; set; }
        public int? Object1Id { get; set; }
        public int? LogisticTripId { get; set; }
        public string PriemName { get; set; }
        public int? PointId { get; set; }
        public int Brutno { get; set; }
        public int Netto { get; set; }
        public int Zasor { get; set; }
        public int Zasor2 { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public string FilePath1 { get; set; }
        public string FilePath2 { get; set; }
        public string FilePath3 { get; set; }
        public int Status { get; set; }

        public virtual AppUsers Driver { get; set; }
        public virtual LogisticTrips LogisticTrip { get; set; }
        public virtual Object1 Object1 { get; set; }
        public virtual Object1 Point { get; set; }
    }
}
