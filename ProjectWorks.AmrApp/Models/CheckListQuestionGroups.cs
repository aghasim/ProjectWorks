using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckListQuestionGroups
    {
        public CheckListQuestionGroups()
        {
            CheckListQuestions = new HashSet<CheckListQuestions>();
        }

        public int QuestionGroupId { get; set; }
        public DateTime CreateDate { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<CheckListQuestions> CheckListQuestions { get; set; }
    }
}
