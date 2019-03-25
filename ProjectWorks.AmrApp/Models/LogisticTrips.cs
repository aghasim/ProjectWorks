using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LogisticTrips
    {
        public LogisticTrips()
        {
            LogisticDriverSummaryItems = new HashSet<LogisticDriverSummaryItems>();
            LogisticDriverTripLogs = new HashSet<LogisticDriverTripLogs>();
        }

        public int Id { get; set; }
        public int TripType { get; set; }
        public int TripTonnage { get; set; }
        public int? PointInId { get; set; }
        public string PointInName { get; set; }
        public int? PointOutId { get; set; }
        public string PointOutName { get; set; }
        public int? PointUserId { get; set; }
        public string PointUserName { get; set; }
        public int TimeToTrip { get; set; }
        public int TripDistance { get; set; }
        public string TripComment { get; set; }
        public int? LogisticTripGroupId { get; set; }
        public int FacktOrPlan { get; set; }
        public bool IsDelete { get; set; }
        public int StatusRoute { get; set; }
        public int StatusOnCenter { get; set; }
        public int? LogisticRouteSheetId { get; set; }

        public virtual LogisticRouteSheets LogisticRouteSheet { get; set; }
        public virtual LogisticTripGroups LogisticTripGroup { get; set; }
        public virtual Object1 PointIn { get; set; }
        public virtual Object1 PointOut { get; set; }
        public virtual AppUsers PointUser { get; set; }
        public virtual ICollection<LogisticDriverSummaryItems> LogisticDriverSummaryItems { get; set; }
        public virtual ICollection<LogisticDriverTripLogs> LogisticDriverTripLogs { get; set; }
    }
}
