using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class UserIntermediates
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserFio { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string Session { get; set; }
        public bool Confirm { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public int? ConfirmBossId { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
