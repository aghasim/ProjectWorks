using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class AppUsers
    {
        public AppUsers()
        {
            CalcStatLasts = new HashSet<CalcStatLasts>();
            CheckListBindles = new HashSet<CheckListBindles>();
            CheckListCompleteds = new HashSet<CheckListCompleteds>();
            CheckListMistakeWorkAproves = new HashSet<CheckListMistakeWorkAproves>();
            CheckListReadRights = new HashSet<CheckListReadRights>();
            CheckListWriteRights = new HashSet<CheckListWriteRights>();
            CheckLists = new HashSet<CheckLists>();
            ChecklistFreeFines = new HashSet<ChecklistFreeFines>();
            CostApprovements = new HashSet<CostApprovements>();
            CostExpedintureBindle = new HashSet<CostExpedintureBindle>();
            CostExpenditureApprovement = new HashSet<CostExpenditureApprovement>();
            Costs = new HashSet<Costs>();
            InvoicesAppUser = new HashSet<Invoices>();
            InvoicesCreator = new HashSet<Invoices>();
            LoadContracts = new HashSet<LoadContracts>();
            LoadContragents = new HashSet<LoadContragents>();
            LoadDocTypes = new HashSet<LoadDocTypes>();
            LoadDocs = new HashSet<LoadDocs>();
            LoadFirms = new HashSet<LoadFirms>();
            LoadOsvs = new HashSet<LoadOsvs>();
            LoadRevisionNots = new HashSet<LoadRevisionNots>();
            LoadRevisionOks = new HashSet<LoadRevisionOks>();
            LoadSchetLogs = new HashSet<LoadSchetLogs>();
            LoadSchetsAddUser = new HashSet<LoadSchets>();
            LoadSchetsManager = new HashSet<LoadSchets>();
            LoadSchetsUser = new HashSet<LoadSchets>();
            LoadStat1CManager = new HashSet<LoadStat1C>();
            LoadStat1CUser = new HashSet<LoadStat1C>();
            LoadStores = new HashSet<LoadStores>();
            LogisticDriverCarLogs = new HashSet<LogisticDriverCarLogs>();
            LogisticDriverLogs = new HashSet<LogisticDriverLogs>();
            LogisticDriverSummaryItems = new HashSet<LogisticDriverSummaryItems>();
            LogisticDriverTripLogs = new HashSet<LogisticDriverTripLogs>();
            LogisticTripGroups = new HashSet<LogisticTripGroups>();
            LogisticTrips = new HashSet<LogisticTrips>();
            MacDuckAddedMoneysCreator = new HashSet<MacDuckAddedMoneys>();
            MacDuckAddedMoneysSource = new HashSet<MacDuckAddedMoneys>();
            MacDuckClientBonuses = new HashSet<MacDuckClientBonuses>();
            MacDuckClientsCreator = new HashSet<MacDuckClients>();
            MacDuckClientsRegional = new HashSet<MacDuckClients>();
            MacDuckDisassemblies = new HashSet<MacDuckDisassemblies>();
            MacDuckOperations = new HashSet<MacDuckOperations>();
            MatchingPriceAccepts = new HashSet<MatchingPriceAccepts>();
            MatchingPrices = new HashSet<MatchingPrices>();
            Notifies = new HashSet<Notifies>();
            Object1 = new HashSet<Object1>();
            PointDisposes = new HashSet<PointDisposes>();
            PointPlans = new HashSet<PointPlans>();
            PointReportMoneysAddUser = new HashSet<PointReportMoneys>();
            PointReportMoneysLogs = new HashSet<PointReportMoneysLogs>();
            PointReportMoneysManager = new HashSet<PointReportMoneys>();
            PointReportNomsAddUser = new HashSet<PointReportNoms>();
            PointReportNomsLogsAddUser = new HashSet<PointReportNomsLogs>();
            PointReportNomsLogsManager = new HashSet<PointReportNomsLogs>();
            PointReportNomsManager = new HashSet<PointReportNoms>();
            PointStatNoms = new HashSet<PointStatNoms>();
            PriceCompetitorAvgs = new HashSet<PriceCompetitorAvgs>();
            PriceCompetitorVisionsAddUser = new HashSet<PriceCompetitorVisions>();
            PriceCompetitorVisionsManager = new HashSet<PriceCompetitorVisions>();
            PriceCompetitorsAddUser = new HashSet<PriceCompetitors>();
            PriceCompetitorsManager = new HashSet<PriceCompetitors>();
            PriceListDocsAddUser = new HashSet<PriceListDocs>();
            PriceListDocsManager = new HashSet<PriceListDocs>();
            RemnantsFixationAnswers = new HashSet<RemnantsFixationAnswers>();
            RemnantsFixationRequests = new HashSet<RemnantsFixationRequests>();
            RuleApprovements = new HashSet<RuleApprovements>();
            RuleAwaranesses = new HashSet<RuleAwaranesses>();
            Rules = new HashSet<Rules>();
            SalarySettings = new HashSet<SalarySettings>();
            TaskControllingPersons = new HashSet<TaskControllingPersons>();
            TaskDbModels = new HashSet<TaskDbModels>();
            TaskDiscussionOfTheTasks = new HashSet<TaskDiscussionOfTheTasks>();
            TaskUserTasks = new HashSet<TaskUserTasks>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserFio { get; set; }
        public string Email { get; set; }
        public string EmailConfirm { get; set; }
        public string Phone { get; set; }
        public string PhoneConfirm { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string Avatar { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime LastOnline { get; set; }
        public string ClientIp { get; set; }
        public string AccessToken { get; set; }
        public DateTime TokenExpire { get; set; }
        public string Session { get; set; }
        public int FailCount { get; set; }
        public bool IsBoss { get; set; }
        public int? BossId { get; set; }
        public int AppUserRoleId { get; set; }
        public int FilialId { get; set; }
        public int? AppUserDepartmentId { get; set; }
        public string UserNote { get; set; }
        public bool StatusOk { get; set; }
        public bool NotDel { get; set; }
        public int LastMsgId { get; set; }
        public string Name1C { get; set; }
        public int? LoadContractId { get; set; }

        public virtual AppUserDepartments AppUserDepartment { get; set; }
        public virtual AppUserRoles AppUserRole { get; set; }
        public virtual Filials Filial { get; set; }
        public virtual ICollection<CalcStatLasts> CalcStatLasts { get; set; }
        public virtual ICollection<CheckListBindles> CheckListBindles { get; set; }
        public virtual ICollection<CheckListCompleteds> CheckListCompleteds { get; set; }
        public virtual ICollection<CheckListMistakeWorkAproves> CheckListMistakeWorkAproves { get; set; }
        public virtual ICollection<CheckListReadRights> CheckListReadRights { get; set; }
        public virtual ICollection<CheckListWriteRights> CheckListWriteRights { get; set; }
        public virtual ICollection<CheckLists> CheckLists { get; set; }
        public virtual ICollection<ChecklistFreeFines> ChecklistFreeFines { get; set; }
        public virtual ICollection<CostApprovements> CostApprovements { get; set; }
        public virtual ICollection<CostExpedintureBindle> CostExpedintureBindle { get; set; }
        public virtual ICollection<CostExpenditureApprovement> CostExpenditureApprovement { get; set; }
        public virtual ICollection<Costs> Costs { get; set; }
        public virtual ICollection<Invoices> InvoicesAppUser { get; set; }
        public virtual ICollection<Invoices> InvoicesCreator { get; set; }
        public virtual ICollection<LoadContracts> LoadContracts { get; set; }
        public virtual ICollection<LoadContragents> LoadContragents { get; set; }
        public virtual ICollection<LoadDocTypes> LoadDocTypes { get; set; }
        public virtual ICollection<LoadDocs> LoadDocs { get; set; }
        public virtual ICollection<LoadFirms> LoadFirms { get; set; }
        public virtual ICollection<LoadOsvs> LoadOsvs { get; set; }
        public virtual ICollection<LoadRevisionNots> LoadRevisionNots { get; set; }
        public virtual ICollection<LoadRevisionOks> LoadRevisionOks { get; set; }
        public virtual ICollection<LoadSchetLogs> LoadSchetLogs { get; set; }
        public virtual ICollection<LoadSchets> LoadSchetsAddUser { get; set; }
        public virtual ICollection<LoadSchets> LoadSchetsManager { get; set; }
        public virtual ICollection<LoadSchets> LoadSchetsUser { get; set; }
        public virtual ICollection<LoadStat1C> LoadStat1CManager { get; set; }
        public virtual ICollection<LoadStat1C> LoadStat1CUser { get; set; }
        public virtual ICollection<LoadStores> LoadStores { get; set; }
        public virtual ICollection<LogisticDriverCarLogs> LogisticDriverCarLogs { get; set; }
        public virtual ICollection<LogisticDriverLogs> LogisticDriverLogs { get; set; }
        public virtual ICollection<LogisticDriverSummaryItems> LogisticDriverSummaryItems { get; set; }
        public virtual ICollection<LogisticDriverTripLogs> LogisticDriverTripLogs { get; set; }
        public virtual ICollection<LogisticTripGroups> LogisticTripGroups { get; set; }
        public virtual ICollection<LogisticTrips> LogisticTrips { get; set; }
        public virtual ICollection<MacDuckAddedMoneys> MacDuckAddedMoneysCreator { get; set; }
        public virtual ICollection<MacDuckAddedMoneys> MacDuckAddedMoneysSource { get; set; }
        public virtual ICollection<MacDuckClientBonuses> MacDuckClientBonuses { get; set; }
        public virtual ICollection<MacDuckClients> MacDuckClientsCreator { get; set; }
        public virtual ICollection<MacDuckClients> MacDuckClientsRegional { get; set; }
        public virtual ICollection<MacDuckDisassemblies> MacDuckDisassemblies { get; set; }
        public virtual ICollection<MacDuckOperations> MacDuckOperations { get; set; }
        public virtual ICollection<MatchingPriceAccepts> MatchingPriceAccepts { get; set; }
        public virtual ICollection<MatchingPrices> MatchingPrices { get; set; }
        public virtual ICollection<Notifies> Notifies { get; set; }
        public virtual ICollection<Object1> Object1 { get; set; }
        public virtual ICollection<PointDisposes> PointDisposes { get; set; }
        public virtual ICollection<PointPlans> PointPlans { get; set; }
        public virtual ICollection<PointReportMoneys> PointReportMoneysAddUser { get; set; }
        public virtual ICollection<PointReportMoneysLogs> PointReportMoneysLogs { get; set; }
        public virtual ICollection<PointReportMoneys> PointReportMoneysManager { get; set; }
        public virtual ICollection<PointReportNoms> PointReportNomsAddUser { get; set; }
        public virtual ICollection<PointReportNomsLogs> PointReportNomsLogsAddUser { get; set; }
        public virtual ICollection<PointReportNomsLogs> PointReportNomsLogsManager { get; set; }
        public virtual ICollection<PointReportNoms> PointReportNomsManager { get; set; }
        public virtual ICollection<PointStatNoms> PointStatNoms { get; set; }
        public virtual ICollection<PriceCompetitorAvgs> PriceCompetitorAvgs { get; set; }
        public virtual ICollection<PriceCompetitorVisions> PriceCompetitorVisionsAddUser { get; set; }
        public virtual ICollection<PriceCompetitorVisions> PriceCompetitorVisionsManager { get; set; }
        public virtual ICollection<PriceCompetitors> PriceCompetitorsAddUser { get; set; }
        public virtual ICollection<PriceCompetitors> PriceCompetitorsManager { get; set; }
        public virtual ICollection<PriceListDocs> PriceListDocsAddUser { get; set; }
        public virtual ICollection<PriceListDocs> PriceListDocsManager { get; set; }
        public virtual ICollection<RemnantsFixationAnswers> RemnantsFixationAnswers { get; set; }
        public virtual ICollection<RemnantsFixationRequests> RemnantsFixationRequests { get; set; }
        public virtual ICollection<RuleApprovements> RuleApprovements { get; set; }
        public virtual ICollection<RuleAwaranesses> RuleAwaranesses { get; set; }
        public virtual ICollection<Rules> Rules { get; set; }
        public virtual ICollection<SalarySettings> SalarySettings { get; set; }
        public virtual ICollection<TaskControllingPersons> TaskControllingPersons { get; set; }
        public virtual ICollection<TaskDbModels> TaskDbModels { get; set; }
        public virtual ICollection<TaskDiscussionOfTheTasks> TaskDiscussionOfTheTasks { get; set; }
        public virtual ICollection<TaskUserTasks> TaskUserTasks { get; set; }
    }
}
