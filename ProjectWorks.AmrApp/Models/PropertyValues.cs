using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PropertyValues
    {
        public int Id { get; set; }
        public int Object1Id { get; set; }
        public int PropertyId { get; set; }
        public string Value { get; set; }
        public long ValueInt { get; set; }
        public double ValueDouble { get; set; }
        public bool? ValueBool { get; set; }
        public int? PropertyValParamId { get; set; }
        public int ValObjTypeId { get; set; }
        public int ValObjId { get; set; }
        public string ValObjSet { get; set; }

        public virtual Object1 Object1 { get; set; }
        public virtual Properties Property { get; set; }
        public virtual PropertyValParams PropertyValParam { get; set; }
    }
}
