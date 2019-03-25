using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PointPlans
    {
        public long Id { get; set; }
        public int FilialId { get; set; }
        public int DateYear { get; set; }
        public int DateMonth { get; set; }
        public int Object1Id { get; set; }
        public int BusinessId { get; set; }
        public int? NomGrpId { get; set; }
        public long Plan { get; set; }
        public int AddUserId { get; set; }
        public int? ManagerId { get; set; }
        public bool Signed { get; set; }

        public virtual PropertyValParams Business { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual AppUsers Manager { get; set; }
        public virtual Object1 NomGrp { get; set; }
        public virtual Object1 Object1 { get; set; }
    }
}
