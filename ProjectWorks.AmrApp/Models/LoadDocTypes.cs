using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LoadDocTypes
    {
        public LoadDocTypes()
        {
            LoadDocs = new HashSet<LoadDocs>();
            LoadRevisionNots = new HashSet<LoadRevisionNots>();
            LoadRevisionOks = new HashSet<LoadRevisionOks>();
            LoadSchetLogs = new HashSet<LoadSchetLogs>();
            LoadSchets = new HashSet<LoadSchets>();
        }

        public int Id { get; set; }
        public string DocTypeName { get; set; }
        public int AddUserId { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual ICollection<LoadDocs> LoadDocs { get; set; }
        public virtual ICollection<LoadRevisionNots> LoadRevisionNots { get; set; }
        public virtual ICollection<LoadRevisionOks> LoadRevisionOks { get; set; }
        public virtual ICollection<LoadSchetLogs> LoadSchetLogs { get; set; }
        public virtual ICollection<LoadSchets> LoadSchets { get; set; }
    }
}
