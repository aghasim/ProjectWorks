using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LoadStat1C
    {
        public long Id { get; set; }
        public int FirmId { get; set; }
        public int? PointId { get; set; }
        public int? UserId { get; set; }
        public int? ContractDid { get; set; }
        public int? ContractKid { get; set; }
        public float Kol { get; set; }
        public double Debet { get; set; }
        public double Kredit { get; set; }
        public int DateYear { get; set; }
        public int DateMonth { get; set; }
        public int? BusinessId { get; set; }
        public int? ManagerId { get; set; }
        public DateTime? DateMax { get; set; }
        public double SummS { get; set; }

        public virtual PropertyValParams Business { get; set; }
        public virtual LoadContracts ContractD { get; set; }
        public virtual LoadContracts ContractK { get; set; }
        public virtual LoadFirms Firm { get; set; }
        public virtual AppUsers Manager { get; set; }
        public virtual Object1 Point { get; set; }
        public virtual AppUsers User { get; set; }
    }
}
