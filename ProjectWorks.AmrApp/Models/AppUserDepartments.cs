using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppUserDepartments
    {
        public AppUserDepartments()
        {
            AccessRules = new HashSet<AccessRules>();
            AppUserDepartmentRoles = new HashSet<AppUserDepartmentRoles>();
            AppUsers = new HashSet<AppUsers>();
            CostExpedintureBindle = new HashSet<CostExpedintureBindle>();
            PriceListDocs = new HashSet<PriceListDocs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FilialId { get; set; }
        public int? BossId { get; set; }
        public int SortIndex { get; set; }
        public int? ParentId { get; set; }
        public int Rang { get; set; }
        public string FullKey { get; set; }
        public string SortKey { get; set; }
        public string FuncRoles { get; set; }
        public bool NotDel { get; set; }
        public int? AddUserId { get; set; }
        public string AddUserIp { get; set; }

        public virtual Filials Filial { get; set; }
        public virtual ICollection<AccessRules> AccessRules { get; set; }
        public virtual ICollection<AppUserDepartmentRoles> AppUserDepartmentRoles { get; set; }
        public virtual ICollection<AppUsers> AppUsers { get; set; }
        public virtual ICollection<CostExpedintureBindle> CostExpedintureBindle { get; set; }
        public virtual ICollection<PriceListDocs> PriceListDocs { get; set; }
    }
}
