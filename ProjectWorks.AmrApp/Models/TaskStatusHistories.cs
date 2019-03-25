using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class TaskStatusHistories
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int State { get; set; }
        public string Text { get; set; }
        public string FilePath { get; set; }
        public int? UserTaskId { get; set; }
        public bool IsDelete { get; set; }

        public virtual TaskUserTasks UserTask { get; set; }
    }
}
