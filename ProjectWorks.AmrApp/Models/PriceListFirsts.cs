using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PriceListFirsts
    {
        public long Id { get; set; }
        public int FilialId { get; set; }
        public DateTime? DateId { get; set; }
        public int DateYear { get; set; }
        public int DateMonth { get; set; }
        public int PriceTypeId { get; set; }
        public int? NomObjId { get; set; }
        public int? NomenclatureId { get; set; }
        public float? Price { get; set; }
        public float? Zasor { get; set; }
        public long DocId { get; set; }
        public bool NotDel { get; set; }
        public float? PriceOld { get; set; }

        public virtual PriceListDocs Doc { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual Object1 NomObj { get; set; }
        public virtual Nomenclatures Nomenclature { get; set; }
        public virtual PriceTypes PriceType { get; set; }
    }
}
