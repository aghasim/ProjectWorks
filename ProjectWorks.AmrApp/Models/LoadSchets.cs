using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LoadSchets
    {
        public long Id { get; set; }
        public int FirmId { get; set; }
        public DateTime DateId { get; set; }
        public int? PointId { get; set; }
        public string DocNumber { get; set; }
        public int DocTypeId { get; set; }
        public int? NomenclatureId { get; set; }
        public float Kol { get; set; }
        public float Schet1 { get; set; }
        public double Debet { get; set; }
        public float Schet2 { get; set; }
        public double Kredit { get; set; }
        public int AddUserId { get; set; }
        public int? ContractDid { get; set; }
        public int? ContractKid { get; set; }
        public int? StoreId { get; set; }
        public string Comment { get; set; }
        public int? ContragentId { get; set; }
        public int? Contragent2Id { get; set; }
        public int? UserId { get; set; }
        public int DateYear { get; set; }
        public int DateMonth { get; set; }
        public int? BusinessId { get; set; }
        public int? ManagerId { get; set; }
        public float PriceS { get; set; }
        public double SummS { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual PropertyValParams Business { get; set; }
        public virtual LoadContracts ContractD { get; set; }
        public virtual LoadContracts ContractK { get; set; }
        public virtual LoadContragents Contragent { get; set; }
        public virtual LoadContragents Contragent2 { get; set; }
        public virtual LoadDocTypes DocType { get; set; }
        public virtual LoadFirms Firm { get; set; }
        public virtual AppUsers Manager { get; set; }
        public virtual Nomenclatures Nomenclature { get; set; }
        public virtual Object1 Point { get; set; }
        public virtual LoadStores Store { get; set; }
        public virtual AppUsers User { get; set; }
    }
}
