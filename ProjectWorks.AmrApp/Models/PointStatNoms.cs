using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PointStatNoms
    {
        public long Id { get; set; }
        public int DateYear { get; set; }
        public int DateMonth { get; set; }
        public int FilialId { get; set; }
        public int Object1Id { get; set; }
        public int? NomObjId { get; set; }
        public int? NomenclatureId { get; set; }
        public double? Plus { get; set; }
        public double? Total { get; set; }
        public int? BusinessId { get; set; }
        public int? ManagerId { get; set; }
        public double Summ1 { get; set; }
        public double SummS { get; set; }
        public DateTime DateMax { get; set; }
        public int? NomGrpId { get; set; }
        public double TotalSumm1 { get; set; }
        public double TotalSummS { get; set; }

        public virtual PropertyValParams Business { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual AppUsers Manager { get; set; }
        public virtual Object1 NomGrp { get; set; }
        public virtual Object1 NomObj { get; set; }
        public virtual Nomenclatures Nomenclature { get; set; }
        public virtual Object1 Object1 { get; set; }
    }
}
