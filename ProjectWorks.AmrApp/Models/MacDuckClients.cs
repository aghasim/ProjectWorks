using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class MacDuckClients
    {
        public MacDuckClients()
        {
            MacDuckClientBonuses = new HashSet<MacDuckClientBonuses>();
            MacDuckDisassemblies = new HashSet<MacDuckDisassemblies>();
            MacDuckOperations = new HashSet<MacDuckOperations>();
        }

        public string Id { get; set; }
        public int ClientBonusType { get; set; }
        public int CreatorId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public int? PointId { get; set; }
        public int? RegionalId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual AppUsers Creator { get; set; }
        public virtual Object1 Point { get; set; }
        public virtual AppUsers Regional { get; set; }
        public virtual ICollection<MacDuckClientBonuses> MacDuckClientBonuses { get; set; }
        public virtual ICollection<MacDuckDisassemblies> MacDuckDisassemblies { get; set; }
        public virtual ICollection<MacDuckOperations> MacDuckOperations { get; set; }
    }
}
