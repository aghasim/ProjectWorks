using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppConfigGrps
    {
        public AppConfigGrps()
        {
            AppConfigs = new HashSet<AppConfigs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AppConfigs> AppConfigs { get; set; }
    }
}
