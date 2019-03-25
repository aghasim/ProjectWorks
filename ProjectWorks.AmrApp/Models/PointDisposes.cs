using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PointDisposes
    {
        public long Id { get; set; }
        public DateTime DateId { get; set; }
        public int FilialId { get; set; }
        public int Object1Id { get; set; }
        public string Comment { get; set; }
        public int? AddUserId { get; set; }
        public string PhotoUrl1 { get; set; }
        public int? BusinessId { get; set; }
        public int DisposeType { get; set; }
        public int DisposeStatus { get; set; }

        public virtual AppUsers AddUser { get; set; }
        public virtual PropertyValParams Business { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual Object1 Object1 { get; set; }
    }
}
