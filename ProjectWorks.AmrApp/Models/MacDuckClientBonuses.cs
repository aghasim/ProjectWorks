using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class MacDuckClientBonuses
    {
        public string Id { get; set; }
        public int BusinessTypeId { get; set; }
        public string ClientId { get; set; }
        public int CreatorId { get; set; }
        public DateTime Date { get; set; }
        public int PointId { get; set; }
        public int Type { get; set; }
        public double Value { get; set; }

        public virtual MacDuckClients Client { get; set; }
        public virtual AppUsers Creator { get; set; }
        public virtual Object1 Point { get; set; }
    }
}
