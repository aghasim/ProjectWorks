using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PriceListDocs
    {
        public PriceListDocs()
        {
            PriceListFirsts = new HashSet<PriceListFirsts>();
            PriceListIndependents = new HashSet<PriceListIndependents>();
            PriceListSeconds = new HashSet<PriceListSeconds>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Name1C { get; set; }
        public DateTime DateId { get; set; }
        public int FilialId { get; set; }
        public int PriceTypeId { get; set; }
        public int? AddUserId { get; set; }
        public string Comment { get; set; }
        public bool EditFirst { get; set; }
        public bool EditSecond { get; set; }
        public bool NotDel { get; set; }
        public bool EditIndependent { get; set; }
        public int? ManagerId { get; set; }
        public bool Signed { get; set; }
        public int? DepartmentId { get; set; }
        public int ActiveId { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual AppUserDepartments Department { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual AppUsers Manager { get; set; }
        public virtual PriceTypes PriceType { get; set; }
        public virtual ICollection<PriceListFirsts> PriceListFirsts { get; set; }
        public virtual ICollection<PriceListIndependents> PriceListIndependents { get; set; }
        public virtual ICollection<PriceListSeconds> PriceListSeconds { get; set; }
    }
}
