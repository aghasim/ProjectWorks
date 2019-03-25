using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LoadRevisionOks
    {
        public long Id { get; set; }
        public int FirmId { get; set; }
        public DateTime DateId { get; set; }
        public int? ContrId { get; set; }
        public string DocNumber { get; set; }
        public int DocTypeId { get; set; }
        public int? ContractId { get; set; }
        public int? NomenclatureId { get; set; }
        public float Kol { get; set; }
        public double Debet { get; set; }
        public double Kredit { get; set; }
        public int AddUserId { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual Object1 Contr { get; set; }
        public virtual LoadContracts Contract { get; set; }
        public virtual LoadDocTypes DocType { get; set; }
        public virtual LoadFirms Firm { get; set; }
        public virtual Nomenclatures Nomenclature { get; set; }
    }
}
