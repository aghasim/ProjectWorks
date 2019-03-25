using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LogisticRouteSheets
    {
        public LogisticRouteSheets()
        {
            LogisticTripGroups = new HashSet<LogisticTripGroups>();
            LogisticTrips = new HashSet<LogisticTrips>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CarId { get; set; }
        public int TypeCarId { get; set; }
        public int Status { get; set; }
        public int? LogisticRouteSheetsGroupId { get; set; }
        public int? FilialId { get; set; }
        public string StatusComment { get; set; }
        public int FacktOrPlan { get; set; }

        public virtual Object1 Car { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual LogisticRouteSheetsGroups LogisticRouteSheetsGroup { get; set; }
        public virtual ICollection<LogisticTripGroups> LogisticTripGroups { get; set; }
        public virtual ICollection<LogisticTrips> LogisticTrips { get; set; }
    }
}
