using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LoadFirms
    {
        public LoadFirms()
        {
            LoadDocs = new HashSet<LoadDocs>();
            LoadOsvs = new HashSet<LoadOsvs>();
            LoadRevisionNots = new HashSet<LoadRevisionNots>();
            LoadRevisionOks = new HashSet<LoadRevisionOks>();
            LoadSchetLogs = new HashSet<LoadSchetLogs>();
            LoadSchets = new HashSet<LoadSchets>();
            LoadStat1C = new HashSet<LoadStat1C>();
        }

        public int Id { get; set; }
        public string FirmName { get; set; }
        public string FirmCode { get; set; }
        public int AddUserId { get; set; }
        public int? FilialId { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual ICollection<LoadDocs> LoadDocs { get; set; }
        public virtual ICollection<LoadOsvs> LoadOsvs { get; set; }
        public virtual ICollection<LoadRevisionNots> LoadRevisionNots { get; set; }
        public virtual ICollection<LoadRevisionOks> LoadRevisionOks { get; set; }
        public virtual ICollection<LoadSchetLogs> LoadSchetLogs { get; set; }
        public virtual ICollection<LoadSchets> LoadSchets { get; set; }
        public virtual ICollection<LoadStat1C> LoadStat1C { get; set; }
    }
}
