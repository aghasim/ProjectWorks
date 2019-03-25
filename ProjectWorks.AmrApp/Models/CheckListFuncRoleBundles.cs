using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckListFuncRoleBundles
    {
        public Guid Id { get; set; }
        public int AppFuncRoleId { get; set; }
        public int CheckListId { get; set; }

        public virtual AppFuncRoles AppFuncRole { get; set; }
        public virtual CheckLists CheckList { get; set; }
    }
}
