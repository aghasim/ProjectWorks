using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class FilialsColors
    {
        public int Id { get; set; }
        public string FilialName { get; set; }
        public string Color { get; set; }
        public string Boss { get; set; }
        public string ServerName { get; set; }
        public int Object1Id { get; set; }

        public virtual Object1 Object1 { get; set; }
    }
}
