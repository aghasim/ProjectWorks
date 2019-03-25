using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckListQusetionVariants
    {
        public CheckListQusetionVariants()
        {
            CheckListAnswers = new HashSet<CheckListAnswers>();
        }

        public int VariantId { get; set; }
        public string VarintText { get; set; }
        public int? Fine { get; set; }
        public int CheckListQuestionId { get; set; }

        public virtual CheckListQuestions CheckListQuestion { get; set; }
        public virtual ICollection<CheckListAnswers> CheckListAnswers { get; set; }
    }
}
