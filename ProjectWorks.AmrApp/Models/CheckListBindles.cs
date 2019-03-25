using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckListBindles
    {
        public int CheckListBindleId { get; set; }
        public int CheckListId { get; set; }
        public int AppUserId { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual CheckLists CheckList { get; set; }
    }
}
