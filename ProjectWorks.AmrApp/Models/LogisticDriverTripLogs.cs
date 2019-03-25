using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LogisticDriverTripLogs
    {
        public int Id { get; set; }
        public int? AppUserId { get; set; }
        public DateTime Date { get; set; }
        public int StatusOnCenter { get; set; }
        public int? LogisticTripId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int CarId { get; set; }
        public string CarNumber { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual LogisticTrips LogisticTrip { get; set; }
    }
}
