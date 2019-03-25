using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PropertyValTypes
    {
        public PropertyValTypes()
        {
            Properties = new HashSet<Properties>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Properties> Properties { get; set; }
    }
}
