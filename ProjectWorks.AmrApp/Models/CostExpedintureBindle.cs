using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CostExpedintureBindle
    {
        public int BindleId { get; set; }
        public int ExpenditureId { get; set; }
        public int? Object1Id { get; set; }
        public int? ObjectTypeId { get; set; }
        public int? AppUserId { get; set; }
        public int? AppUserDepartmentId { get; set; }
        public int? AppFuncRoleId { get; set; }

        public virtual AppFuncRoles AppFuncRole { get; set; }
        public virtual AppUsers AppUser { get; set; }
        public virtual AppUserDepartments AppUserDepartment { get; set; }
        public virtual Object1 Object1 { get; set; }
        public virtual ObjectTypes ObjectType { get; set; }
    }
}
