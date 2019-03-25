using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class HelpImages
    {
        public int Id { get; set; }
        public string ImgPath { get; set; }
        public bool IsDelete { get; set; }
        public int HelpId { get; set; }

        public virtual Helps Help { get; set; }
    }
}
