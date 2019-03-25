using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class TaskControllingPersons
    {
        public int Id { get; set; }
        public int? TaskId { get; set; }
        public int? AppUserId { get; set; }
        public bool IsDelete { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual TaskDbModels Task { get; set; }
    }
}
