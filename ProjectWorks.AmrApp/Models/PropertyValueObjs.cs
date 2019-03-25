using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PropertyValueObjs
    {
        public int Id { get; set; }
        public int Object1Id { get; set; }
        public int PropertyId { get; set; }
        public int ValObjId { get; set; }

        public virtual Object1 Object1 { get; set; }
        public virtual Properties Property { get; set; }
    }
}
