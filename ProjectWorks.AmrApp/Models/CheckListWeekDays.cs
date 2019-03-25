using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class CheckListWeekDays
    {
        public int CheckListWeekDayId { get; set; }
        public int CheckListId { get; set; }
        public int WeekDay { get; set; }

        public virtual CheckLists CheckList { get; set; }
    }
}
