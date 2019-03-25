using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class MacDuckAddedMoneys
    {
        public string Id { get; set; }
        public int CreatorId { get; set; }
        public DateTime Date { get; set; }
        public decimal Money { get; set; }
        public int PointId { get; set; }
        public int SourceId { get; set; }

        public virtual AppUsers Creator { get; set; }
        public virtual Object1 Point { get; set; }
        public virtual AppUsers Source { get; set; }
    }
}
