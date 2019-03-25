using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckListRolePermissions
    {
        public Guid Id { get; set; }
        public int CheckListRolePermissionType { get; set; }
        public int AppFuncRoleId { get; set; }
        public int CheckListId { get; set; }

        public virtual AppFuncRoles AppFuncRole { get; set; }
        public virtual CheckLists CheckList { get; set; }
    }
}
