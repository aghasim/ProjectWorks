using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AccessRules
    {
        public int Id { get; set; }
        public int FilialId { get; set; }
        public int AppUserDepartmentId { get; set; }
        public int ObjectTypeId { get; set; }
        public string RuleKey { get; set; }
        public string AccessKey { get; set; }
        public string PropKey { get; set; }
        public string PropWrite { get; set; }
        public string ObjKey { get; set; }
        public int FilterId { get; set; }
        public int FilterVal { get; set; }
        public int BoolId { get; set; }
        public bool? BoolVal { get; set; }
        public int UserId { get; set; }
        public int ValObjId { get; set; }
        public string NotObj { get; set; }
        public int ValObjPropId { get; set; }

        public virtual AppUserDepartments AppUserDepartment { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual ObjectTypes ObjectType { get; set; }
    }
}
