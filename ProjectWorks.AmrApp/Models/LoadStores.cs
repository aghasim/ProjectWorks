using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LoadStores
    {
        public LoadStores()
        {
            LoadSchetLogs = new HashSet<LoadSchetLogs>();
            LoadSchets = new HashSet<LoadSchets>();
        }

        public int Id { get; set; }
        public string StoreName { get; set; }
        public int AddUserId { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual ICollection<LoadSchetLogs> LoadSchetLogs { get; set; }
        public virtual ICollection<LoadSchets> LoadSchets { get; set; }
    }
}
