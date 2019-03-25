using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class MacDuckOperations
    {
        public MacDuckOperations()
        {
            MacDuckOperationNomenclatures = new HashSet<MacDuckOperationNomenclatures>();
        }

        public string Id { get; set; }
        public string ClientId { get; set; }
        public int CreatorId { get; set; }
        public DateTime Date { get; set; }
        public int PointId { get; set; }

        public virtual MacDuckClients Client { get; set; }
        public virtual AppUsers Creator { get; set; }
        public virtual Object1 Point { get; set; }
        public virtual ICollection<MacDuckOperationNomenclatures> MacDuckOperationNomenclatures { get; set; }
    }
}
