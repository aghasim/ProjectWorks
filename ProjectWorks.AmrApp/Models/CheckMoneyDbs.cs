using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckMoneyDbs
    {
        public int Id { get; set; }
        public int PointId { get; set; }
        public int TypeOfBusiness { get; set; }
        public DateTime? Date { get; set; }
        public int NomenclaturaId { get; set; }
        public string NomenclatureName { get; set; }
        public decimal CountPlus { get; set; }
        public double OutCount { get; set; }
        public decimal Price { get; set; }
        public decimal OutSumm { get; set; }
        public decimal CalcReman { get; set; }
        public decimal SumRemamns { get; set; }
        public DateTime? DateToNull { get; set; }
        public DateTime? DateLastRemov { get; set; }
    }
}
