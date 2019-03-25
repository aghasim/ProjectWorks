using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class MacDuckDisassemblies
    {
        public MacDuckDisassemblies()
        {
            MacDuckDisassemblyNomenclatures = new HashSet<MacDuckDisassemblyNomenclatures>();
        }

        public string Id { get; set; }
        public string ClientId { get; set; }
        public string Comment { get; set; }
        public int CreatorId { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateOfProcessing { get; set; }
        public bool IsProcessed { get; set; }
        public int PointId { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }

        public virtual MacDuckClients Client { get; set; }
        public virtual AppUsers Creator { get; set; }
        public virtual Object1 Point { get; set; }
        public virtual ICollection<MacDuckDisassemblyNomenclatures> MacDuckDisassemblyNomenclatures { get; set; }
    }
}
