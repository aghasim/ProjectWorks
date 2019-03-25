using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class TaskDbModels
    {
        public TaskDbModels()
        {
            TaskControllingPersons = new HashSet<TaskControllingPersons>();
            TaskDiscussionOfTheTasks = new HashSet<TaskDiscussionOfTheTasks>();
            TaskUserTasks = new HashSet<TaskUserTasks>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Since { get; set; }
        public DateTime For { get; set; }
        public string FilePath { get; set; }
        public int? AppUserId { get; set; }
        public int CommunicationSetting { get; set; }
        public int TypeOfControl { get; set; }
        public int? FilialId { get; set; }
        public bool IsDelete { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual ICollection<TaskControllingPersons> TaskControllingPersons { get; set; }
        public virtual ICollection<TaskDiscussionOfTheTasks> TaskDiscussionOfTheTasks { get; set; }
        public virtual ICollection<TaskUserTasks> TaskUserTasks { get; set; }
    }
}
