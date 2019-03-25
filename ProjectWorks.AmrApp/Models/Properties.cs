using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Properties
    {
        public Properties()
        {
            PropertyValParams = new HashSet<PropertyValParams>();
            PropertyValueObjs = new HashSet<PropertyValueObjs>();
            PropertyValues = new HashSet<PropertyValues>();
        }

        public int Id { get; set; }
        public string PropertyName { get; set; }
        public int SortIndex { get; set; }
        public int FilialId { get; set; }
        public int ObjectTypeId { get; set; }
        public int PropertyValTypeId { get; set; }
        public int ValObjTypeId { get; set; }
        public string PropertyEd { get; set; }
        public string PropertySample { get; set; }
        public bool IsRequired { get; set; }
        public bool NotDel { get; set; }
        public int? AddUserId { get; set; }
        public string AddUserIp { get; set; }
        public bool IsGlobal { get; set; }
        public int? CostObjId { get; set; }

        public virtual Object1 CostObj { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual ObjectTypes ObjectType { get; set; }
        public virtual PropertyValTypes PropertyValType { get; set; }
        public virtual ICollection<PropertyValParams> PropertyValParams { get; set; }
        public virtual ICollection<PropertyValueObjs> PropertyValueObjs { get; set; }
        public virtual ICollection<PropertyValues> PropertyValues { get; set; }
    }
}
