using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class EveryDayCalculateRemnants
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int NomenclatureId { get; set; }
        public int NomemclatureObjId { get; set; }
        public int ObjectId { get; set; }
        public int BussnesId { get; set; }
        public double Amount { get; set; }
        public double SumAmount { get; set; }
        public double Remnnants { get; set; }
        public double RemnantsSum { get; set; }
    }
}
