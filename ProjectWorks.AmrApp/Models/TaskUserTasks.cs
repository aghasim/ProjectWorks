using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class TaskUserTasks
    {
        public TaskUserTasks()
        {
            TaskStatusHistories = new HashSet<TaskStatusHistories>();
        }

        public int Id { get; set; }
        public int? TaskId { get; set; }
        public int? AppUserId { get; set; }
        public int State { get; set; }
        public int? TookTheTaskId { get; set; }
        public int Mark { get; set; }
        public bool IsDelete { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual TaskDbModels Task { get; set; }
        public virtual ICollection<TaskStatusHistories> TaskStatusHistories { get; set; }
    }
}
