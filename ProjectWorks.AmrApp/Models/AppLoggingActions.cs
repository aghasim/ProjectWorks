using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppLoggingActions
    {
        public long Id { get; set; }
        public DateTime DateId { get; set; }
        public string ClientIp { get; set; }
        public int? UserId { get; set; }
        public string UserLogin { get; set; }
        public string UrlPath { get; set; }
        public string UrlId { get; set; }
        public string UrlQuery { get; set; }
        public string Rem { get; set; }
    }
}
