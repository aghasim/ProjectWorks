using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LogisticDriverLogs
    {
        public int Id { get; set; }
        public int? AppUserId { get; set; }
        public DateTime Date { get; set; }
        public int DriverStateEnum { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int? CarId { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual Object1 Car { get; set; }
    }
}
