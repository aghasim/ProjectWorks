using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppUserDepartmentRoles
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int FuncRoleId { get; set; }

        public virtual AppUserDepartments Department { get; set; }
        public virtual AppFuncRoles FuncRole { get; set; }
    }
}
