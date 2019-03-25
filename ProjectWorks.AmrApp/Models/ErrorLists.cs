using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class ErrorLists
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ClassName { get; set; }
        public string Method { get; set; }
        public string Message { get; set; }
    }
}
