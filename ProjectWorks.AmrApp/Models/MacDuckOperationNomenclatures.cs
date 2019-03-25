using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class MacDuckOperationNomenclatures
    {
        public string Id { get; set; }
        public int Garbagge { get; set; }
        public int NomenclatureId { get; set; }
        public string OperationId { get; set; }
        public decimal Price { get; set; }
        public double StandartGarbagge { get; set; }
        public decimal TheSizeOfTheCashBonus { get; set; }
        public double Weight { get; set; }

        public virtual Object1 Nomenclature { get; set; }
        public virtual MacDuckOperations Operation { get; set; }
    }
}
