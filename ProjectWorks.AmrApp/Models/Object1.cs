using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Object1
    {
        public Object1()
        {
            CheckListCompleteds = new HashSet<CheckListCompleteds>();
            CostExpedintureBindle = new HashSet<CostExpedintureBindle>();
            CostExpenditureApprovement = new HashSet<CostExpenditureApprovement>();
            Costs = new HashSet<Costs>();
            CostsObjectsLimits = new HashSet<CostsObjectsLimits>();
            FilialsColors = new HashSet<FilialsColors>();
            LoadDocs = new HashSet<LoadDocs>();
            LoadOsvs = new HashSet<LoadOsvs>();
            LoadRevisionNots = new HashSet<LoadRevisionNots>();
            LoadRevisionOks = new HashSet<LoadRevisionOks>();
            LoadSchetLogs = new HashSet<LoadSchetLogs>();
            LoadSchets = new HashSet<LoadSchets>();
            LoadStat1C = new HashSet<LoadStat1C>();
            LogisticDriverCarLogs = new HashSet<LogisticDriverCarLogs>();
            LogisticDriverLogs = new HashSet<LogisticDriverLogs>();
            LogisticDriverSummaryItemsObject1 = new HashSet<LogisticDriverSummaryItems>();
            LogisticDriverSummaryItemsPoint = new HashSet<LogisticDriverSummaryItems>();
            LogisticRouteSheets = new HashSet<LogisticRouteSheets>();
            LogisticTripsPointIn = new HashSet<LogisticTrips>();
            LogisticTripsPointOut = new HashSet<LogisticTrips>();
            MacDuckAddedMoneys = new HashSet<MacDuckAddedMoneys>();
            MacDuckClientBonuses = new HashSet<MacDuckClientBonuses>();
            MacDuckClients = new HashSet<MacDuckClients>();
            MacDuckDisassemblies = new HashSet<MacDuckDisassemblies>();
            MacDuckDisassemblyNomenclatures = new HashSet<MacDuckDisassemblyNomenclatures>();
            MacDuckOperationNomenclatures = new HashSet<MacDuckOperationNomenclatures>();
            MacDuckOperations = new HashSet<MacDuckOperations>();
            PointDisposes = new HashSet<PointDisposes>();
            PointPlansNomGrp = new HashSet<PointPlans>();
            PointPlansObject1 = new HashSet<PointPlans>();
            PointReportMoneys = new HashSet<PointReportMoneys>();
            PointReportMoneysLogs = new HashSet<PointReportMoneysLogs>();
            PointReportNomsLogsNomGrp = new HashSet<PointReportNomsLogs>();
            PointReportNomsLogsNomObj = new HashSet<PointReportNomsLogs>();
            PointReportNomsLogsObject1 = new HashSet<PointReportNomsLogs>();
            PointReportNomsNomGrp = new HashSet<PointReportNoms>();
            PointReportNomsNomObj = new HashSet<PointReportNoms>();
            PointReportNomsObject1 = new HashSet<PointReportNoms>();
            PointStatNomsNomGrp = new HashSet<PointStatNoms>();
            PointStatNomsNomObj = new HashSet<PointStatNoms>();
            PointStatNomsObject1 = new HashSet<PointStatNoms>();
            PriceCompetitorAvgsNomObj = new HashSet<PriceCompetitorAvgs>();
            PriceCompetitorAvgsObject1 = new HashSet<PriceCompetitorAvgs>();
            PriceCompetitorVisionsNomObj = new HashSet<PriceCompetitorVisions>();
            PriceCompetitorVisionsObject1 = new HashSet<PriceCompetitorVisions>();
            PriceCompetitorsNomObj = new HashSet<PriceCompetitors>();
            PriceCompetitorsObject1 = new HashSet<PriceCompetitors>();
            PriceListFirsts = new HashSet<PriceListFirsts>();
            PriceListIndependentsNomObj = new HashSet<PriceListIndependents>();
            PriceListIndependentsObject = new HashSet<PriceListIndependents>();
            PriceListSecondsNomObj = new HashSet<PriceListSeconds>();
            PriceListSecondsPriceObj = new HashSet<PriceListSeconds>();
            Properties = new HashSet<Properties>();
            PropertyValueObjs = new HashSet<PropertyValueObjs>();
            PropertyValues = new HashSet<PropertyValues>();
            RemnantsFixationAnswers = new HashSet<RemnantsFixationAnswers>();
            RemnantsFixationBundles = new HashSet<RemnantsFixationBundles>();
            RemnantsFixationRequests = new HashSet<RemnantsFixationRequests>();
            SalarySettings = new HashSet<SalarySettings>();
        }

        public int Id { get; set; }
        public string ObjectName { get; set; }
        public int ObjectTypeId { get; set; }
        public int FilialId { get; set; }
        public int? AppUserId { get; set; }
        public bool NotDel { get; set; }
        public int? NomenclatureId { get; set; }
        public int? AddUserId { get; set; }
        public string AddUserIp { get; set; }
        public bool NomGrp { get; set; }
        public int? ParentId { get; set; }
        public string Name1C { get; set; }
        public int? LoadContragentId { get; set; }
        public double GeoLatitude { get; set; }
        public double GeoLongitude { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual LoadContragents LoadContragent { get; set; }
        public virtual Nomenclatures Nomenclature { get; set; }
        public virtual ObjectTypes ObjectType { get; set; }
        public virtual ICollection<CheckListCompleteds> CheckListCompleteds { get; set; }
        public virtual ICollection<CostExpedintureBindle> CostExpedintureBindle { get; set; }
        public virtual ICollection<CostExpenditureApprovement> CostExpenditureApprovement { get; set; }
        public virtual ICollection<Costs> Costs { get; set; }
        public virtual ICollection<CostsObjectsLimits> CostsObjectsLimits { get; set; }
        public virtual ICollection<FilialsColors> FilialsColors { get; set; }
        public virtual ICollection<LoadDocs> LoadDocs { get; set; }
        public virtual ICollection<LoadOsvs> LoadOsvs { get; set; }
        public virtual ICollection<LoadRevisionNots> LoadRevisionNots { get; set; }
        public virtual ICollection<LoadRevisionOks> LoadRevisionOks { get; set; }
        public virtual ICollection<LoadSchetLogs> LoadSchetLogs { get; set; }
        public virtual ICollection<LoadSchets> LoadSchets { get; set; }
        public virtual ICollection<LoadStat1C> LoadStat1C { get; set; }
        public virtual ICollection<LogisticDriverCarLogs> LogisticDriverCarLogs { get; set; }
        public virtual ICollection<LogisticDriverLogs> LogisticDriverLogs { get; set; }
        public virtual ICollection<LogisticDriverSummaryItems> LogisticDriverSummaryItemsObject1 { get; set; }
        public virtual ICollection<LogisticDriverSummaryItems> LogisticDriverSummaryItemsPoint { get; set; }
        public virtual ICollection<LogisticRouteSheets> LogisticRouteSheets { get; set; }
        public virtual ICollection<LogisticTrips> LogisticTripsPointIn { get; set; }
        public virtual ICollection<LogisticTrips> LogisticTripsPointOut { get; set; }
        public virtual ICollection<MacDuckAddedMoneys> MacDuckAddedMoneys { get; set; }
        public virtual ICollection<MacDuckClientBonuses> MacDuckClientBonuses { get; set; }
        public virtual ICollection<MacDuckClients> MacDuckClients { get; set; }
        public virtual ICollection<MacDuckDisassemblies> MacDuckDisassemblies { get; set; }
        public virtual ICollection<MacDuckDisassemblyNomenclatures> MacDuckDisassemblyNomenclatures { get; set; }
        public virtual ICollection<MacDuckOperationNomenclatures> MacDuckOperationNomenclatures { get; set; }
        public virtual ICollection<MacDuckOperations> MacDuckOperations { get; set; }
        public virtual ICollection<PointDisposes> PointDisposes { get; set; }
        public virtual ICollection<PointPlans> PointPlansNomGrp { get; set; }
        public virtual ICollection<PointPlans> PointPlansObject1 { get; set; }
        public virtual ICollection<PointReportMoneys> PointReportMoneys { get; set; }
        public virtual ICollection<PointReportMoneysLogs> PointReportMoneysLogs { get; set; }
        public virtual ICollection<PointReportNomsLogs> PointReportNomsLogsNomGrp { get; set; }
        public virtual ICollection<PointReportNomsLogs> PointReportNomsLogsNomObj { get; set; }
        public virtual ICollection<PointReportNomsLogs> PointReportNomsLogsObject1 { get; set; }
        public virtual ICollection<PointReportNoms> PointReportNomsNomGrp { get; set; }
        public virtual ICollection<PointReportNoms> PointReportNomsNomObj { get; set; }
        public virtual ICollection<PointReportNoms> PointReportNomsObject1 { get; set; }
        public virtual ICollection<PointStatNoms> PointStatNomsNomGrp { get; set; }
        public virtual ICollection<PointStatNoms> PointStatNomsNomObj { get; set; }
        public virtual ICollection<PointStatNoms> PointStatNomsObject1 { get; set; }
        public virtual ICollection<PriceCompetitorAvgs> PriceCompetitorAvgsNomObj { get; set; }
        public virtual ICollection<PriceCompetitorAvgs> PriceCompetitorAvgsObject1 { get; set; }
        public virtual ICollection<PriceCompetitorVisions> PriceCompetitorVisionsNomObj { get; set; }
        public virtual ICollection<PriceCompetitorVisions> PriceCompetitorVisionsObject1 { get; set; }
        public virtual ICollection<PriceCompetitors> PriceCompetitorsNomObj { get; set; }
        public virtual ICollection<PriceCompetitors> PriceCompetitorsObject1 { get; set; }
        public virtual ICollection<PriceListFirsts> PriceListFirsts { get; set; }
        public virtual ICollection<PriceListIndependents> PriceListIndependentsNomObj { get; set; }
        public virtual ICollection<PriceListIndependents> PriceListIndependentsObject { get; set; }
        public virtual ICollection<PriceListSeconds> PriceListSecondsNomObj { get; set; }
        public virtual ICollection<PriceListSeconds> PriceListSecondsPriceObj { get; set; }
        public virtual ICollection<Properties> Properties { get; set; }
        public virtual ICollection<PropertyValueObjs> PropertyValueObjs { get; set; }
        public virtual ICollection<PropertyValues> PropertyValues { get; set; }
        public virtual ICollection<RemnantsFixationAnswers> RemnantsFixationAnswers { get; set; }
        public virtual ICollection<RemnantsFixationBundles> RemnantsFixationBundles { get; set; }
        public virtual ICollection<RemnantsFixationRequests> RemnantsFixationRequests { get; set; }
        public virtual ICollection<SalarySettings> SalarySettings { get; set; }
    }
}
