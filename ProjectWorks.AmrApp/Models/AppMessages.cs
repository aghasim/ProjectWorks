using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppMessages
    {
        public int MsgId { get; set; }
        public DateTime DateId { get; set; }
        public int ToUserId { get; set; }
        public string MsgText { get; set; }
        public int? Object1Id { get; set; }
        public string LinkUrl { get; set; }
        public string LinkName { get; set; }
        public int FilialId { get; set; }
        public bool IsOk { get; set; }
    }
}
