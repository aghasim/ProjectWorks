using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckListMistakeWorkAproves
    {
        public int AproveId { get; set; }
        public int UserId { get; set; }
        public int AnswerId { get; set; }
        public DateTime AproveDate { get; set; }
        public bool IsAprove { get; set; }

        public virtual CheckListAnswers Answer { get; set; }
        public virtual AppUsers User { get; set; }
    }
}
