using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppLoginAudits
    {
        public long Id { get; set; }
        public DateTime DateId { get; set; }
        public string ClientIp { get; set; }
        public string UserLogin { get; set; }
        public int Result { get; set; }
    }
}
