using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PointReportMoneys
    {
        public long Id { get; set; }
        public DateTime DateId { get; set; }
        public int FilialId { get; set; }
        public int Object1Id { get; set; }
        public long PlusMoney { get; set; }
        public long TotalMoney { get; set; }
        public long OrderMoney { get; set; }
        public long NeedMoney { get; set; }
        public int? ManagerId { get; set; }
        public int AddUserId { get; set; }
        public long MinusMoney { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual AppUsers Manager { get; set; }
        public virtual Object1 Object1 { get; set; }
    }
}
