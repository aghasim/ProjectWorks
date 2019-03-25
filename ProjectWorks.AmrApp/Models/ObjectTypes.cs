using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class ObjectTypes
    {
        public ObjectTypes()
        {
            AccessRules = new HashSet<AccessRules>();
            CheckLists = new HashSet<CheckLists>();
            CostExpedintureBindle = new HashSet<CostExpedintureBindle>();
            Object1 = new HashSet<Object1>();
            Properties = new HashSet<Properties>();
            RuleObjectBindles = new HashSet<RuleObjectBindles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EngName { get; set; }
        public string PicsIcon { get; set; }
        public bool IsGlobal { get; set; }
        public bool NotDel { get; set; }
        public int? AddUserId { get; set; }
        public string AddUserIp { get; set; }
        public int? DopAddDepartmentId { get; set; }
        public bool DopCreateAutoDep { get; set; }
        public int? DopDefaultRoleId { get; set; }
        public bool DopGeo { get; set; }

        public virtual AppFuncRoles DopDefaultRole { get; set; }
        public virtual ICollection<AccessRules> AccessRules { get; set; }
        public virtual ICollection<CheckLists> CheckLists { get; set; }
        public virtual ICollection<CostExpedintureBindle> CostExpedintureBindle { get; set; }
        public virtual ICollection<Object1> Object1 { get; set; }
        public virtual ICollection<Properties> Properties { get; set; }
        public virtual ICollection<RuleObjectBindles> RuleObjectBindles { get; set; }
    }
}
