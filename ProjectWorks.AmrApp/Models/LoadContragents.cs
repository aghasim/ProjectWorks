using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LoadContragents
    {
        public LoadContragents()
        {
            LoadDocs = new HashSet<LoadDocs>();
            LoadOsvs = new HashSet<LoadOsvs>();
            LoadSchetLogsContragent = new HashSet<LoadSchetLogs>();
            LoadSchetLogsContragent2 = new HashSet<LoadSchetLogs>();
            LoadSchetsContragent = new HashSet<LoadSchets>();
            LoadSchetsContragent2 = new HashSet<LoadSchets>();
            Object1 = new HashSet<Object1>();
        }

        public int Id { get; set; }
        public string Code1C { get; set; }
        public string ContragentName { get; set; }
        public int AddUserId { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual ICollection<LoadDocs> LoadDocs { get; set; }
        public virtual ICollection<LoadOsvs> LoadOsvs { get; set; }
        public virtual ICollection<LoadSchetLogs> LoadSchetLogsContragent { get; set; }
        public virtual ICollection<LoadSchetLogs> LoadSchetLogsContragent2 { get; set; }
        public virtual ICollection<LoadSchets> LoadSchetsContragent { get; set; }
        public virtual ICollection<LoadSchets> LoadSchetsContragent2 { get; set; }
        public virtual ICollection<Object1> Object1 { get; set; }
    }
}
