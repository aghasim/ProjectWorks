using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LogisticDisposableCars
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string NameCar { get; set; }
        public int TonnagCar { get; set; }
        public string GodCar { get; set; }
        public int TypeCarId { get; set; }
        public int PriceCar { get; set; }
    }
}
