using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckListQuestions
    {
        public CheckListQuestions()
        {
            CheckListAnswers = new HashSet<CheckListAnswers>();
            CheckListQusetionVariants = new HashSet<CheckListQusetionVariants>();
        }

        public int CheckListQuestionId { get; set; }
        public int QuestionType { get; set; }
        public string QusetionText { get; set; }
        public string ImgDescription { get; set; }
        public string ImgQuestionPath { get; set; }
        public bool IsComented { get; set; }
        public bool IsMistakeWork { get; set; }
        public bool IsPhotoToAnswer { get; set; }
        public bool IsDelete { get; set; }
        public int CheckListId { get; set; }
        public string Variant1 { get; set; }
        public int? Fine1 { get; set; }
        public string Variant2 { get; set; }
        public int? Fine2 { get; set; }
        public string Variant3 { get; set; }
        public int? Fine3 { get; set; }
        public string Variant4 { get; set; }
        public int? Fine4 { get; set; }
        public string Variant5 { get; set; }
        public int? Fine5 { get; set; }
        public string Variant6 { get; set; }
        public int? Fine6 { get; set; }
        public bool IsItWrongQuest1 { get; set; }
        public bool IsItWrongQuest2 { get; set; }
        public bool IsItWrongQuest3 { get; set; }
        public bool IsItWrongQuest4 { get; set; }
        public bool IsItWrongQuest5 { get; set; }
        public bool IsItWrongQuest6 { get; set; }
        public int QuestionGroupId { get; set; }

        public virtual CheckLists CheckList { get; set; }
        public virtual CheckListQuestionGroups QuestionGroup { get; set; }
        public virtual ICollection<CheckListAnswers> CheckListAnswers { get; set; }
        public virtual ICollection<CheckListQusetionVariants> CheckListQusetionVariants { get; set; }
    }
}
