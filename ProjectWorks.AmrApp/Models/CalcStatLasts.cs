using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CalcStatLasts
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public int FilialId { get; set; }
        public DateTime DateLast { get; set; }
        public int? UserId { get; set; }
        public DateTime DateLastFinish { get; set; }

        public virtual Filials Filial { get; set; }
        public virtual AppUsers User { get; set; }
    }
}
