using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class LoadContracts
    {
        public LoadContracts()
        {
            LoadDocs = new HashSet<LoadDocs>();
            LoadOsvs = new HashSet<LoadOsvs>();
            LoadRevisionNots = new HashSet<LoadRevisionNots>();
            LoadRevisionOks = new HashSet<LoadRevisionOks>();
            LoadSchetLogsContractD = new HashSet<LoadSchetLogs>();
            LoadSchetLogsContractK = new HashSet<LoadSchetLogs>();
            LoadSchetsContractD = new HashSet<LoadSchets>();
            LoadSchetsContractK = new HashSet<LoadSchets>();
            LoadStat1CContractD = new HashSet<LoadStat1C>();
            LoadStat1CContractK = new HashSet<LoadStat1C>();
        }

        public int Id { get; set; }
        public string ContractName { get; set; }
        public int AddUserId { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual ICollection<LoadDocs> LoadDocs { get; set; }
        public virtual ICollection<LoadOsvs> LoadOsvs { get; set; }
        public virtual ICollection<LoadRevisionNots> LoadRevisionNots { get; set; }
        public virtual ICollection<LoadRevisionOks> LoadRevisionOks { get; set; }
        public virtual ICollection<LoadSchetLogs> LoadSchetLogsContractD { get; set; }
        public virtual ICollection<LoadSchetLogs> LoadSchetLogsContractK { get; set; }
        public virtual ICollection<LoadSchets> LoadSchetsContractD { get; set; }
        public virtual ICollection<LoadSchets> LoadSchetsContractK { get; set; }
        public virtual ICollection<LoadStat1C> LoadStat1CContractD { get; set; }
        public virtual ICollection<LoadStat1C> LoadStat1CContractK { get; set; }
    }
}
