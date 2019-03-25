using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RemnantsFixationAnswers
    {
        public RemnantsFixationAnswers()
        {
            RemnantsFixationAnswerDetails = new HashSet<RemnantsFixationAnswerDetails>();
        }

        public int RemnantsFixationAnswerId { get; set; }
        public DateTime DateExecute { get; set; }
        public int Object1Id { get; set; }
        public int RemnantsFixationRequestId { get; set; }
        public int AppUserId { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual Object1 Object1 { get; set; }
        public virtual RemnantsFixationRequests RemnantsFixationRequest { get; set; }
        public virtual ICollection<RemnantsFixationAnswerDetails> RemnantsFixationAnswerDetails { get; set; }
    }
}
