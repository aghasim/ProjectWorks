using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Helps
    {
        public Helps()
        {
            HelpImages = new HashSet<HelpImages>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public string HelpMarkUp { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<HelpImages> HelpImages { get; set; }
    }
}
