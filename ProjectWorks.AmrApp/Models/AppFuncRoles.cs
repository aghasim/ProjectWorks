using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppFuncRoles
    {
        public AppFuncRoles()
        {
            AppUserDepartmentRoles = new HashSet<AppUserDepartmentRoles>();
            CheckListFuncRoleBundles = new HashSet<CheckListFuncRoleBundles>();
            CheckListRolePermissions = new HashSet<CheckListRolePermissions>();
            CostExpedintureBindle = new HashSet<CostExpedintureBindle>();
            ObjectTypes = new HashSet<ObjectTypes>();
            RuleRoleBindles = new HashSet<RuleRoleBindles>();
            SalarySettings = new HashSet<SalarySettings>();
        }

        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string MenuAccess { get; set; }
        public bool NotDel { get; set; }
        public bool OnlyOne { get; set; }
        public bool NotUnionObj { get; set; }
        public bool IsDirector { get; set; }
        public bool IsGlobal { get; set; }
        public string DopRoles { get; set; }
        public string NotUnionTypes { get; set; }

        public virtual ICollection<AppUserDepartmentRoles> AppUserDepartmentRoles { get; set; }
        public virtual ICollection<CheckListFuncRoleBundles> CheckListFuncRoleBundles { get; set; }
        public virtual ICollection<CheckListRolePermissions> CheckListRolePermissions { get; set; }
        public virtual ICollection<CostExpedintureBindle> CostExpedintureBindle { get; set; }
        public virtual ICollection<ObjectTypes> ObjectTypes { get; set; }
        public virtual ICollection<RuleRoleBindles> RuleRoleBindles { get; set; }
        public virtual ICollection<SalarySettings> SalarySettings { get; set; }
    }
}
