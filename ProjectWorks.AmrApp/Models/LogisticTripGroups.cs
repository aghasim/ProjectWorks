using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LogisticTripGroups
    {
        public LogisticTripGroups()
        {
            LogisticTrips = new HashSet<LogisticTrips>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? LogisticRouteSheetId { get; set; }
        public int FacktOrPlan { get; set; }
        public string PointOfDischarge { get; set; }
        public bool IsDelete { get; set; }
        public int StatusRoute { get; set; }

        public virtual LogisticRouteSheets LogisticRouteSheet { get; set; }
        public virtual AppUsers User { get; set; }
        public virtual ICollection<LogisticTrips> LogisticTrips { get; set; }
    }
}
