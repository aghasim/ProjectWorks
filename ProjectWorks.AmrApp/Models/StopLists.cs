using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class StopLists
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int ContragentId { get; set; }
        public string Comment { get; set; }
        public DateTime? Date { get; set; }
        public bool IsDelete { get; set; }
    }
}
