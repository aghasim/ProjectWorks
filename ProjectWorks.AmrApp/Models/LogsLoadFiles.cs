using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LogsLoadFiles
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public string TableName { get; set; }
        public DateTime LoadDate { get; set; }
        public int Month { get; set; }
    }
}
