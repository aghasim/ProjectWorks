using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LoadOsvs
    {
        public long Id { get; set; }
        public int FirmId { get; set; }
        public int? PointId { get; set; }
        public DateTime DateId { get; set; }
        public double DebetStart { get; set; }
        public double KreditStart { get; set; }
        public double Debet { get; set; }
        public double Kredit { get; set; }
        public double DebetEnd { get; set; }
        public double KreditEnd { get; set; }
        public int AddUserId { get; set; }
        public int? ContractId { get; set; }
        public int? ContragentId { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual LoadContracts Contract { get; set; }
        public virtual LoadContragents Contragent { get; set; }
        public virtual LoadFirms Firm { get; set; }
        public virtual Object1 Point { get; set; }
    }
}
