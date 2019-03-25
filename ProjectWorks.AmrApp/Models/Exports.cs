using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Exports
    {
        public int Id { get; set; }
        public string FirmName { get; set; }
        public DateTime DocDate { get; set; }
        public string Contragent { get; set; }
        public string Nomenklature { get; set; }
        public double Price { get; set; }
        public double DebtSumm { get; set; }
        public int DebsTerm { get; set; }
        public string Nomenclatures { get; set; }
        public double Revenues { get; set; }
        public bool IsShowContragent { get; set; }
        public bool IsShowContragentName { get; set; }
        public bool IsShowNomGrp { get; set; }
        public string FilialColor { get; set; }
        public string DateColor { get; set; }
        public string DebsColor { get; set; }
    }
}
