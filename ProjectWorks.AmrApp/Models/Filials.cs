using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Filials
    {
        public Filials()
        {
            AccessRules = new HashSet<AccessRules>();
            AppConfigs = new HashSet<AppConfigs>();
            AppMenus = new HashSet<AppMenus>();
            AppUserDepartments = new HashSet<AppUserDepartments>();
            AppUsers = new HashSet<AppUsers>();
            CalcStatLasts = new HashSet<CalcStatLasts>();
            LoadFirms = new HashSet<LoadFirms>();
            LogisticRouteSheets = new HashSet<LogisticRouteSheets>();
            LogisticRouteSheetsGroups = new HashSet<LogisticRouteSheetsGroups>();
            Object1 = new HashSet<Object1>();
            PointDisposes = new HashSet<PointDisposes>();
            PointPlans = new HashSet<PointPlans>();
            PointReportMoneys = new HashSet<PointReportMoneys>();
            PointReportMoneysLogs = new HashSet<PointReportMoneysLogs>();
            PointReportNoms = new HashSet<PointReportNoms>();
            PointReportNomsLogs = new HashSet<PointReportNomsLogs>();
            PointStatNoms = new HashSet<PointStatNoms>();
            PriceCompetitorAvgs = new HashSet<PriceCompetitorAvgs>();
            PriceCompetitorVisions = new HashSet<PriceCompetitorVisions>();
            PriceCompetitors = new HashSet<PriceCompetitors>();
            PriceListDocs = new HashSet<PriceListDocs>();
            PriceListFirsts = new HashSet<PriceListFirsts>();
            PriceListIndependents = new HashSet<PriceListIndependents>();
            PriceListSeconds = new HashSet<PriceListSeconds>();
            Properties = new HashSet<Properties>();
        }

        public int Id { get; set; }
        public string FilialName { get; set; }
        public string FilialKey { get; set; }

        public virtual ICollection<AccessRules> AccessRules { get; set; }
        public virtual ICollection<AppConfigs> AppConfigs { get; set; }
        public virtual ICollection<AppMenus> AppMenus { get; set; }
        public virtual ICollection<AppUserDepartments> AppUserDepartments { get; set; }
        public virtual ICollection<AppUsers> AppUsers { get; set; }
        public virtual ICollection<CalcStatLasts> CalcStatLasts { get; set; }
        public virtual ICollection<LoadFirms> LoadFirms { get; set; }
        public virtual ICollection<LogisticRouteSheets> LogisticRouteSheets { get; set; }
        public virtual ICollection<LogisticRouteSheetsGroups> LogisticRouteSheetsGroups { get; set; }
        public virtual ICollection<Object1> Object1 { get; set; }
        public virtual ICollection<PointDisposes> PointDisposes { get; set; }
        public virtual ICollection<PointPlans> PointPlans { get; set; }
        public virtual ICollection<PointReportMoneys> PointReportMoneys { get; set; }
        public virtual ICollection<PointReportMoneysLogs> PointReportMoneysLogs { get; set; }
        public virtual ICollection<PointReportNoms> PointReportNoms { get; set; }
        public virtual ICollection<PointReportNomsLogs> PointReportNomsLogs { get; set; }
        public virtual ICollection<PointStatNoms> PointStatNoms { get; set; }
        public virtual ICollection<PriceCompetitorAvgs> PriceCompetitorAvgs { get; set; }
        public virtual ICollection<PriceCompetitorVisions> PriceCompetitorVisions { get; set; }
        public virtual ICollection<PriceCompetitors> PriceCompetitors { get; set; }
        public virtual ICollection<PriceListDocs> PriceListDocs { get; set; }
        public virtual ICollection<PriceListFirsts> PriceListFirsts { get; set; }
        public virtual ICollection<PriceListIndependents> PriceListIndependents { get; set; }
        public virtual ICollection<PriceListSeconds> PriceListSeconds { get; set; }
        public virtual ICollection<Properties> Properties { get; set; }
    }
}
