using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PriceTypes
    {
        public PriceTypes()
        {
            PriceListDocs = new HashSet<PriceListDocs>();
            PriceListFirsts = new HashSet<PriceListFirsts>();
            PriceListIndependents = new HashSet<PriceListIndependents>();
            PriceListSeconds = new HashSet<PriceListSeconds>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsGlobal { get; set; }
        public bool NotDel { get; set; }
        public int? AddUserId { get; set; }
        public string AddUserIp { get; set; }

        public virtual ICollection<PriceListDocs> PriceListDocs { get; set; }
        public virtual ICollection<PriceListFirsts> PriceListFirsts { get; set; }
        public virtual ICollection<PriceListIndependents> PriceListIndependents { get; set; }
        public virtual ICollection<PriceListSeconds> PriceListSeconds { get; set; }
    }
}
