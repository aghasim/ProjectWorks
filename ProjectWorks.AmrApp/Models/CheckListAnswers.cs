using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckListAnswers
    {
        public CheckListAnswers()
        {
            CheckListMistakeWorkAproves = new HashSet<CheckListMistakeWorkAproves>();
        }

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public string Comment { get; set; }
        public string MistakesWork { get; set; }
        public string ImgAnswerPath { get; set; }
        public DateTime CompletedDate { get; set; }
        public int CheckListQuestionId { get; set; }
        public int? CheckListQusetionVariantId { get; set; }
        public int? CheckListCompletedId { get; set; }
        public bool IsItWrong { get; set; }
        public int Fine { get; set; }
        public string ImgMistakeWorkPath { get; set; }

        public virtual CheckListCompleteds CheckListCompleted { get; set; }
        public virtual CheckListQuestions CheckListQuestion { get; set; }
        public virtual CheckListQusetionVariants CheckListQusetionVariant { get; set; }
        public virtual ICollection<CheckListMistakeWorkAproves> CheckListMistakeWorkAproves { get; set; }
    }
}
