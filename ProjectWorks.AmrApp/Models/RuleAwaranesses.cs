using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RuleAwaranesses
    {
        public int RuleAwaranessId { get; set; }
        public int RuleId { get; set; }
        public int AppUserId { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual Rules Rule { get; set; }
    }
}
