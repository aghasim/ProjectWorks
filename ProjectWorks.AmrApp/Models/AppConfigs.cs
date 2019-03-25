using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppConfigs
    {
        public int Id { get; set; }
        public int FilialId { get; set; }
        public string Param { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }
        public string SelectList { get; set; }
        public int? GrpId { get; set; }

        public virtual Filials Filial { get; set; }
        public virtual AppConfigGrps Grp { get; set; }
    }
}
