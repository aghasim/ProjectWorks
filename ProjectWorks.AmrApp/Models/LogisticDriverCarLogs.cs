using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LogisticDriverCarLogs
    {
        public int Id { get; set; }
        public int? AppUserId { get; set; }
        public DateTime Date { get; set; }
        public int StatusTehnicalAvto { get; set; }
        public int? Object1Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual Object1 Object1 { get; set; }
    }
}
