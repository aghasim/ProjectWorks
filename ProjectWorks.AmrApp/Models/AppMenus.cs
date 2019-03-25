using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppMenus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LinkUrl { get; set; }
        public int FilialId { get; set; }
        public int SortIndex { get; set; }
        public int ParentId { get; set; }
        public int Rang { get; set; }
        public string FullKey { get; set; }
        public string SortKey { get; set; }
        public bool IsOk { get; set; }

        public virtual Filials Filial { get; set; }
    }
}
