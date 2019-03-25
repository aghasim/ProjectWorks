using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class SalarySettings
    {
        public int SalarySettingId { get; set; }
        public DateTime SettingDate { get; set; }
        public int DataSource { get; set; }
        public int CalcUnit { get; set; }
        public string Kpitext { get; set; }
        public decimal Value { get; set; }
        public bool IsBisType { get; set; }
        public bool IsDelete { get; set; }
        public int? Object1Id { get; set; }
        public int FuncRoleId { get; set; }
        public int AppUserId { get; set; }
        public int ConditParameters { get; set; }
        public decimal Condition { get; set; }
        public int Operations { get; set; }
        public int Params { get; set; }
        public int FilialId { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual AppFuncRoles FuncRole { get; set; }
        public virtual Object1 Object1 { get; set; }
    }
}
