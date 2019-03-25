using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppLoggingDbs
    {
        public long Id { get; set; }
        public DateTime DateId { get; set; }
        public int? UserId { get; set; }
        public string Table { get; set; }
        public string Command { get; set; }
        public long RowId { get; set; }
        public bool Ok { get; set; }
    }
}
