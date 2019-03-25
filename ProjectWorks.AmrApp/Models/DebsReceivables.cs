using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class DebsReceivables
    {
        public int Id { get; set; }
        public string FirmName { get; set; }
        public string Contragent { get; set; }
        public string DocName { get; set; }
        public DateTime? DebtDate { get; set; }
        public int DebtTerm { get; set; }
        public double DebtSumm { get; set; }
        public double Turnover { get; set; }
        public double TurnoverDebet { get; set; }
        public double TurnoverKredit { get; set; }
    }
}
