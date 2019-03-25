using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PriceCompetitorAvgs
    {
        public long Id { get; set; }
        public int FilialId { get; set; }
        public DateTime DateId { get; set; }
        public int DateYear { get; set; }
        public int DateMonth { get; set; }
        public int Object1Id { get; set; }
        public int NomObjId { get; set; }
        public int BussinessId { get; set; }
        public float AveragePrice { get; set; }
        public float AverageZasor { get; set; }
        public int? ManagerId { get; set; }

        public virtual PropertyValParams Bussiness { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual AppUsers Manager { get; set; }
        public virtual Object1 NomObj { get; set; }
        public virtual Object1 Object1 { get; set; }
    }
}
