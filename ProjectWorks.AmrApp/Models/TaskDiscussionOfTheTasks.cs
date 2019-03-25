using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class TaskDiscussionOfTheTasks
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int? AppUserId { get; set; }
        public int? AppUserRecipientId { get; set; }
        public bool IsNew { get; set; }
        public int? TaskId { get; set; }
        public string FilePath { get; set; }
        public bool IsController { get; set; }
        public bool IsDelete { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual TaskDbModels Task { get; set; }
    }
}
