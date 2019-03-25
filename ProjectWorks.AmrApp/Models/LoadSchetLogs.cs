using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LoadSchetLogs
    {
        public long Id { get; set; }
        public int FirmId { get; set; }
        public DateTime DateId { get; set; }
        public int? PointId { get; set; }
        public int? ContragentId { get; set; }
        public int? Contragent2Id { get; set; }
        public string DocNumber { get; set; }
        public int DocTypeId { get; set; }
        public int? ContractDid { get; set; }
        public int? ContractKid { get; set; }
        public int? StoreId { get; set; }
        public int? NomenclatureId { get; set; }
        public float Kol { get; set; }
        public float Schet1 { get; set; }
        public double Debet { get; set; }
        public float Schet2 { get; set; }
        public double Kredit { get; set; }
        public int AddUserId { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual LoadContracts ContractD { get; set; }
        public virtual LoadContracts ContractK { get; set; }
        public virtual LoadContragents Contragent { get; set; }
        public virtual LoadContragents Contragent2 { get; set; }
        public virtual LoadDocTypes DocType { get; set; }
        public virtual LoadFirms Firm { get; set; }
        public virtual Nomenclatures Nomenclature { get; set; }
        public virtual Object1 Point { get; set; }
        public virtual LoadStores Store { get; set; }
    }
}
