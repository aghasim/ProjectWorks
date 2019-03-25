using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckListCompleteds
    {
        public CheckListCompleteds()
        {
            CheckListAnswers = new HashSet<CheckListAnswers>();
        }

        public int CheckListCompletedId { get; set; }
        public int AppUserId { get; set; }
        public int CheckListId { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public DateTime CompletedDate { get; set; }
        public bool IsUnlimited { get; set; }
        public int Object1Id { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual CheckLists CheckList { get; set; }
        public virtual Object1 Object1 { get; set; }
        public virtual ICollection<CheckListAnswers> CheckListAnswers { get; set; }
    }
}
