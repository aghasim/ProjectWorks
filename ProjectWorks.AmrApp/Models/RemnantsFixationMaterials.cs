using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RemnantsFixationMaterials
    {
        public RemnantsFixationMaterials()
        {
            RemnantsFixationRequests = new HashSet<RemnantsFixationRequests>();
        }

        public int RemnantsFixationMaterialId { get; set; }
        public int NomenclatureId { get; set; }
        public int RemnantsFixationRequestId { get; set; }
        public int? RemnantsFixationRequestRemnantsFixationRequestId { get; set; }
        public int? RemnantsFixationRequestRemnantsFixationRequestId1 { get; set; }
        public decimal OldPrice { get; set; }

        public virtual Nomenclatures Nomenclature { get; set; }
        public virtual RemnantsFixationRequests RemnantsFixationRequestRemnantsFixationRequest { get; set; }
        public virtual RemnantsFixationRequests RemnantsFixationRequestRemnantsFixationRequestId1Navigation { get; set; }
        public virtual ICollection<RemnantsFixationRequests> RemnantsFixationRequests { get; set; }
    }
}
