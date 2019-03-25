using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LogisticRouteSheetsGroups
    {
        public LogisticRouteSheetsGroups()
        {
            LogisticRouteSheets = new HashSet<LogisticRouteSheets>();
        }

        public int LogisticRouteSheetsGroupId { get; set; }
        public DateTime Date { get; set; }
        public int? FilialId { get; set; }
        public int? Status { get; set; }

        public virtual Filials Filial { get; set; }
        public virtual ICollection<LogisticRouteSheets> LogisticRouteSheets { get; set; }
    }
}
