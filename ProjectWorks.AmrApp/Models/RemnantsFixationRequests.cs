using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RemnantsFixationRequests
    {
        public RemnantsFixationRequests()
        {
            RemnantsFixationAnswers = new HashSet<RemnantsFixationAnswers>();
            RemnantsFixationBundles = new HashSet<RemnantsFixationBundles>();
            RemnantsFixationMaterialsRemnantsFixationRequestRemnantsFixationRequest = new HashSet<RemnantsFixationMaterials>();
            RemnantsFixationMaterialsRemnantsFixationRequestRemnantsFixationRequestId1Navigation = new HashSet<RemnantsFixationMaterials>();
        }

        public int RemnantsFixationRequestId { get; set; }
        public DateTime CreateDate { get; set; }
        public int RemnantsLoadingType { get; set; }
        public int RemnantsPeriodicalType { get; set; }
        public bool IsDelete { get; set; }
        public int Object1Id { get; set; }
        public int AppUserId { get; set; }
        public int? RemnantsFixationMaterialRemnantsFixationMaterialId { get; set; }
        public DateTime Deadline { get; set; }
        public int FilialId { get; set; }
        public int CreateUserId { get; set; }
        public string PriceDocName { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual Object1 Object1 { get; set; }
        public virtual RemnantsFixationMaterials RemnantsFixationMaterialRemnantsFixationMaterial { get; set; }
        public virtual ICollection<RemnantsFixationAnswers> RemnantsFixationAnswers { get; set; }
        public virtual ICollection<RemnantsFixationBundles> RemnantsFixationBundles { get; set; }
        public virtual ICollection<RemnantsFixationMaterials> RemnantsFixationMaterialsRemnantsFixationRequestRemnantsFixationRequest { get; set; }
        public virtual ICollection<RemnantsFixationMaterials> RemnantsFixationMaterialsRemnantsFixationRequestRemnantsFixationRequestId1Navigation { get; set; }
    }
}
