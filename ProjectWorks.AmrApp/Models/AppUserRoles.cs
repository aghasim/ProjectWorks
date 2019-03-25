using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppUserRoles
    {
        public AppUserRoles()
        {
            AppUsers = new HashSet<AppUsers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AppUsers> AppUsers { get; set; }
    }
}
