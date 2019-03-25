using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppHistoryСhange
    {
        public long Id { get; set; }
        public DateTime DateId { get; set; }
        public int? UserId { get; set; }
        public string Table { get; set; }
        public long RowId { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
