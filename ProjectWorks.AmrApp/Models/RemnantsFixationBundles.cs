using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RemnantsFixationBundles
    {
        public int BundleId { get; set; }
        public int Object1Id { get; set; }
        public int RemnantsFixationRequestId { get; set; }

        public virtual Object1 Object1 { get; set; }
        public virtual RemnantsFixationRequests RemnantsFixationRequest { get; set; }
    }
}
