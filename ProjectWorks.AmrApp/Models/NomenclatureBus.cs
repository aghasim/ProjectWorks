using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class NomenclatureBus
    {
        public int Id { get; set; }
        public int TopGrpId { get; set; }
        public int BusinessId { get; set; }

        public virtual PropertyValParams Business { get; set; }
        public virtual Nomenclatures TopGrp { get; set; }
    }
}
