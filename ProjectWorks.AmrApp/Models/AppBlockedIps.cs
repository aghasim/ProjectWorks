using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppBlockedIps
    {
        public int Id { get; set; }
        public DateTime DateId { get; set; }
        public string ClientIp { get; set; }
    }
}
