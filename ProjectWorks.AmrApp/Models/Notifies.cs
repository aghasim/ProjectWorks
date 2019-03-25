using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Notifies
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public int Type { get; set; }

        public virtual AppUsers User { get; set; }
    }
}
