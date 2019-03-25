using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Business1C
    {
        public Business1C()
        {
            Nomenclatures = new HashSet<Nomenclatures>();
        }

        public int Id { get; set; }
        public string Name1C { get; set; }
        public int? BusinessId { get; set; }

        public virtual PropertyValParams Business { get; set; }
        public virtual ICollection<Nomenclatures> Nomenclatures { get; set; }
    }
}
