using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Realizations
    {
        public int Id { get; set; }
        public string FirmName { get; set; }
        public DateTime? DocDate { get; set; }
        public string DocName { get; set; }
        public string Accounting { get; set; }
        public string Material { get; set; }
        public string Strore { get; set; }
        public string Contragent { get; set; }
        public string Contract { get; set; }
        public string Consignor { get; set; }
        public string Consignee { get; set; }
        public string MaterialGroup { get; set; }
        public string ContragentType { get; set; }
        public string NomenclatureType { get; set; }
        public string BussinesType { get; set; }
        public string Subdivision { get; set; }
        public double Netto { get; set; }
        public double Brutto { get; set; }
        public double CostPrice { get; set; }
        public double Revenues { get; set; }
    }
}
