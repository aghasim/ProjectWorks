using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckLists
    {
        public CheckLists()
        {
            CheckListBindles = new HashSet<CheckListBindles>();
            CheckListCompleteds = new HashSet<CheckListCompleteds>();
            CheckListFuncRoleBundles = new HashSet<CheckListFuncRoleBundles>();
            CheckListQuestions = new HashSet<CheckListQuestions>();
            CheckListReadRights = new HashSet<CheckListReadRights>();
            CheckListRolePermissions = new HashSet<CheckListRolePermissions>();
            CheckListWeekDays = new HashSet<CheckListWeekDays>();
            CheckListWriteRights = new HashSet<CheckListWriteRights>();
        }

        public int CheckListId { get; set; }
        public int PeriodicalTypes { get; set; }
        public string CheckListName { get; set; }
        public int? Fine { get; set; }
        public DateTime? StartPeriod { get; set; }
        public DateTime? EndPeriod { get; set; }
        public DateTime? Term { get; set; }
        public int CheckListShowType { get; set; }
        public int CheckListStatus { get; set; }
        public bool IsDelete { get; set; }
        public int AppUserId { get; set; }
        public int ObjectTypeId { get; set; }
        public int FilialId { get; set; }
        public int CheckListBundleType { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual ObjectTypes ObjectType { get; set; }
        public virtual ICollection<CheckListBindles> CheckListBindles { get; set; }
        public virtual ICollection<CheckListCompleteds> CheckListCompleteds { get; set; }
        public virtual ICollection<CheckListFuncRoleBundles> CheckListFuncRoleBundles { get; set; }
        public virtual ICollection<CheckListQuestions> CheckListQuestions { get; set; }
        public virtual ICollection<CheckListReadRights> CheckListReadRights { get; set; }
        public virtual ICollection<CheckListRolePermissions> CheckListRolePermissions { get; set; }
        public virtual ICollection<CheckListWeekDays> CheckListWeekDays { get; set; }
        public virtual ICollection<CheckListWriteRights> CheckListWriteRights { get; set; }
    }
}
