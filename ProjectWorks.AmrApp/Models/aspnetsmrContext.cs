using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectWorks.AmrApp.Models
{
    public partial class aspnetsmrContext : DbContext
    {
        public aspnetsmrContext()
        {
        }

        public aspnetsmrContext(DbContextOptions<aspnetsmrContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessRules> AccessRules { get; set; }
        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<AppBlockedIps> AppBlockedIps { get; set; }
        public virtual DbSet<AppConfigGrps> AppConfigGrps { get; set; }
        public virtual DbSet<AppConfigs> AppConfigs { get; set; }
        public virtual DbSet<AppFuncRoles> AppFuncRoles { get; set; }
        public virtual DbSet<AppHistoryСhange> AppHistoryСhange { get; set; }
        public virtual DbSet<AppLoggingActions> AppLoggingActions { get; set; }
        public virtual DbSet<AppLoggingDbs> AppLoggingDbs { get; set; }
        public virtual DbSet<AppLoginAudits> AppLoginAudits { get; set; }
        public virtual DbSet<AppMenus> AppMenus { get; set; }
        public virtual DbSet<AppMessages> AppMessages { get; set; }
        public virtual DbSet<AppUserAccesses> AppUserAccesses { get; set; }
        public virtual DbSet<AppUserDepartmentRoles> AppUserDepartmentRoles { get; set; }
        public virtual DbSet<AppUserDepartments> AppUserDepartments { get; set; }
        public virtual DbSet<AppUserRoles> AppUserRoles { get; set; }
        public virtual DbSet<AppUsers> AppUsers { get; set; }
        public virtual DbSet<Business1C> Business1C { get; set; }
        public virtual DbSet<CalcStatLasts> CalcStatLasts { get; set; }
        public virtual DbSet<CheckListAnswers> CheckListAnswers { get; set; }
        public virtual DbSet<CheckListBindles> CheckListBindles { get; set; }
        public virtual DbSet<CheckListCompleteds> CheckListCompleteds { get; set; }
        public virtual DbSet<CheckListFuncRoleBundles> CheckListFuncRoleBundles { get; set; }
        public virtual DbSet<CheckListMistakeWorkAproves> CheckListMistakeWorkAproves { get; set; }
        public virtual DbSet<CheckListQuestionGroups> CheckListQuestionGroups { get; set; }
        public virtual DbSet<CheckListQuestions> CheckListQuestions { get; set; }
        public virtual DbSet<CheckListQusetionVariants> CheckListQusetionVariants { get; set; }
        public virtual DbSet<CheckListReadRights> CheckListReadRights { get; set; }
        public virtual DbSet<CheckListRolePermissions> CheckListRolePermissions { get; set; }
        public virtual DbSet<CheckListWeekDays> CheckListWeekDays { get; set; }
        public virtual DbSet<CheckListWriteRights> CheckListWriteRights { get; set; }
        public virtual DbSet<CheckLists> CheckLists { get; set; }
        public virtual DbSet<CheckMoneyDbs> CheckMoneyDbs { get; set; }
        public virtual DbSet<ChecklistFreeFines> ChecklistFreeFines { get; set; }
        public virtual DbSet<Constants> Constants { get; set; }
        public virtual DbSet<CostApprovements> CostApprovements { get; set; }
        public virtual DbSet<CostExpedintureBindle> CostExpedintureBindle { get; set; }
        public virtual DbSet<CostExpenditureApprovement> CostExpenditureApprovement { get; set; }
        public virtual DbSet<Costs> Costs { get; set; }
        public virtual DbSet<CostsObjectsLimits> CostsObjectsLimits { get; set; }
        public virtual DbSet<DashBoardModelDbs> DashBoardModelDbs { get; set; }
        public virtual DbSet<DebsReceivables> DebsReceivables { get; set; }
        public virtual DbSet<ErrorLists> ErrorLists { get; set; }
        public virtual DbSet<EveryDayCalculateRemnants> EveryDayCalculateRemnants { get; set; }
        public virtual DbSet<Exports> Exports { get; set; }
        public virtual DbSet<Filials> Filials { get; set; }
        public virtual DbSet<FilialsColors> FilialsColors { get; set; }
        public virtual DbSet<Finrezs> Finrezs { get; set; }
        public virtual DbSet<FixingModels> FixingModels { get; set; }
        public virtual DbSet<FlowOfFunds> FlowOfFunds { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<HelpImages> HelpImages { get; set; }
        public virtual DbSet<Helps> Helps { get; set; }
        public virtual DbSet<InvoiceNomenclatures> InvoiceNomenclatures { get; set; }
        public virtual DbSet<InvoiceZeroShipments> InvoiceZeroShipments { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<LoadContracts> LoadContracts { get; set; }
        public virtual DbSet<LoadContragents> LoadContragents { get; set; }
        public virtual DbSet<LoadDocTypes> LoadDocTypes { get; set; }
        public virtual DbSet<LoadDocs> LoadDocs { get; set; }
        public virtual DbSet<LoadFirms> LoadFirms { get; set; }
        public virtual DbSet<LoadOsvs> LoadOsvs { get; set; }
        public virtual DbSet<LoadRevisionNots> LoadRevisionNots { get; set; }
        public virtual DbSet<LoadRevisionOks> LoadRevisionOks { get; set; }
        public virtual DbSet<LoadSchetLogs> LoadSchetLogs { get; set; }
        public virtual DbSet<LoadSchets> LoadSchets { get; set; }
        public virtual DbSet<LoadStat1C> LoadStat1C { get; set; }
        public virtual DbSet<LoadStores> LoadStores { get; set; }
        public virtual DbSet<LogisticDisposableCars> LogisticDisposableCars { get; set; }
        public virtual DbSet<LogisticDriverCarLogs> LogisticDriverCarLogs { get; set; }
        public virtual DbSet<LogisticDriverLogs> LogisticDriverLogs { get; set; }
        public virtual DbSet<LogisticDriverSummaryItems> LogisticDriverSummaryItems { get; set; }
        public virtual DbSet<LogisticDriverTripLogs> LogisticDriverTripLogs { get; set; }
        public virtual DbSet<LogisticRouteSheets> LogisticRouteSheets { get; set; }
        public virtual DbSet<LogisticRouteSheetsGroups> LogisticRouteSheetsGroups { get; set; }
        public virtual DbSet<LogisticTripGroups> LogisticTripGroups { get; set; }
        public virtual DbSet<LogisticTrips> LogisticTrips { get; set; }
        public virtual DbSet<LogsLoadFiles> LogsLoadFiles { get; set; }
        public virtual DbSet<MacDuckAddedMoneys> MacDuckAddedMoneys { get; set; }
        public virtual DbSet<MacDuckClientBonuses> MacDuckClientBonuses { get; set; }
        public virtual DbSet<MacDuckClients> MacDuckClients { get; set; }
        public virtual DbSet<MacDuckDisassemblies> MacDuckDisassemblies { get; set; }
        public virtual DbSet<MacDuckDisassemblyNomenclatures> MacDuckDisassemblyNomenclatures { get; set; }
        public virtual DbSet<MacDuckOperationNomenclatures> MacDuckOperationNomenclatures { get; set; }
        public virtual DbSet<MacDuckOperations> MacDuckOperations { get; set; }
        public virtual DbSet<MatchingPriceAccepts> MatchingPriceAccepts { get; set; }
        public virtual DbSet<MatchingPriceSettings> MatchingPriceSettings { get; set; }
        public virtual DbSet<MatchingPrices> MatchingPrices { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<NomenclatureBus> NomenclatureBus { get; set; }
        public virtual DbSet<Nomenclatures> Nomenclatures { get; set; }
        public virtual DbSet<Notifies> Notifies { get; set; }
        public virtual DbSet<Object1> Object1 { get; set; }
        public virtual DbSet<ObjectTypes> ObjectTypes { get; set; }
        public virtual DbSet<PointDisposes> PointDisposes { get; set; }
        public virtual DbSet<PointPlans> PointPlans { get; set; }
        public virtual DbSet<PointReportMoneys> PointReportMoneys { get; set; }
        public virtual DbSet<PointReportMoneysLogs> PointReportMoneysLogs { get; set; }
        public virtual DbSet<PointReportNoms> PointReportNoms { get; set; }
        public virtual DbSet<PointReportNomsLogs> PointReportNomsLogs { get; set; }
        public virtual DbSet<PointStatNoms> PointStatNoms { get; set; }
        public virtual DbSet<PriceCompetitorAvgs> PriceCompetitorAvgs { get; set; }
        public virtual DbSet<PriceCompetitorVisions> PriceCompetitorVisions { get; set; }
        public virtual DbSet<PriceCompetitors> PriceCompetitors { get; set; }
        public virtual DbSet<PriceListDocs> PriceListDocs { get; set; }
        public virtual DbSet<PriceListFirsts> PriceListFirsts { get; set; }
        public virtual DbSet<PriceListIndependents> PriceListIndependents { get; set; }
        public virtual DbSet<PriceListSeconds> PriceListSeconds { get; set; }
        public virtual DbSet<PriceTypes> PriceTypes { get; set; }
        public virtual DbSet<Properties> Properties { get; set; }
        public virtual DbSet<PropertyValParams> PropertyValParams { get; set; }
        public virtual DbSet<PropertyValTypes> PropertyValTypes { get; set; }
        public virtual DbSet<PropertyValueObjs> PropertyValueObjs { get; set; }
        public virtual DbSet<PropertyValues> PropertyValues { get; set; }
        public virtual DbSet<Realizations> Realizations { get; set; }
        public virtual DbSet<RegionCities> RegionCities { get; set; }
        public virtual DbSet<RegionLands> RegionLands { get; set; }
        public virtual DbSet<RegionObls> RegionObls { get; set; }
        public virtual DbSet<Reitings> Reitings { get; set; }
        public virtual DbSet<RemnantsFixationAnswerDetails> RemnantsFixationAnswerDetails { get; set; }
        public virtual DbSet<RemnantsFixationAnswers> RemnantsFixationAnswers { get; set; }
        public virtual DbSet<RemnantsFixationBundles> RemnantsFixationBundles { get; set; }
        public virtual DbSet<RemnantsFixationMaterials> RemnantsFixationMaterials { get; set; }
        public virtual DbSet<RemnantsFixationRequests> RemnantsFixationRequests { get; set; }
        public virtual DbSet<RuleApprovements> RuleApprovements { get; set; }
        public virtual DbSet<RuleAwaranesses> RuleAwaranesses { get; set; }
        public virtual DbSet<RuleObjectBindles> RuleObjectBindles { get; set; }
        public virtual DbSet<RuleRoleBindles> RuleRoleBindles { get; set; }
        public virtual DbSet<RuleTypes> RuleTypes { get; set; }
        public virtual DbSet<Rules> Rules { get; set; }
        public virtual DbSet<SalarySettings> SalarySettings { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<StopLists> StopLists { get; set; }
        public virtual DbSet<TaskControllingPersons> TaskControllingPersons { get; set; }
        public virtual DbSet<TaskDbModels> TaskDbModels { get; set; }
        public virtual DbSet<TaskDiscussionOfTheTasks> TaskDiscussionOfTheTasks { get; set; }
        public virtual DbSet<TaskStatusHistories> TaskStatusHistories { get; set; }
        public virtual DbSet<TaskUserTasks> TaskUserTasks { get; set; }
        public virtual DbSet<UnloadColors> UnloadColors { get; set; }
        public virtual DbSet<UserIntermediates> UserIntermediates { get; set; }

        // Unable to generate entity type for table 'HangFire.Counter'. Please see the warning messages.

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=localhost;Database=aspnet-smr;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<AccessRules>(entity =>
            {
                entity.HasIndex(e => e.AppUserDepartmentId)
                    .HasName("IX_AppUserDepartmentID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ObjectTypeId)
                    .HasName("IX_ObjectTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessKey).HasMaxLength(255);

                entity.Property(e => e.AppUserDepartmentId).HasColumnName("AppUserDepartmentID");

                entity.Property(e => e.BoolId).HasColumnName("BoolID");

                entity.Property(e => e.BoolVal).HasDefaultValueSql("((0))");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.FilterId).HasColumnName("FilterID");

                entity.Property(e => e.NotObj).HasMaxLength(4000);

                entity.Property(e => e.ObjKey).HasMaxLength(4000);

                entity.Property(e => e.ObjectTypeId).HasColumnName("ObjectTypeID");

                entity.Property(e => e.PropKey).HasMaxLength(2000);

                entity.Property(e => e.PropWrite).HasMaxLength(2000);

                entity.Property(e => e.RuleKey).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ValObjId).HasColumnName("ValObjID");

                entity.Property(e => e.ValObjPropId).HasColumnName("ValObjPropID");

                entity.HasOne(d => d.AppUserDepartment)
                    .WithMany(p => p.AccessRules)
                    .HasForeignKey(d => d.AppUserDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AccessRules_dbo.AppUserDepartments_AppUserDepartmentID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.AccessRules)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AccessRules_dbo.Filials_FilialID");

                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.AccessRules)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AccessRules_dbo.ObjectTypes_ObjectTypeID");
            });

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppBlockedIps>(entity =>
            {
                entity.ToTable("AppBlockedIPs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientIp)
                    .HasColumnName("ClientIP")
                    .HasMaxLength(32);

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AppConfigGrps>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<AppConfigs>(entity =>
            {
                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.GrpId)
                    .HasName("IX_GrpID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.GrpId).HasColumnName("GrpID");

                entity.Property(e => e.Param)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.SelectList).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(64);

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.AppConfigs)
                    .HasForeignKey(d => d.FilialId)
                    .HasConstraintName("FK_dbo.AppConfigs_dbo.Filials_FilialID");

                entity.HasOne(d => d.Grp)
                    .WithMany(p => p.AppConfigs)
                    .HasForeignKey(d => d.GrpId)
                    .HasConstraintName("FK_dbo.AppConfigs_dbo.AppConfigGrps_GrpID");
            });

            modelBuilder.Entity<AppFuncRoles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DopRoles).HasMaxLength(128);

                entity.Property(e => e.IsDirector).HasColumnName("isDirector");

                entity.Property(e => e.IsGlobal).HasColumnName("isGlobal");

                entity.Property(e => e.Key).HasMaxLength(32);

                entity.Property(e => e.MenuAccess).HasMaxLength(512);

                entity.Property(e => e.Name).HasMaxLength(32);

                entity.Property(e => e.NotUnionTypes).HasMaxLength(128);
            });

            modelBuilder.Entity<AppHistoryСhange>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.FieldName).HasMaxLength(32);

                entity.Property(e => e.NewValue).HasMaxLength(256);

                entity.Property(e => e.OldValue).HasMaxLength(256);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Table).HasMaxLength(32);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<AppLoggingActions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientIp)
                    .HasColumnName("ClientIP")
                    .HasMaxLength(32);

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rem).HasMaxLength(32);

                entity.Property(e => e.UrlId)
                    .HasColumnName("UrlID")
                    .HasMaxLength(64);

                entity.Property(e => e.UrlPath).HasMaxLength(128);

                entity.Property(e => e.UrlQuery).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserLogin).HasMaxLength(32);
            });

            modelBuilder.Entity<AppLoggingDbs>(entity =>
            {
                entity.ToTable("AppLoggingDBs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Command).HasMaxLength(32);

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ok).HasColumnName("OK");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Table).HasMaxLength(32);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<AppLoginAudits>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientIp)
                    .HasColumnName("ClientIP")
                    .HasMaxLength(32);

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserLogin).HasMaxLength(32);
            });

            modelBuilder.Entity<AppMenus>(entity =>
            {
                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.FullKey).HasMaxLength(255);

                entity.Property(e => e.IsOk).HasColumnName("isOk");

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LinkURL")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SortIndex).HasColumnName("sortIndex");

                entity.Property(e => e.SortKey).HasMaxLength(128);

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.AppMenus)
                    .HasForeignKey(d => d.FilialId)
                    .HasConstraintName("FK_dbo.AppMenus_dbo.Filials_FilialID");
            });

            modelBuilder.Entity<AppMessages>(entity =>
            {
                entity.HasKey(e => e.MsgId)
                    .HasName("PK_dbo.AppMessages");

                entity.Property(e => e.MsgId).HasColumnName("MsgID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.IsOk).HasColumnName("isOK");

                entity.Property(e => e.LinkName).HasMaxLength(32);

                entity.Property(e => e.LinkUrl)
                    .HasColumnName("LinkURL")
                    .HasMaxLength(128);

                entity.Property(e => e.MsgText)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");
            });

            modelBuilder.Entity<AppUserAccesses>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Key).HasMaxLength(32);

                entity.Property(e => e.Name).HasMaxLength(32);
            });

            modelBuilder.Entity<AppUserDepartmentRoles>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.FuncRoleId)
                    .HasName("IX_FuncRoleID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.FuncRoleId).HasColumnName("FuncRoleID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.AppUserDepartmentRoles)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AppUserDepartmentRoles_dbo.AppUserDepartments_DepartmentID");

                entity.HasOne(d => d.FuncRole)
                    .WithMany(p => p.AppUserDepartmentRoles)
                    .HasForeignKey(d => d.FuncRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AppUserDepartmentRoles_dbo.AppFuncRoles_FuncRoleID");
            });

            modelBuilder.Entity<AppUserDepartments>(entity =>
            {
                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.AddUserIp).HasColumnName("AddUserIP");

                entity.Property(e => e.BossId).HasColumnName("BossID");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SortIndex).HasColumnName("sortIndex");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.AppUserDepartments)
                    .HasForeignKey(d => d.FilialId)
                    .HasConstraintName("FK_dbo.AppUserDepartments_dbo.Filials_FilialID");
            });

            modelBuilder.Entity<AppUserRoles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(32);
            });

            modelBuilder.Entity<AppUsers>(entity =>
            {
                entity.HasIndex(e => e.AppUserDepartmentId)
                    .HasName("IX_AppUserDepartmentID");

                entity.HasIndex(e => e.AppUserRoleId)
                    .HasName("IX_AppUserRoleID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessToken).HasMaxLength(100);

                entity.Property(e => e.AppUserDepartmentId).HasColumnName("AppUserDepartmentID");

                entity.Property(e => e.AppUserRoleId).HasColumnName("AppUserRoleID");

                entity.Property(e => e.Avatar).HasMaxLength(100);

                entity.Property(e => e.BossId).HasColumnName("BossID");

                entity.Property(e => e.ClientIp)
                    .HasColumnName("ClientIP")
                    .HasMaxLength(32);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmailConfirm).HasMaxLength(50);

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.IsBoss).HasColumnName("isBoss");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastMsgId).HasColumnName("LastMsgID");

                entity.Property(e => e.LastOnline).HasColumnType("datetime");

                entity.Property(e => e.LoadContractId).HasColumnName("LoadContractID");

                entity.Property(e => e.Name1C).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(32);

                entity.Property(e => e.PhoneConfirm).HasMaxLength(32);

                entity.Property(e => e.Session).HasMaxLength(50);

                entity.Property(e => e.StatusOk).HasColumnName("StatusOK");

                entity.Property(e => e.TokenExpire).HasColumnType("datetime");

                entity.Property(e => e.UserFio)
                    .IsRequired()
                    .HasColumnName("UserFIO")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.UserNote).HasMaxLength(255);

                entity.HasOne(d => d.AppUserDepartment)
                    .WithMany(p => p.AppUsers)
                    .HasForeignKey(d => d.AppUserDepartmentId)
                    .HasConstraintName("FK_dbo.AppUsers_dbo.AppUserDepartments_AppUserDepartmentID");

                entity.HasOne(d => d.AppUserRole)
                    .WithMany(p => p.AppUsers)
                    .HasForeignKey(d => d.AppUserRoleId)
                    .HasConstraintName("FK_dbo.AppUsers_dbo.AppUserRoles_AppUserRoleID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.AppUsers)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AppUsers_dbo.Filials_FilialID");
            });

            modelBuilder.Entity<Business1C>(entity =>
            {
                entity.HasIndex(e => e.BusinessId)
                    .HasName("IX_BusinessID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.Name1C)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Business1C)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_dbo.Business1C_dbo.PropertyValParams_BusinessID");
            });

            modelBuilder.Entity<CalcStatLasts>(entity =>
            {
                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateLast).HasColumnType("datetime");

                entity.Property(e => e.DateLastFinish).HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.TableName).HasMaxLength(32);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.CalcStatLasts)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CalcStatLasts_dbo.Filials_FilialID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CalcStatLasts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.CalcStatLasts_dbo.AppUsers_AddUser_ID");
            });

            modelBuilder.Entity<CheckListAnswers>(entity =>
            {
                entity.HasKey(e => e.AnswerId)
                    .HasName("PK_dbo.CheckListAnswers");

                entity.HasIndex(e => e.CheckListCompletedId)
                    .HasName("IX_CheckListCompletedId");

                entity.HasIndex(e => e.CheckListQuestionId)
                    .HasName("IX_CheckListQuestionId");

                entity.HasIndex(e => e.CheckListQusetionVariantId)
                    .HasName("IX_CheckListQusetionVariantId");

                entity.Property(e => e.AnswerText).HasMaxLength(1000);

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.ImgAnswerPath).HasMaxLength(500);

                entity.Property(e => e.ImgMistakeWorkPath).HasMaxLength(500);

                entity.Property(e => e.IsItWrong).HasColumnName("isItWrong");

                entity.Property(e => e.MistakesWork).HasMaxLength(1000);

                entity.HasOne(d => d.CheckListCompleted)
                    .WithMany(p => p.CheckListAnswers)
                    .HasForeignKey(d => d.CheckListCompletedId)
                    .HasConstraintName("FK_dbo.CheckListAnswers_dbo.CheckListCompleteds_CheckListCompletedId");

                entity.HasOne(d => d.CheckListQuestion)
                    .WithMany(p => p.CheckListAnswers)
                    .HasForeignKey(d => d.CheckListQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListAnswers_dbo.CheckListQuestions_CheckListQuestionId");

                entity.HasOne(d => d.CheckListQusetionVariant)
                    .WithMany(p => p.CheckListAnswers)
                    .HasForeignKey(d => d.CheckListQusetionVariantId)
                    .HasConstraintName("FK_dbo.CheckListAnswers_dbo.CheckListQusetionVariants_CheckListQusetionVariant_VariantId");
            });

            modelBuilder.Entity<CheckListBindles>(entity =>
            {
                entity.HasKey(e => e.CheckListBindleId)
                    .HasName("PK_dbo.CheckListBindles");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.CheckListId)
                    .HasName("IX_CheckListId");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.CheckListBindles)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListBindles_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.CheckList)
                    .WithMany(p => p.CheckListBindles)
                    .HasForeignKey(d => d.CheckListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListBindles_dbo.CheckLists_CheckListId");
            });

            modelBuilder.Entity<CheckListCompleteds>(entity =>
            {
                entity.HasKey(e => e.CheckListCompletedId)
                    .HasName("PK_dbo.CheckListCompleteds");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.CheckListId)
                    .HasName("IX_CheckListId");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasMaxLength(125);

                entity.Property(e => e.Longitude).HasMaxLength(125);

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.CheckListCompleteds)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListCompleteds_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.CheckList)
                    .WithMany(p => p.CheckListCompleteds)
                    .HasForeignKey(d => d.CheckListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListCompleteds_dbo.CheckLists_CheckListId");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.CheckListCompleteds)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListCompleteds_dbo.Object1_Object1Id");
            });

            modelBuilder.Entity<CheckListFuncRoleBundles>(entity =>
            {
                entity.HasIndex(e => e.AppFuncRoleId)
                    .HasName("IX_AppFuncRoleId");

                entity.HasIndex(e => e.CheckListId)
                    .HasName("IX_CheckListId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AppFuncRole)
                    .WithMany(p => p.CheckListFuncRoleBundles)
                    .HasForeignKey(d => d.AppFuncRoleId)
                    .HasConstraintName("FK_dbo.CheckListFuncRoleBundles_dbo.AppFuncRoles_AppFuncRoleId");

                entity.HasOne(d => d.CheckList)
                    .WithMany(p => p.CheckListFuncRoleBundles)
                    .HasForeignKey(d => d.CheckListId)
                    .HasConstraintName("FK_dbo.CheckListFuncRoleBundles_dbo.CheckLists_CheckListId");
            });

            modelBuilder.Entity<CheckListMistakeWorkAproves>(entity =>
            {
                entity.HasKey(e => e.AproveId)
                    .HasName("PK_dbo.CheckListMistakeWorkAproves");

                entity.HasIndex(e => e.AnswerId)
                    .HasName("IX_AnswerId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.AproveDate).HasColumnType("datetime");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.CheckListMistakeWorkAproves)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListMistakeWorkAproves_dbo.CheckListAnswers_AnswerId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CheckListMistakeWorkAproves)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListMistakeWorkAproves_dbo.AppUsers_UserId");
            });

            modelBuilder.Entity<CheckListQuestionGroups>(entity =>
            {
                entity.HasKey(e => e.QuestionGroupId)
                    .HasName("PK_dbo.CheckListQuestionGroups");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.GroupName).HasMaxLength(255);
            });

            modelBuilder.Entity<CheckListQuestions>(entity =>
            {
                entity.HasKey(e => e.CheckListQuestionId)
                    .HasName("PK_dbo.CheckListQuestions");

                entity.HasIndex(e => e.CheckListId)
                    .HasName("IX_CheckListId");

                entity.HasIndex(e => e.QuestionGroupId)
                    .HasName("IX_QuestionGroupId");

                entity.Property(e => e.ImgDescription).HasMaxLength(255);

                entity.Property(e => e.ImgQuestionPath).HasMaxLength(255);

                entity.Property(e => e.QusetionText).HasMaxLength(500);

                entity.Property(e => e.Variant1).HasMaxLength(100);

                entity.Property(e => e.Variant2).HasMaxLength(100);

                entity.Property(e => e.Variant3).HasMaxLength(100);

                entity.Property(e => e.Variant4).HasMaxLength(100);

                entity.Property(e => e.Variant5).HasMaxLength(100);

                entity.Property(e => e.Variant6).HasMaxLength(100);

                entity.HasOne(d => d.CheckList)
                    .WithMany(p => p.CheckListQuestions)
                    .HasForeignKey(d => d.CheckListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListQuestions_dbo.CheckLists_CheckListId");

                entity.HasOne(d => d.QuestionGroup)
                    .WithMany(p => p.CheckListQuestions)
                    .HasForeignKey(d => d.QuestionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListQuestions_dbo.CheckListQuestionGroups_QuestionGroupId");
            });

            modelBuilder.Entity<CheckListQusetionVariants>(entity =>
            {
                entity.HasKey(e => e.VariantId)
                    .HasName("PK_dbo.CheckListQusetionVariants");

                entity.HasIndex(e => e.CheckListQuestionId)
                    .HasName("IX_CheckListQuestionId");

                entity.Property(e => e.VarintText).HasMaxLength(100);

                entity.HasOne(d => d.CheckListQuestion)
                    .WithMany(p => p.CheckListQusetionVariants)
                    .HasForeignKey(d => d.CheckListQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListQusetionVariants_dbo.CheckListQuestions_CheckListQuestionId");
            });

            modelBuilder.Entity<CheckListReadRights>(entity =>
            {
                entity.HasKey(e => e.CheclListReadRightId)
                    .HasName("PK_dbo.CheckListReadRights");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.CheckListId)
                    .HasName("IX_CheckListId");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.CheckListReadRights)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListReadRights_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.CheckList)
                    .WithMany(p => p.CheckListReadRights)
                    .HasForeignKey(d => d.CheckListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListReadRights_dbo.CheckLists_CheckListId");
            });

            modelBuilder.Entity<CheckListRolePermissions>(entity =>
            {
                entity.HasIndex(e => e.AppFuncRoleId)
                    .HasName("IX_AppFuncRoleId");

                entity.HasIndex(e => e.CheckListId)
                    .HasName("IX_CheckListId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.AppFuncRole)
                    .WithMany(p => p.CheckListRolePermissions)
                    .HasForeignKey(d => d.AppFuncRoleId)
                    .HasConstraintName("FK_dbo.CheckListRolePermissions_dbo.AppFuncRoles_AppFuncRoleId");

                entity.HasOne(d => d.CheckList)
                    .WithMany(p => p.CheckListRolePermissions)
                    .HasForeignKey(d => d.CheckListId)
                    .HasConstraintName("FK_dbo.CheckListRolePermissions_dbo.CheckLists_CheckListId");
            });

            modelBuilder.Entity<CheckListWeekDays>(entity =>
            {
                entity.HasKey(e => e.CheckListWeekDayId)
                    .HasName("PK_dbo.CheckListWeekDays");

                entity.HasIndex(e => e.CheckListId)
                    .HasName("IX_CheckListId");

                entity.Property(e => e.WeekDay).HasColumnName("weekDay");

                entity.HasOne(d => d.CheckList)
                    .WithMany(p => p.CheckListWeekDays)
                    .HasForeignKey(d => d.CheckListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListWeekDays_dbo.CheckLists_CheckListId");
            });

            modelBuilder.Entity<CheckListWriteRights>(entity =>
            {
                entity.HasKey(e => e.CheclListReadRightId)
                    .HasName("PK_dbo.CheckListWriteRights");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.CheckListId)
                    .HasName("IX_CheckListId");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.CheckListWriteRights)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListWriteRights_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.CheckList)
                    .WithMany(p => p.CheckListWriteRights)
                    .HasForeignKey(d => d.CheckListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckListWriteRights_dbo.CheckLists_CheckListId");
            });

            modelBuilder.Entity<CheckLists>(entity =>
            {
                entity.HasKey(e => e.CheckListId)
                    .HasName("PK_dbo.CheckLists");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.ObjectTypeId)
                    .HasName("IX_ObjectTypeId");

                entity.Property(e => e.CheckListName).HasMaxLength(255);

                entity.Property(e => e.EndPeriod).HasColumnType("datetime");

                entity.Property(e => e.StartPeriod).HasColumnType("datetime");

                entity.Property(e => e.Term).HasColumnType("datetime");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.CheckLists)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckLists_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.CheckLists)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CheckLists_dbo.ObjectTypes_ObjectTypeId");
            });

            modelBuilder.Entity<CheckMoneyDbs>(entity =>
            {
                entity.ToTable("CheckMoneyDBs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CalcReman).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CountPlus).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateLastRemov).HasColumnType("datetime");

                entity.Property(e => e.DateToNull).HasColumnType("datetime");

                entity.Property(e => e.OutSumm).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SumRemamns).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ChecklistFreeFines>(entity =>
            {
                entity.HasKey(e => e.FineId)
                    .HasName("PK_dbo.ChecklistFreeFines");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.Property(e => e.CauseFine).HasMaxLength(512);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FineSum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WhomFineName).HasMaxLength(255);

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.ChecklistFreeFines)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ChecklistFreeFines_dbo.AppUsers_AppUserId");
            });

            modelBuilder.Entity<Constants>(entity =>
            {
                entity.Property(e => e.MarginLchm).HasColumnName("MarginLCHM");

                entity.Property(e => e.MarginLcm).HasColumnName("MarginLCM");

                entity.Property(e => e.MarginRzm).HasColumnName("MarginRZM");

                entity.Property(e => e.VolumeLchm).HasColumnName("VolumeLCHM");

                entity.Property(e => e.VolumeLcm).HasColumnName("VolumeLCM");

                entity.Property(e => e.VolumeRzm).HasColumnName("VolumeRZM");
            });

            modelBuilder.Entity<CostApprovements>(entity =>
            {
                entity.HasKey(e => e.CostApprovementId)
                    .HasName("PK_dbo.CostApprovements");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.CostId)
                    .HasName("IX_CostId");

                entity.Property(e => e.AproveDate).HasColumnType("datetime");

                entity.Property(e => e.IsAprove).HasColumnName("isAprove");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.CostApprovements)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CostApprovements_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Cost)
                    .WithMany(p => p.CostApprovements)
                    .HasForeignKey(d => d.CostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CostApprovements_dbo.Costs_CostId");
            });

            modelBuilder.Entity<CostExpedintureBindle>(entity =>
            {
                entity.HasKey(e => e.BindleId)
                    .HasName("PK_dbo.CostExpedintureBindle");

                entity.HasIndex(e => e.AppFuncRoleId)
                    .HasName("IX_AppFuncRoleId");

                entity.HasIndex(e => e.AppUserDepartmentId)
                    .HasName("IX_AppUserDepartmentId");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.HasIndex(e => e.ObjectTypeId)
                    .HasName("IX_ObjectTypeId");

                entity.HasOne(d => d.AppFuncRole)
                    .WithMany(p => p.CostExpedintureBindle)
                    .HasForeignKey(d => d.AppFuncRoleId)
                    .HasConstraintName("FK_dbo.BindleForExpenditures_dbo.AppFuncRoles_AppFuncRoleId");

                entity.HasOne(d => d.AppUserDepartment)
                    .WithMany(p => p.CostExpedintureBindle)
                    .HasForeignKey(d => d.AppUserDepartmentId)
                    .HasConstraintName("FK_dbo.BindleForExpenditures_dbo.AppUserDepartments_AppUserDepartmentId");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.CostExpedintureBindle)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.BindleForExpenditures_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.CostExpedintureBindle)
                    .HasForeignKey(d => d.Object1Id)
                    .HasConstraintName("FK_dbo.BindleForExpenditures_dbo.Object1_Object1Id");

                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.CostExpedintureBindle)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .HasConstraintName("FK_dbo.BindleForExpenditures_dbo.ObjectTypes_ObjectTypeId");
            });

            modelBuilder.Entity<CostExpenditureApprovement>(entity =>
            {
                entity.HasKey(e => e.CostApprovementId)
                    .HasName("PK_dbo.CostExpenditureApprovement");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.Property(e => e.AproveDate).HasColumnType("datetime");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.CostExpenditureApprovement)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ExpenditureApprovements_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.CostExpenditureApprovement)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ExpenditureApprovements_dbo.Object1_Object1Id");
            });

            modelBuilder.Entity<Costs>(entity =>
            {
                entity.HasKey(e => e.CostId)
                    .HasName("PK_dbo.Costs");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CostTitle).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.PhotoPath).HasMaxLength(255);

                entity.Property(e => e.Sum).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.Costs)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Costs_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.Costs)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Costs_dbo.Object1_Object1Id");
            });

            modelBuilder.Entity<CostsObjectsLimits>(entity =>
            {
                entity.HasKey(e => e.CostsObjectsLimitId)
                    .HasName("PK_dbo.CostsObjectsLimits");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.CostsObjectsLimits)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CostsObjectsLimits_dbo.Object1_Object1Id");
            });

            modelBuilder.Entity<DashBoardModelDbs>(entity =>
            {
                entity.ToTable("DashBoardModelDBs");
            });

            modelBuilder.Entity<DebsReceivables>(entity =>
            {
                entity.Property(e => e.DebtDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ErrorLists>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassName).HasMaxLength(100);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(100);
            });

            modelBuilder.Entity<EveryDayCalculateRemnants>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Exports>(entity =>
            {
                entity.Property(e => e.DocDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Filials>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FilialKey)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FilialName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FilialsColors>(entity =>
            {
                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.FilialsColors)
                    .HasForeignKey(d => d.Object1Id)
                    .HasConstraintName("FK_dbo.FilialsColors_dbo.Object1_Object1Id");
            });

            modelBuilder.Entity<Finrezs>(entity =>
            {
                entity.Property(e => e.AverageCapital).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentCapital).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Expenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Margin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MonthlyProfitRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetProfit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherProfits).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OverallMargin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreviousNetProfit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YearlyProfitRate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<FlowOfFunds>(entity =>
            {
                entity.HasKey(e => e.FlowOfFundId)
                    .HasName("PK_dbo.FlowOfFunds");

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.Confirmation).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateConfirmation)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-01-01T00:00:00.000')");
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<HelpImages>(entity =>
            {
                entity.HasIndex(e => e.HelpId)
                    .HasName("IX_HelpId");

                entity.Property(e => e.ImgPath).HasMaxLength(150);

                entity.HasOne(d => d.Help)
                    .WithMany(p => p.HelpImages)
                    .HasForeignKey(d => d.HelpId)
                    .HasConstraintName("FK_dbo.HelpImages_dbo.Helps_HelpId");
            });

            modelBuilder.Entity<Helps>(entity =>
            {
                entity.Property(e => e.Uri).HasMaxLength(150);
            });

            modelBuilder.Entity<InvoiceNomenclatures>(entity =>
            {
                entity.HasKey(e => e.InvoicesNomenclatureId)
                    .HasName("PK_dbo.InvoiceNomenclatures");

                entity.HasIndex(e => e.InvoicesId)
                    .HasName("IX_InvoicesId");

                entity.Property(e => e.PeriodBeginning).HasColumnType("datetime");

                entity.HasOne(d => d.Invoices)
                    .WithMany(p => p.InvoiceNomenclatures)
                    .HasForeignKey(d => d.InvoicesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.InvoiceNomenclatures_dbo.Invoices_InvoicesId");
            });

            modelBuilder.Entity<InvoiceZeroShipments>(entity =>
            {
                entity.HasKey(e => e.ZeroShipmentId)
                    .HasName("PK_dbo.InvoiceZeroShipments");

                entity.HasIndex(e => e.InvoiceId)
                    .HasName("IX_InvoiceId");

                entity.Property(e => e.NomenclatureName).HasMaxLength(255);

                entity.Property(e => e.PointName).HasMaxLength(255);

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceZeroShipments)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_dbo.InvoiceZeroShipments_dbo.Invoices_Invoice_InvoicesId");
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUser_ID");

                entity.HasIndex(e => e.CreatorId)
                    .HasName("IX_CreatorId");

                entity.Property(e => e.Acceptor).HasMaxLength(255);

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.AppUserId).HasColumnName("AppUser_ID");

                entity.Property(e => e.Auto).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Drivers).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.NunberInvoice).HasMaxLength(100);

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.InvoicesAppUser)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.Invoices_dbo.AppUsers_AppUser_ID");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.InvoicesCreator)
                    .HasForeignKey(d => d.CreatorId)
                    .HasConstraintName("FK_dbo.Invoices_dbo.AppUsers_CreatorId");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.HasIndex(e => new { e.StateName, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<LoadContracts>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.ContractName).HasMaxLength(100);

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.LoadContracts)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadContracts_dbo.AppUsers_AddUserID");
            });

            modelBuilder.Entity<LoadContragents>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.Code1C).HasMaxLength(32);

                entity.Property(e => e.ContragentName).HasMaxLength(100);

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.LoadContragents)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadContragents_dbo.AppUsers_AddUserID");
            });

            modelBuilder.Entity<LoadDocTypes>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.DocTypeName).HasMaxLength(50);

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.LoadDocTypes)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadDocTypes_dbo.AppUsers_AddUserID");
            });

            modelBuilder.Entity<LoadDocs>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.ContractId)
                    .HasName("IX_ContractID");

                entity.HasIndex(e => e.ContragentId)
                    .HasName("IX_ContragentID");

                entity.HasIndex(e => e.DocTypeId)
                    .HasName("IX_DocTypeID");

                entity.HasIndex(e => e.FirmId)
                    .HasName("IX_FirmID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.PointId)
                    .HasName("IX_PointID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.ContractId).HasColumnName("ContractID");

                entity.Property(e => e.ContragentId).HasColumnName("ContragentID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocNumber).HasMaxLength(32);

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.PointId).HasColumnName("PointID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.LoadDocs)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadDocs_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.LoadDocs)
                    .HasForeignKey(d => d.ContractId)
                    .HasConstraintName("FK_dbo.LoadDocs_dbo.LoadContracts_ContractID");

                entity.HasOne(d => d.Contragent)
                    .WithMany(p => p.LoadDocs)
                    .HasForeignKey(d => d.ContragentId)
                    .HasConstraintName("FK_dbo.LoadDocs_dbo.LoadContragents_ContragentID");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.LoadDocs)
                    .HasForeignKey(d => d.DocTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadDocs_dbo.LoadDocTypes_DocTypeID");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.LoadDocs)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadDocs_dbo.LoadFirms_FirmID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.LoadDocs)
                    .HasForeignKey(d => d.NomenclatureId)
                    .HasConstraintName("FK_dbo.LoadDocs_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.LoadDocs)
                    .HasForeignKey(d => d.PointId)
                    .HasConstraintName("FK_dbo.LoadDocs_dbo.Object1_PointID");
            });

            modelBuilder.Entity<LoadFirms>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.FirmCode).HasMaxLength(50);

                entity.Property(e => e.FirmName).HasMaxLength(50);

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.LoadFirms)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadFirms_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.LoadFirms)
                    .HasForeignKey(d => d.FilialId)
                    .HasConstraintName("FK_dbo.LoadFirms_dbo.Filials_FilialID");
            });

            modelBuilder.Entity<LoadOsvs>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.ContractId)
                    .HasName("IX_ContractID");

                entity.HasIndex(e => e.ContragentId)
                    .HasName("IX_ContragentID");

                entity.HasIndex(e => e.FirmId)
                    .HasName("IX_FirmID");

                entity.HasIndex(e => e.PointId)
                    .HasName("IX_PointID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.ContractId).HasColumnName("ContractID");

                entity.Property(e => e.ContragentId).HasColumnName("ContragentID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.PointId).HasColumnName("PointID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.LoadOsvs)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadOsvs_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.LoadOsvs)
                    .HasForeignKey(d => d.ContractId)
                    .HasConstraintName("FK_dbo.LoadOsvs_dbo.LoadContracts_ContractID");

                entity.HasOne(d => d.Contragent)
                    .WithMany(p => p.LoadOsvs)
                    .HasForeignKey(d => d.ContragentId)
                    .HasConstraintName("FK_dbo.LoadOsvs_dbo.LoadContragents_ContragentID");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.LoadOsvs)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadOsvs_dbo.LoadFirms_FirmID");

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.LoadOsvs)
                    .HasForeignKey(d => d.PointId)
                    .HasConstraintName("FK_dbo.LoadOsvs_dbo.Object1_PointID");
            });

            modelBuilder.Entity<LoadRevisionNots>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.ContrId)
                    .HasName("IX_ContrID");

                entity.HasIndex(e => e.ContractId)
                    .HasName("IX_ContractID");

                entity.HasIndex(e => e.DocTypeId)
                    .HasName("IX_DocTypeID");

                entity.HasIndex(e => e.FirmId)
                    .HasName("IX_FirmID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.ContrId).HasColumnName("ContrID");

                entity.Property(e => e.ContractId).HasColumnName("ContractID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocNumber).HasMaxLength(32);

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.LoadRevisionNots)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadRevisionNots_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Contr)
                    .WithMany(p => p.LoadRevisionNots)
                    .HasForeignKey(d => d.ContrId)
                    .HasConstraintName("FK_dbo.LoadRevisionNots_dbo.Object1_ContrID");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.LoadRevisionNots)
                    .HasForeignKey(d => d.ContractId)
                    .HasConstraintName("FK_dbo.LoadRevisionNots_dbo.LoadContracts_ContractID");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.LoadRevisionNots)
                    .HasForeignKey(d => d.DocTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadRevisionNots_dbo.LoadDocTypes_DocTypeID");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.LoadRevisionNots)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadRevisionNots_dbo.LoadFirms_FirmID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.LoadRevisionNots)
                    .HasForeignKey(d => d.NomenclatureId)
                    .HasConstraintName("FK_dbo.LoadRevisionNots_dbo.Nomenclatures_NomenclatureID");
            });

            modelBuilder.Entity<LoadRevisionOks>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.ContrId)
                    .HasName("IX_ContrID");

                entity.HasIndex(e => e.ContractId)
                    .HasName("IX_ContractID");

                entity.HasIndex(e => e.DocTypeId)
                    .HasName("IX_DocTypeID");

                entity.HasIndex(e => e.FirmId)
                    .HasName("IX_FirmID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.ContrId).HasColumnName("ContrID");

                entity.Property(e => e.ContractId).HasColumnName("ContractID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocNumber).HasMaxLength(32);

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.LoadRevisionOks)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadRevisionOks_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Contr)
                    .WithMany(p => p.LoadRevisionOks)
                    .HasForeignKey(d => d.ContrId)
                    .HasConstraintName("FK_dbo.LoadRevisionOks_dbo.Object1_ContrID");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.LoadRevisionOks)
                    .HasForeignKey(d => d.ContractId)
                    .HasConstraintName("FK_dbo.LoadRevisionOks_dbo.LoadContracts_ContractID");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.LoadRevisionOks)
                    .HasForeignKey(d => d.DocTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadRevisionOks_dbo.LoadDocTypes_DocTypeID");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.LoadRevisionOks)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadRevisionOks_dbo.LoadFirms_FirmID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.LoadRevisionOks)
                    .HasForeignKey(d => d.NomenclatureId)
                    .HasConstraintName("FK_dbo.LoadRevisionOks_dbo.Nomenclatures_NomenclatureID");
            });

            modelBuilder.Entity<LoadSchetLogs>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.ContractDid)
                    .HasName("IX_ContractDID");

                entity.HasIndex(e => e.ContractKid)
                    .HasName("IX_ContractKID");

                entity.HasIndex(e => e.Contragent2Id)
                    .HasName("IX_Contragent2ID");

                entity.HasIndex(e => e.ContragentId)
                    .HasName("IX_ContragentID");

                entity.HasIndex(e => e.DocTypeId)
                    .HasName("IX_DocTypeID");

                entity.HasIndex(e => e.FirmId)
                    .HasName("IX_FirmID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.PointId)
                    .HasName("IX_PointID");

                entity.HasIndex(e => e.StoreId)
                    .HasName("IX_StoreID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.ContractDid).HasColumnName("ContractDID");

                entity.Property(e => e.ContractKid).HasColumnName("ContractKID");

                entity.Property(e => e.Contragent2Id).HasColumnName("Contragent2ID");

                entity.Property(e => e.ContragentId).HasColumnName("ContragentID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocNumber).HasMaxLength(32);

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.PointId).HasColumnName("PointID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.LoadSchetLogs)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadSchetLogs_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.ContractD)
                    .WithMany(p => p.LoadSchetLogsContractD)
                    .HasForeignKey(d => d.ContractDid)
                    .HasConstraintName("FK_dbo.LoadSchetLogs_dbo.LoadContracts_ContractDID");

                entity.HasOne(d => d.ContractK)
                    .WithMany(p => p.LoadSchetLogsContractK)
                    .HasForeignKey(d => d.ContractKid)
                    .HasConstraintName("FK_dbo.LoadSchetLogs_dbo.LoadContracts_ContractKID");

                entity.HasOne(d => d.Contragent2)
                    .WithMany(p => p.LoadSchetLogsContragent2)
                    .HasForeignKey(d => d.Contragent2Id)
                    .HasConstraintName("FK_dbo.LoadSchetLogs_dbo.LoadContragents_Contragent2ID");

                entity.HasOne(d => d.Contragent)
                    .WithMany(p => p.LoadSchetLogsContragent)
                    .HasForeignKey(d => d.ContragentId)
                    .HasConstraintName("FK_dbo.LoadSchetLogs_dbo.LoadContragents_ContragentID");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.LoadSchetLogs)
                    .HasForeignKey(d => d.DocTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadSchetLogs_dbo.LoadDocTypes_DocTypeID");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.LoadSchetLogs)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadSchetLogs_dbo.LoadFirms_FirmID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.LoadSchetLogs)
                    .HasForeignKey(d => d.NomenclatureId)
                    .HasConstraintName("FK_dbo.LoadSchetLogs_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.LoadSchetLogs)
                    .HasForeignKey(d => d.PointId)
                    .HasConstraintName("FK_dbo.LoadSchetLogs_dbo.Object1_PointID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.LoadSchetLogs)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_dbo.LoadSchetLogs_dbo.LoadStores_StoreID");
            });

            modelBuilder.Entity<LoadSchets>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.BusinessId)
                    .HasName("IX_BusinessID");

                entity.HasIndex(e => e.ContractDid)
                    .HasName("IX_ContractDID");

                entity.HasIndex(e => e.ContractKid)
                    .HasName("IX_ContractKID");

                entity.HasIndex(e => e.Contragent2Id)
                    .HasName("IX_Contragent2ID");

                entity.HasIndex(e => e.ContragentId)
                    .HasName("IX_ContragentID");

                entity.HasIndex(e => e.DocTypeId)
                    .HasName("IX_DocTypeID");

                entity.HasIndex(e => e.FirmId)
                    .HasName("IX_FirmID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.PointId)
                    .HasName("IX_PointID");

                entity.HasIndex(e => e.StoreId)
                    .HasName("IX_StoreID");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.Comment).HasMaxLength(100);

                entity.Property(e => e.ContractDid).HasColumnName("ContractDID");

                entity.Property(e => e.ContractKid).HasColumnName("ContractKID");

                entity.Property(e => e.Contragent2Id).HasColumnName("Contragent2ID");

                entity.Property(e => e.ContragentId).HasColumnName("ContragentID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocNumber).HasMaxLength(32);

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.PointId).HasColumnName("PointID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.LoadSchetsAddUser)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.LoadSchets)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.PropertyValParams_BusinessID");

                entity.HasOne(d => d.ContractD)
                    .WithMany(p => p.LoadSchetsContractD)
                    .HasForeignKey(d => d.ContractDid)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.LoadContracts_ContractDID");

                entity.HasOne(d => d.ContractK)
                    .WithMany(p => p.LoadSchetsContractK)
                    .HasForeignKey(d => d.ContractKid)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.LoadContracts_ContractKID");

                entity.HasOne(d => d.Contragent2)
                    .WithMany(p => p.LoadSchetsContragent2)
                    .HasForeignKey(d => d.Contragent2Id)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.LoadContragents_Contragent2ID");

                entity.HasOne(d => d.Contragent)
                    .WithMany(p => p.LoadSchetsContragent)
                    .HasForeignKey(d => d.ContragentId)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.LoadContragents_ContragentID");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.LoadSchets)
                    .HasForeignKey(d => d.DocTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.LoadDocTypes_DocTypeID");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.LoadSchets)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.LoadFirms_FirmID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.LoadSchetsManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.LoadSchets)
                    .HasForeignKey(d => d.NomenclatureId)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.LoadSchets)
                    .HasForeignKey(d => d.PointId)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.Object1_ContrID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.LoadSchets)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.LoadStores_StoreID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LoadSchetsUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.LoadSchets_dbo.AppUsers_UserID");
            });

            modelBuilder.Entity<LoadStat1C>(entity =>
            {
                entity.HasIndex(e => e.BusinessId)
                    .HasName("IX_BusinessID");

                entity.HasIndex(e => e.ContractDid)
                    .HasName("IX_ContractDID");

                entity.HasIndex(e => e.ContractKid)
                    .HasName("IX_ContractKID");

                entity.HasIndex(e => e.FirmId)
                    .HasName("IX_FirmID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.PointId)
                    .HasName("IX_PointID");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.ContractDid).HasColumnName("ContractDID");

                entity.Property(e => e.ContractKid).HasColumnName("ContractKID");

                entity.Property(e => e.DateMax).HasColumnType("datetime");

                entity.Property(e => e.FirmId).HasColumnName("FirmID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.PointId).HasColumnName("PointID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.LoadStat1C)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_dbo.LoadStat1C_dbo.PropertyValParams_BusinessID");

                entity.HasOne(d => d.ContractD)
                    .WithMany(p => p.LoadStat1CContractD)
                    .HasForeignKey(d => d.ContractDid)
                    .HasConstraintName("FK_dbo.LoadStat1C_dbo.LoadContracts_ContractDID");

                entity.HasOne(d => d.ContractK)
                    .WithMany(p => p.LoadStat1CContractK)
                    .HasForeignKey(d => d.ContractKid)
                    .HasConstraintName("FK_dbo.LoadStat1C_dbo.LoadContracts_ContractKID");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.LoadStat1C)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadStat1C_dbo.LoadFirms_FirmID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.LoadStat1CManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.LoadStat1C_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.LoadStat1C)
                    .HasForeignKey(d => d.PointId)
                    .HasConstraintName("FK_dbo.LoadStat1C_dbo.Object1_PointID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LoadStat1CUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.LoadStat1C_dbo.AppUsers_UserID");
            });

            modelBuilder.Entity<LoadStores>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.StoreName).HasMaxLength(100);

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.LoadStores)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LoadStores_dbo.AppUsers_AddUserID");
            });

            modelBuilder.Entity<LogisticDisposableCars>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.GodCar).HasMaxLength(50);

                entity.Property(e => e.NameCar).HasMaxLength(16);
            });

            modelBuilder.Entity<LogisticDriverCarLogs>(entity =>
            {
                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.LogisticDriverCarLogs)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.LogisticDriverCarLogs_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.LogisticDriverCarLogs)
                    .HasForeignKey(d => d.Object1Id)
                    .HasConstraintName("FK_dbo.LogisticDriverCarLogs_dbo.Object1_Object1Id");
            });

            modelBuilder.Entity<LogisticDriverLogs>(entity =>
            {
                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.CarId)
                    .HasName("IX_CarId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.LogisticDriverLogs)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.LogisticDriverLogs_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.LogisticDriverLogs)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_dbo.LogisticDriverLogs_dbo.Object1_CarId");
            });

            modelBuilder.Entity<LogisticDriverSummaryItems>(entity =>
            {
                entity.HasIndex(e => e.DriverId)
                    .HasName("IX_DriverId");

                entity.HasIndex(e => e.LogisticTripId)
                    .HasName("IX_LogisticTripId");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.HasIndex(e => e.PointId)
                    .HasName("IX_PointID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.PointId).HasColumnName("PointID");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.LogisticDriverSummaryItems)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK_dbo.LogisticDriverSummaryItems_dbo.AppUsers_DriverId");

                entity.HasOne(d => d.LogisticTrip)
                    .WithMany(p => p.LogisticDriverSummaryItems)
                    .HasForeignKey(d => d.LogisticTripId)
                    .HasConstraintName("FK_dbo.LogisticDriverSummaryItems_dbo.LogisticTrips_LogisticTripId");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.LogisticDriverSummaryItemsObject1)
                    .HasForeignKey(d => d.Object1Id)
                    .HasConstraintName("FK_dbo.LogisticDriverSummaryItems_dbo.Object1_Object1Id");

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.LogisticDriverSummaryItemsPoint)
                    .HasForeignKey(d => d.PointId)
                    .HasConstraintName("FK_dbo.LogisticDriverSummaryItems_dbo.Object1_PointID");
            });

            modelBuilder.Entity<LogisticDriverTripLogs>(entity =>
            {
                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.LogisticTripId)
                    .HasName("IX_LogisticTripId");

                entity.Property(e => e.CarNumber).HasMaxLength(32);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.LogisticDriverTripLogs)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.LogisticDriverTripLogs_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.LogisticTrip)
                    .WithMany(p => p.LogisticDriverTripLogs)
                    .HasForeignKey(d => d.LogisticTripId)
                    .HasConstraintName("FK_dbo.LogisticDriverTripLogs_dbo.LogisticTrips_LogisticTripId");
            });

            modelBuilder.Entity<LogisticRouteSheets>(entity =>
            {
                entity.HasIndex(e => e.CarId)
                    .HasName("IX_CarId");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.LogisticRouteSheetsGroupId)
                    .HasName("IX_LogisticRouteSheetsGroupId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.StatusComment).HasMaxLength(255);

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.LogisticRouteSheets)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LogisticRouteSheets_dbo.Object1_CarId");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.LogisticRouteSheets)
                    .HasForeignKey(d => d.FilialId)
                    .HasConstraintName("FK_dbo.LogisticRouteSheets_dbo.Filials_FilialID");

                entity.HasOne(d => d.LogisticRouteSheetsGroup)
                    .WithMany(p => p.LogisticRouteSheets)
                    .HasForeignKey(d => d.LogisticRouteSheetsGroupId)
                    .HasConstraintName("FK_dbo.LogisticRouteSheets_dbo.LogisticRouteSheetsGroups_LogisticRouteSheetsGroupId");
            });

            modelBuilder.Entity<LogisticRouteSheetsGroups>(entity =>
            {
                entity.HasKey(e => e.LogisticRouteSheetsGroupId)
                    .HasName("PK_dbo.LogisticRouteSheetsGroups");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.LogisticRouteSheetsGroups)
                    .HasForeignKey(d => d.FilialId)
                    .HasConstraintName("FK_dbo.LogisticRouteSheetsGroups_dbo.Filials_FilialID");
            });

            modelBuilder.Entity<LogisticTripGroups>(entity =>
            {
                entity.HasIndex(e => e.LogisticRouteSheetId)
                    .HasName("IX_LogisticRouteSheetId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.PointOfDischarge).HasMaxLength(32);

                entity.HasOne(d => d.LogisticRouteSheet)
                    .WithMany(p => p.LogisticTripGroups)
                    .HasForeignKey(d => d.LogisticRouteSheetId)
                    .HasConstraintName("FK_dbo.LogisticTripGroups_dbo.LogisticRouteSheets_LogisticRouteSheetId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogisticTripGroups)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.LogisticTripGroups_dbo.AppUsers_UserId");
            });

            modelBuilder.Entity<LogisticTrips>(entity =>
            {
                entity.HasIndex(e => e.LogisticRouteSheetId)
                    .HasName("IX_LogisticRouteSheet_Id");

                entity.HasIndex(e => e.LogisticTripGroupId)
                    .HasName("IX_LogisticTripGroupId");

                entity.HasIndex(e => e.PointInId)
                    .HasName("IX_PointInId");

                entity.HasIndex(e => e.PointOutId)
                    .HasName("IX_PointOutId");

                entity.HasIndex(e => e.PointUserId)
                    .HasName("IX_PointUserId");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.LogisticRouteSheetId).HasColumnName("LogisticRouteSheet_Id");

                entity.Property(e => e.PointInName).HasMaxLength(32);

                entity.Property(e => e.PointOutName).HasMaxLength(32);

                entity.Property(e => e.PointUserName).HasMaxLength(32);

                entity.Property(e => e.TripComment).HasMaxLength(299);

                entity.HasOne(d => d.LogisticRouteSheet)
                    .WithMany(p => p.LogisticTrips)
                    .HasForeignKey(d => d.LogisticRouteSheetId)
                    .HasConstraintName("FK_dbo.LogisticTrips_dbo.LogisticRouteSheets_LogisticRouteSheet_Id");

                entity.HasOne(d => d.LogisticTripGroup)
                    .WithMany(p => p.LogisticTrips)
                    .HasForeignKey(d => d.LogisticTripGroupId)
                    .HasConstraintName("FK_dbo.LogisticTrips_dbo.LogisticTripGroups_LogisticTripGroupId");

                entity.HasOne(d => d.PointIn)
                    .WithMany(p => p.LogisticTripsPointIn)
                    .HasForeignKey(d => d.PointInId)
                    .HasConstraintName("FK_dbo.LogisticTrips_dbo.Object1_PointInId");

                entity.HasOne(d => d.PointOut)
                    .WithMany(p => p.LogisticTripsPointOut)
                    .HasForeignKey(d => d.PointOutId)
                    .HasConstraintName("FK_dbo.LogisticTrips_dbo.Object1_PointOutId");

                entity.HasOne(d => d.PointUser)
                    .WithMany(p => p.LogisticTrips)
                    .HasForeignKey(d => d.PointUserId)
                    .HasConstraintName("FK_dbo.LogisticTrips_dbo.AppUsers_PointUserId");
            });

            modelBuilder.Entity<LogsLoadFiles>(entity =>
            {
                entity.Property(e => e.LoadDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MacDuckAddedMoneys>(entity =>
            {
                entity.HasIndex(e => e.CreatorId);

                entity.HasIndex(e => e.PointId);

                entity.HasIndex(e => e.SourceId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Money).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.MacDuckAddedMoneysCreator)
                    .HasForeignKey(d => d.CreatorId);

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.MacDuckAddedMoneys)
                    .HasForeignKey(d => d.PointId);

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.MacDuckAddedMoneysSource)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MacDuckClientBonuses>(entity =>
            {
                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatorId);

                entity.HasIndex(e => e.PointId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.MacDuckClientBonuses)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.MacDuckClientBonuses)
                    .HasForeignKey(d => d.CreatorId);

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.MacDuckClientBonuses)
                    .HasForeignKey(d => d.PointId);
            });

            modelBuilder.Entity<MacDuckClients>(entity =>
            {
                entity.HasIndex(e => e.CreatorId);

                entity.HasIndex(e => e.PointId);

                entity.HasIndex(e => e.RegionalId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.MacDuckClientsCreator)
                    .HasForeignKey(d => d.CreatorId);

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.MacDuckClients)
                    .HasForeignKey(d => d.PointId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Regional)
                    .WithMany(p => p.MacDuckClientsRegional)
                    .HasForeignKey(d => d.RegionalId);
            });

            modelBuilder.Entity<MacDuckDisassemblies>(entity =>
            {
                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatorId);

                entity.HasIndex(e => e.PointId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.MacDuckDisassemblies)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.MacDuckDisassemblies)
                    .HasForeignKey(d => d.CreatorId);

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.MacDuckDisassemblies)
                    .HasForeignKey(d => d.PointId);
            });

            modelBuilder.Entity<MacDuckDisassemblyNomenclatures>(entity =>
            {
                entity.HasIndex(e => e.DisassemblyId);

                entity.HasIndex(e => e.NomenclatureId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Disassembly)
                    .WithMany(p => p.MacDuckDisassemblyNomenclatures)
                    .HasForeignKey(d => d.DisassemblyId);

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.MacDuckDisassemblyNomenclatures)
                    .HasForeignKey(d => d.NomenclatureId);
            });

            modelBuilder.Entity<MacDuckOperationNomenclatures>(entity =>
            {
                entity.HasIndex(e => e.NomenclatureId);

                entity.HasIndex(e => e.OperationId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Garbagge).HasDefaultValueSql("((0.0000000000000000e+000))");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TheSizeOfTheCashBonus).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.MacDuckOperationNomenclatures)
                    .HasForeignKey(d => d.NomenclatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.MacDuckOperationNomenclatures)
                    .HasForeignKey(d => d.OperationId);
            });

            modelBuilder.Entity<MacDuckOperations>(entity =>
            {
                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatorId);

                entity.HasIndex(e => e.PointId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.MacDuckOperations)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.MacDuckOperations)
                    .HasForeignKey(d => d.CreatorId);

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.MacDuckOperations)
                    .HasForeignKey(d => d.PointId);
            });

            modelBuilder.Entity<MatchingPriceAccepts>(entity =>
            {
                entity.HasKey(e => e.MatchingPriceAcceptId)
                    .HasName("PK_dbo.MatchingPriceAccepts");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.MatchingPriceId)
                    .HasName("IX_MatchingPriceId");

                entity.Property(e => e.AcceptDate).HasColumnType("datetime");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.MatchingPriceAccepts)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MatchingPriceAccepts_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.MatchingPrice)
                    .WithMany(p => p.MatchingPriceAccepts)
                    .HasForeignKey(d => d.MatchingPriceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MatchingPriceAccepts_dbo.MatchingPrices_MatchingPriceId");
            });

            modelBuilder.Entity<MatchingPriceSettings>(entity =>
            {
                entity.HasKey(e => e.MatchingPriceSettingId)
                    .HasName("PK_dbo.MatchingPriceSettings");
            });

            modelBuilder.Entity<MatchingPrices>(entity =>
            {
                entity.HasKey(e => e.MatchingPriceId)
                    .HasName("PK_dbo.MatchingPrices");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.MatchingPrices)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MatchingPrices_dbo.AppUsers_AppUserId");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<NomenclatureBus>(entity =>
            {
                entity.HasIndex(e => e.BusinessId)
                    .HasName("IX_BusinessID");

                entity.HasIndex(e => e.TopGrpId)
                    .HasName("IX_TopGrpID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.TopGrpId).HasColumnName("TopGrpID");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.NomenclatureBus)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.NomenclatureBus_dbo.PropertyValParams_BusinessID");

                entity.HasOne(d => d.TopGrp)
                    .WithMany(p => p.NomenclatureBus)
                    .HasForeignKey(d => d.TopGrpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.NomenclatureBus_dbo.Nomenclatures_TopGrpID");
            });

            modelBuilder.Entity<Nomenclatures>(entity =>
            {
                entity.HasIndex(e => e.BusinessId)
                    .HasName("IX_BusinessID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.Code1C)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.FullKey).HasMaxLength(255);

                entity.Property(e => e.IsGrp).HasColumnName("isGrp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SortIndex).HasColumnName("sortIndex");

                entity.Property(e => e.SortKey).HasMaxLength(128);

                entity.Property(e => e.TopGrpId).HasColumnName("TopGrpID");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Nomenclatures)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_dbo.Nomenclatures_dbo.Business1C_BusinessID");
            });

            modelBuilder.Entity<Notifies>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifies)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Notifies_dbo.AppUsers_UserId");
            });

            modelBuilder.Entity<Object1>(entity =>
            {
                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.LoadContragentId)
                    .HasName("IX_LoadContragentID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.ObjectTypeId)
                    .HasName("IX_ObjectTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.AddUserIp)
                    .HasColumnName("AddUserIP")
                    .HasMaxLength(32);

                entity.Property(e => e.AppUserId).HasColumnName("AppUserID");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.LoadContragentId).HasColumnName("LoadContragentID");

                entity.Property(e => e.Name1C).HasMaxLength(50);

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.ObjectName).IsRequired();

                entity.Property(e => e.ObjectTypeId).HasColumnName("ObjectTypeID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.Object1)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.Object1_dbo.AppUsers_AppUserID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.Object1)
                    .HasForeignKey(d => d.FilialId)
                    .HasConstraintName("FK_dbo.Object1_dbo.Filials_FilialID");

                entity.HasOne(d => d.LoadContragent)
                    .WithMany(p => p.Object1)
                    .HasForeignKey(d => d.LoadContragentId)
                    .HasConstraintName("FK_dbo.Object1_dbo.LoadContragents_LoadContragentID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.Object1)
                    .HasForeignKey(d => d.NomenclatureId)
                    .HasConstraintName("FK_dbo.Object1_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.Object1)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .HasConstraintName("FK_dbo.Object1_dbo.ObjectTypes_ObjectTypeID");
            });

            modelBuilder.Entity<ObjectTypes>(entity =>
            {
                entity.HasIndex(e => e.DopDefaultRoleId)
                    .HasName("IX_dopDefaultRoleID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.AddUserIp)
                    .HasColumnName("AddUserIP")
                    .HasMaxLength(32);

                entity.Property(e => e.DopAddDepartmentId).HasColumnName("dopAddDepartmentID");

                entity.Property(e => e.DopCreateAutoDep).HasColumnName("dopCreateAutoDep");

                entity.Property(e => e.DopDefaultRoleId).HasColumnName("dopDefaultRoleID");

                entity.Property(e => e.DopGeo).HasColumnName("dopGeo");

                entity.Property(e => e.EngName).HasMaxLength(32);

                entity.Property(e => e.IsGlobal).HasColumnName("isGlobal");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.PicsIcon).HasMaxLength(100);

                entity.HasOne(d => d.DopDefaultRole)
                    .WithMany(p => p.ObjectTypes)
                    .HasForeignKey(d => d.DopDefaultRoleId)
                    .HasConstraintName("FK_dbo.ObjectTypes_dbo.AppFuncRoles_dopDefaultRoleID");
            });

            modelBuilder.Entity<PointDisposes>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.BusinessId)
                    .HasName("IX_BusinessID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.Comment).HasMaxLength(100);

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.Property(e => e.PhotoUrl1)
                    .HasColumnName("PhotoURL1")
                    .HasMaxLength(100);

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.PointDisposes)
                    .HasForeignKey(d => d.AddUserId)
                    .HasConstraintName("FK_dbo.PointDisposes_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.PointDisposes)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_dbo.PointDisposes_dbo.PropertyValParams_BusinessID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PointDisposes)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointDisposes_dbo.Filials_FilialID");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PointDisposes)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointDisposes_dbo.Object1_Object1ID");
            });

            modelBuilder.Entity<PointPlans>(entity =>
            {
                entity.HasIndex(e => e.BusinessId)
                    .HasName("IX_BusinessID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.NomGrpId)
                    .HasName("IX_NomGrpID");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.NomGrpId).HasColumnName("NomGrpID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.PointPlans)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointPlans_dbo.PropertyValParams_BusinessID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PointPlans)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointPlans_dbo.Filials_FilialID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PointPlans)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.PointPlans_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.NomGrp)
                    .WithMany(p => p.PointPlansNomGrp)
                    .HasForeignKey(d => d.NomGrpId)
                    .HasConstraintName("FK_dbo.PointPlans_dbo.Object1_NomGrpID");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PointPlansObject1)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointPlans_dbo.Object1_Object1ID");
            });

            modelBuilder.Entity<PointReportMoneys>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.PointReportMoneysAddUser)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointReportMoneys_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PointReportMoneys)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointReportMoneys_dbo.Filials_FilialID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PointReportMoneysManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.PointReportMoneys_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PointReportMoneys)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointReportMoneys_dbo.Object1_Object1ID");
            });

            modelBuilder.Entity<PointReportMoneysLogs>(entity =>
            {
                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PointReportMoneysLogs)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointReportMoneysLogs_dbo.Filials_FilialID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PointReportMoneysLogs)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.PointReportMoneysLogs_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PointReportMoneysLogs)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointReportMoneysLogs_dbo.Object1_Object1ID");
            });

            modelBuilder.Entity<PointReportNoms>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.BusinessId)
                    .HasName("IX_BusinessID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.NomGrpId)
                    .HasName("IX_NomGrpID");

                entity.HasIndex(e => e.NomObjId)
                    .HasName("IX_NomObjID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.NomGrpId).HasColumnName("NomGrpID");

                entity.Property(e => e.NomObjId).HasColumnName("NomObjID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.PointReportNomsAddUser)
                    .HasForeignKey(d => d.AddUserId)
                    .HasConstraintName("FK_dbo.PointReportNoms_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.PointReportNoms)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_dbo.PointReportNoms_dbo.PropertyValParams_BusinessID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PointReportNoms)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointReportNoms_dbo.Filials_FilialID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PointReportNomsManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.PointReportNoms_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.NomGrp)
                    .WithMany(p => p.PointReportNomsNomGrp)
                    .HasForeignKey(d => d.NomGrpId)
                    .HasConstraintName("FK_dbo.PointReportNoms_dbo.Object1_NomGrpID");

                entity.HasOne(d => d.NomObj)
                    .WithMany(p => p.PointReportNomsNomObj)
                    .HasForeignKey(d => d.NomObjId)
                    .HasConstraintName("FK_dbo.PointReportNoms_dbo.Object1_NomObjID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.PointReportNoms)
                    .HasForeignKey(d => d.NomenclatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointReportNoms_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PointReportNomsObject1)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointReportNoms_dbo.Object1_Object1ID");
            });

            modelBuilder.Entity<PointReportNomsLogs>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.BusinessId)
                    .HasName("IX_BusinessID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.NomGrpId)
                    .HasName("IX_NomGrpID");

                entity.HasIndex(e => e.NomObjId)
                    .HasName("IX_NomObjID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.NomGrpId).HasColumnName("NomGrpID");

                entity.Property(e => e.NomObjId).HasColumnName("NomObjID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.PointReportNomsLogsAddUser)
                    .HasForeignKey(d => d.AddUserId)
                    .HasConstraintName("FK_dbo.PointReportNomsLogs_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.PointReportNomsLogs)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_dbo.PointReportNomsLogs_dbo.PropertyValParams_BusinessID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PointReportNomsLogs)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointReportNomsLogs_dbo.Filials_FilialID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PointReportNomsLogsManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.PointReportNomsLogs_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.NomGrp)
                    .WithMany(p => p.PointReportNomsLogsNomGrp)
                    .HasForeignKey(d => d.NomGrpId)
                    .HasConstraintName("FK_dbo.PointReportNomsLogs_dbo.Object1_NomGrpID");

                entity.HasOne(d => d.NomObj)
                    .WithMany(p => p.PointReportNomsLogsNomObj)
                    .HasForeignKey(d => d.NomObjId)
                    .HasConstraintName("FK_dbo.PointReportNomsLogs_dbo.Object1_NomObjID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.PointReportNomsLogs)
                    .HasForeignKey(d => d.NomenclatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointReportNomsLogs_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PointReportNomsLogsObject1)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointReportNomsLogs_dbo.Object1_Object1ID");
            });

            modelBuilder.Entity<PointStatNoms>(entity =>
            {
                entity.HasIndex(e => e.BusinessId)
                    .HasName("IX_BusinessID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.NomGrpId)
                    .HasName("IX_NomGrpID");

                entity.HasIndex(e => e.NomObjId)
                    .HasName("IX_NomObjID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.DateMax).HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.NomGrpId).HasColumnName("NomGrpID");

                entity.Property(e => e.NomObjId).HasColumnName("NomObjID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.PointStatNoms)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_dbo.PointStatNoms_dbo.PropertyValParams_BusinessID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PointStatNoms)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointStatNoms_dbo.Filials_FilialID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PointStatNoms)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.PointStatNoms_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.NomGrp)
                    .WithMany(p => p.PointStatNomsNomGrp)
                    .HasForeignKey(d => d.NomGrpId)
                    .HasConstraintName("FK_dbo.PointStatNoms_dbo.Object1_NomGrpID");

                entity.HasOne(d => d.NomObj)
                    .WithMany(p => p.PointStatNomsNomObj)
                    .HasForeignKey(d => d.NomObjId)
                    .HasConstraintName("FK_dbo.PointStatNoms_dbo.Object1_NomObjID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.PointStatNoms)
                    .HasForeignKey(d => d.NomenclatureId)
                    .HasConstraintName("FK_dbo.PointStatNoms_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PointStatNomsObject1)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PointStatNoms_dbo.Object1_Object1ID");
            });

            modelBuilder.Entity<PriceCompetitorAvgs>(entity =>
            {
                entity.HasIndex(e => e.BussinessId)
                    .HasName("IX_BussinessID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.NomObjId)
                    .HasName("IX_NomObjID");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BussinessId).HasColumnName("BussinessID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.NomObjId).HasColumnName("NomObjID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.HasOne(d => d.Bussiness)
                    .WithMany(p => p.PriceCompetitorAvgs)
                    .HasForeignKey(d => d.BussinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitorAvgs_dbo.PropertyValParams_BussinessID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PriceCompetitorAvgs)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitorAvgs_dbo.Filials_FilialID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PriceCompetitorAvgs)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.PriceCompetitorAvgs_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.NomObj)
                    .WithMany(p => p.PriceCompetitorAvgsNomObj)
                    .HasForeignKey(d => d.NomObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitorAvgs_dbo.Object1_NomObjID");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PriceCompetitorAvgsObject1)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitorAvgs_dbo.Object1_Object1ID");
            });

            modelBuilder.Entity<PriceCompetitorVisions>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.BussinessId)
                    .HasName("IX_BussinessID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.NomObjId)
                    .HasName("IX_NomObjID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.BussinessId).HasColumnName("BussinessID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.IsVision).HasColumnName("isVision");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.NomObjId).HasColumnName("NomObjID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.PriceCompetitorVisionsAddUser)
                    .HasForeignKey(d => d.AddUserId)
                    .HasConstraintName("FK_dbo.PriceCompetitorVisions_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Bussiness)
                    .WithMany(p => p.PriceCompetitorVisions)
                    .HasForeignKey(d => d.BussinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitorVisions_dbo.PropertyValParams_BussinessID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PriceCompetitorVisions)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitorVisions_dbo.Filials_FilialID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PriceCompetitorVisionsManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.PriceCompetitorVisions_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.NomObj)
                    .WithMany(p => p.PriceCompetitorVisionsNomObj)
                    .HasForeignKey(d => d.NomObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitorVisions_dbo.Object1_NomObjID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.PriceCompetitorVisions)
                    .HasForeignKey(d => d.NomenclatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitorVisions_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PriceCompetitorVisionsObject1)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitorVisions_dbo.Object1_Object1ID");
            });

            modelBuilder.Entity<PriceCompetitors>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.BussinessId)
                    .HasName("IX_BussinessID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.NomObjId)
                    .HasName("IX_NomObjID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.BussinessId).HasColumnName("BussinessID");

                entity.Property(e => e.Comment).HasMaxLength(100);

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.IsRegional).HasColumnName("isRegional");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.NomObjId).HasColumnName("NomObjID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.PriceCompetitorsAddUser)
                    .HasForeignKey(d => d.AddUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitors_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Bussiness)
                    .WithMany(p => p.PriceCompetitors)
                    .HasForeignKey(d => d.BussinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitors_dbo.PropertyValParams_BussinessID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PriceCompetitors)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitors_dbo.Filials_FilialID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PriceCompetitorsManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.PriceCompetitors_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.NomObj)
                    .WithMany(p => p.PriceCompetitorsNomObj)
                    .HasForeignKey(d => d.NomObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitors_dbo.Object1_NomObjID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.PriceCompetitors)
                    .HasForeignKey(d => d.NomenclatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitors_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PriceCompetitorsObject1)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceCompetitors_dbo.Object1_Object1ID");
            });

            modelBuilder.Entity<PriceListDocs>(entity =>
            {
                entity.HasIndex(e => e.AddUserId)
                    .HasName("IX_AddUserID");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ManagerId)
                    .HasName("IX_ManagerID");

                entity.HasIndex(e => e.PriceTypeId)
                    .HasName("IX_PriceTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActiveId).HasColumnName("ActiveID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.Comment).HasMaxLength(100);

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Name).HasMaxLength(16);

                entity.Property(e => e.Name1C).HasMaxLength(16);

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.HasOne(d => d.AddUser)
                    .WithMany(p => p.PriceListDocsAddUser)
                    .HasForeignKey(d => d.AddUserId)
                    .HasConstraintName("FK_dbo.PriceListDocs_dbo.AppUsers_AddUserID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PriceListDocs)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_dbo.PriceListDocs_dbo.AppUserDepartments_DepartmentID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PriceListDocs)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListDocs_dbo.Filials_FilialID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PriceListDocsManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_dbo.PriceListDocs_dbo.AppUsers_ManagerID");

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.PriceListDocs)
                    .HasForeignKey(d => d.PriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListDocs_dbo.PriceTypes_PriceTypeID");
            });

            modelBuilder.Entity<PriceListFirsts>(entity =>
            {
                entity.HasIndex(e => e.DocId)
                    .HasName("IX_DocID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.NomObjId)
                    .HasName("IX_NomObjID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.PriceTypeId)
                    .HasName("IX_PriceTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.NomObjId).HasColumnName("NomObjID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.PriceListFirsts)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListFirsts_dbo.PriceListDocs_DocID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PriceListFirsts)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListFirsts_dbo.Filials_FilialID");

                entity.HasOne(d => d.NomObj)
                    .WithMany(p => p.PriceListFirsts)
                    .HasForeignKey(d => d.NomObjId)
                    .HasConstraintName("FK_dbo.PriceListFirsts_dbo.Object1_NomObjID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.PriceListFirsts)
                    .HasForeignKey(d => d.NomenclatureId)
                    .HasConstraintName("FK_dbo.PriceListFirsts_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.PriceListFirsts)
                    .HasForeignKey(d => d.PriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListFirsts_dbo.PriceTypes_PriceTypeID");
            });

            modelBuilder.Entity<PriceListIndependents>(entity =>
            {
                entity.HasIndex(e => e.DocId)
                    .HasName("IX_DocID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.NomObjId)
                    .HasName("IX_NomObjID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("IX_ObjectID");

                entity.HasIndex(e => e.PriceTypeId)
                    .HasName("IX_PriceTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.NomObjId).HasColumnName("NomObjID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.PriceListIndependents)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListIndependents_dbo.PriceListDocs_DocID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PriceListIndependents)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListIndependents_dbo.Filials_FilialID");

                entity.HasOne(d => d.NomObj)
                    .WithMany(p => p.PriceListIndependentsNomObj)
                    .HasForeignKey(d => d.NomObjId)
                    .HasConstraintName("FK_dbo.PriceListIndependents_dbo.Object1_NomObjID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.PriceListIndependents)
                    .HasForeignKey(d => d.NomenclatureId)
                    .HasConstraintName("FK_dbo.PriceListIndependents_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.PriceListIndependentsObject)
                    .HasForeignKey(d => d.ObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListIndependents_dbo.Object1_ObjectID");

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.PriceListIndependents)
                    .HasForeignKey(d => d.PriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListIndependents_dbo.PriceTypes_PriceTypeID");
            });

            modelBuilder.Entity<PriceListSeconds>(entity =>
            {
                entity.HasIndex(e => e.DocId)
                    .HasName("IX_DocID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.NomObjId)
                    .HasName("IX_NomObjID");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureID");

                entity.HasIndex(e => e.PriceObjId)
                    .HasName("IX_PriceObjID");

                entity.HasIndex(e => e.PriceTypeId)
                    .HasName("IX_PriceTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateId)
                    .HasColumnName("DateID")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.NomObjId).HasColumnName("NomObjID");

                entity.Property(e => e.NomenclatureId).HasColumnName("NomenclatureID");

                entity.Property(e => e.PriceObjId).HasColumnName("PriceObjID");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.PriceListSeconds)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListSeconds_dbo.PriceListDocs_DocID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.PriceListSeconds)
                    .HasForeignKey(d => d.FilialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListSeconds_dbo.Filials_FilialID");

                entity.HasOne(d => d.NomObj)
                    .WithMany(p => p.PriceListSecondsNomObj)
                    .HasForeignKey(d => d.NomObjId)
                    .HasConstraintName("FK_dbo.PriceListSeconds_dbo.Object1_NomObjID");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.PriceListSeconds)
                    .HasForeignKey(d => d.NomenclatureId)
                    .HasConstraintName("FK_dbo.PriceListSeconds_dbo.Nomenclatures_NomenclatureID");

                entity.HasOne(d => d.PriceObj)
                    .WithMany(p => p.PriceListSecondsPriceObj)
                    .HasForeignKey(d => d.PriceObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListSeconds_dbo.Object1_PriceObjID");

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.PriceListSeconds)
                    .HasForeignKey(d => d.PriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PriceListSeconds_dbo.PriceTypes_PriceTypeID");
            });

            modelBuilder.Entity<PriceTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.AddUserIp)
                    .HasColumnName("AddUserIP")
                    .HasMaxLength(32);

                entity.Property(e => e.IsGlobal).HasColumnName("isGlobal");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Properties>(entity =>
            {
                entity.HasIndex(e => e.CostObjId)
                    .HasName("IX_CostObjID");

                entity.HasIndex(e => e.FilialId)
                    .HasName("IX_FilialID");

                entity.HasIndex(e => e.ObjectTypeId)
                    .HasName("IX_ObjectTypeID");

                entity.HasIndex(e => e.PropertyValTypeId)
                    .HasName("IX_PropertyValTypeID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddUserId).HasColumnName("AddUserID");

                entity.Property(e => e.AddUserIp)
                    .HasColumnName("AddUserIP")
                    .HasMaxLength(32);

                entity.Property(e => e.CostObjId).HasColumnName("CostObjID");

                entity.Property(e => e.FilialId).HasColumnName("FilialID");

                entity.Property(e => e.IsGlobal).HasColumnName("isGlobal");

                entity.Property(e => e.IsRequired).HasColumnName("isRequired");

                entity.Property(e => e.ObjectTypeId).HasColumnName("ObjectTypeID");

                entity.Property(e => e.PropertyEd).HasMaxLength(16);

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PropertySample).HasMaxLength(32);

                entity.Property(e => e.PropertyValTypeId).HasColumnName("PropertyValTypeID");

                entity.Property(e => e.SortIndex).HasColumnName("sortIndex");

                entity.Property(e => e.ValObjTypeId).HasColumnName("ValObjTypeID");

                entity.HasOne(d => d.CostObj)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.CostObjId)
                    .HasConstraintName("FK_dbo.Properties_dbo.Object1_CostObjID");

                entity.HasOne(d => d.Filial)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.FilialId)
                    .HasConstraintName("FK_dbo.Properties_dbo.Filials_FilialID");

                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .HasConstraintName("FK_dbo.Properties_dbo.ObjectTypes_ObjectTypeID");

                entity.HasOne(d => d.PropertyValType)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.PropertyValTypeId)
                    .HasConstraintName("FK_dbo.Properties_dbo.PropertyValTypes_PropertyValTypeID");
            });

            modelBuilder.Entity<PropertyValParams>(entity =>
            {
                entity.HasIndex(e => e.PropertyId)
                    .HasName("IX_PropertyID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyValParams)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_dbo.PropertyValParams_dbo.Properties_PropertyID");
            });

            modelBuilder.Entity<PropertyValTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PropertyValueObjs>(entity =>
            {
                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.HasIndex(e => e.PropertyId)
                    .HasName("IX_PropertyID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.ValObjId).HasColumnName("ValObjID");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PropertyValueObjs)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PropertyValueObjs_dbo.Object1_Object1ID");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyValueObjs)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PropertyValueObjs_dbo.Properties_PropertyID");
            });

            modelBuilder.Entity<PropertyValues>(entity =>
            {
                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1ID");

                entity.HasIndex(e => e.PropertyId)
                    .HasName("IX_PropertyID");

                entity.HasIndex(e => e.PropertyValParamId)
                    .HasName("IX_PropertyValParamID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Object1Id).HasColumnName("Object1ID");

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.PropertyValParamId).HasColumnName("PropertyValParamID");

                entity.Property(e => e.ValObjId).HasColumnName("ValObjID");

                entity.Property(e => e.ValObjSet).HasMaxLength(255);

                entity.Property(e => e.ValObjTypeId).HasColumnName("ValObjTypeID");

                entity.Property(e => e.Value).HasMaxLength(100);

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.PropertyValues)
                    .HasForeignKey(d => d.Object1Id)
                    .HasConstraintName("FK_dbo.PropertyValues_dbo.Object1_Object1ID");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyValues)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PropertyValues_dbo.Properties_PropertyID");

                entity.HasOne(d => d.PropertyValParam)
                    .WithMany(p => p.PropertyValues)
                    .HasForeignKey(d => d.PropertyValParamId)
                    .HasConstraintName("FK_dbo.PropertyValues_dbo.PropertyValParams_PropertyValParamID");
            });

            modelBuilder.Entity<Realizations>(entity =>
            {
                entity.Property(e => e.DocDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RegionCities>(entity =>
            {
                entity.HasIndex(e => e.RegionOblId)
                    .HasName("IX_RegionOblID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CityShort)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.RegionOblId).HasColumnName("RegionOblID");

                entity.HasOne(d => d.RegionObl)
                    .WithMany(p => p.RegionCities)
                    .HasForeignKey(d => d.RegionOblId)
                    .HasConstraintName("FK_dbo.RegionCities_dbo.RegionObls_RegionOblID");
            });

            modelBuilder.Entity<RegionLands>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LandName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LandShort)
                    .IsRequired()
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<RegionObls>(entity =>
            {
                entity.HasIndex(e => e.RegionLandId)
                    .HasName("IX_RegionLandID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OblName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OblShort)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.RegionLandId).HasColumnName("RegionLandID");

                entity.HasOne(d => d.RegionLand)
                    .WithMany(p => p.RegionObls)
                    .HasForeignKey(d => d.RegionLandId)
                    .HasConstraintName("FK_dbo.RegionObls_dbo.RegionLands_RegionLandID");
            });

            modelBuilder.Entity<RemnantsFixationAnswerDetails>(entity =>
            {
                entity.HasKey(e => e.RemnantsFixationAnswerDetailId)
                    .HasName("PK_dbo.RemnantsFixationAnswerDetails");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureId");

                entity.HasIndex(e => e.RemnantsFixationAnswerId)
                    .HasName("IX_RemnantsFixationAnswerId");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.RemnantsFixationAnswerDetails)
                    .HasForeignKey(d => d.NomenclatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RemnantsFixationAnswerDetails_dbo.Nomenclatures_NomenclatureId");

                entity.HasOne(d => d.RemnantsFixationAnswer)
                    .WithMany(p => p.RemnantsFixationAnswerDetails)
                    .HasForeignKey(d => d.RemnantsFixationAnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RemnantsFixationAnswerDetails_dbo.RemnantsFixationAnswers_RemnantsFixationAnswerId");
            });

            modelBuilder.Entity<RemnantsFixationAnswers>(entity =>
            {
                entity.HasKey(e => e.RemnantsFixationAnswerId)
                    .HasName("PK_dbo.RemnantsFixationAnswers");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.HasIndex(e => e.RemnantsFixationRequestId)
                    .HasName("IX_RemnantsFixationRequestId");

                entity.Property(e => e.DateExecute).HasColumnType("datetime");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.RemnantsFixationAnswers)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RemnantsFixationAnswers_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.RemnantsFixationAnswers)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RemnantsFixationAnswers_dbo.Object1_Object1Id");

                entity.HasOne(d => d.RemnantsFixationRequest)
                    .WithMany(p => p.RemnantsFixationAnswers)
                    .HasForeignKey(d => d.RemnantsFixationRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RemnantsFixationAnswers_dbo.RemnantsFixationRequests_RemnantsFixationRequestId");
            });

            modelBuilder.Entity<RemnantsFixationBundles>(entity =>
            {
                entity.HasKey(e => e.BundleId)
                    .HasName("PK_dbo.RemnantsFixationBundles");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.HasIndex(e => e.RemnantsFixationRequestId)
                    .HasName("IX_RemnantsFixationRequestId");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.RemnantsFixationBundles)
                    .HasForeignKey(d => d.Object1Id)
                    .HasConstraintName("FK_dbo.RemnantsFixationBundles_dbo.Object1_Object1Id");

                entity.HasOne(d => d.RemnantsFixationRequest)
                    .WithMany(p => p.RemnantsFixationBundles)
                    .HasForeignKey(d => d.RemnantsFixationRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RemnantsFixationBundles_dbo.RemnantsFixationRequests_RemnantsFixationRequestId");
            });

            modelBuilder.Entity<RemnantsFixationMaterials>(entity =>
            {
                entity.HasKey(e => e.RemnantsFixationMaterialId)
                    .HasName("PK_dbo.RemnantsFixationMaterials");

                entity.HasIndex(e => e.NomenclatureId)
                    .HasName("IX_NomenclatureId");

                entity.HasIndex(e => e.RemnantsFixationRequestRemnantsFixationRequestId)
                    .HasName("IX_RemnantsFixationRequest_RemnantsFixationRequestId");

                entity.HasIndex(e => e.RemnantsFixationRequestRemnantsFixationRequestId1)
                    .HasName("IX_RemnantsFixationRequest_RemnantsFixationRequestId1");

                entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RemnantsFixationRequestRemnantsFixationRequestId).HasColumnName("RemnantsFixationRequest_RemnantsFixationRequestId");

                entity.Property(e => e.RemnantsFixationRequestRemnantsFixationRequestId1).HasColumnName("RemnantsFixationRequest_RemnantsFixationRequestId1");

                entity.HasOne(d => d.Nomenclature)
                    .WithMany(p => p.RemnantsFixationMaterials)
                    .HasForeignKey(d => d.NomenclatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RemnantsFixationMaterials_dbo.Nomenclatures_NomenclatureId");

                entity.HasOne(d => d.RemnantsFixationRequestRemnantsFixationRequest)
                    .WithMany(p => p.RemnantsFixationMaterialsRemnantsFixationRequestRemnantsFixationRequest)
                    .HasForeignKey(d => d.RemnantsFixationRequestRemnantsFixationRequestId)
                    .HasConstraintName("FK_dbo.RemnantsFixationMaterials_dbo.RemnantsFixationRequests_RemnantsFixationRequest_RemnantsFixationRequestId");

                entity.HasOne(d => d.RemnantsFixationRequestRemnantsFixationRequestId1Navigation)
                    .WithMany(p => p.RemnantsFixationMaterialsRemnantsFixationRequestRemnantsFixationRequestId1Navigation)
                    .HasForeignKey(d => d.RemnantsFixationRequestRemnantsFixationRequestId1)
                    .HasConstraintName("FK_dbo.RemnantsFixationMaterials_dbo.RemnantsFixationRequests_RemnantsFixationRequest_RemnantsFixationRequestId1");
            });

            modelBuilder.Entity<RemnantsFixationRequests>(entity =>
            {
                entity.HasKey(e => e.RemnantsFixationRequestId)
                    .HasName("PK_dbo.RemnantsFixationRequests");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.HasIndex(e => e.RemnantsFixationMaterialRemnantsFixationMaterialId)
                    .HasName("IX_RemnantsFixationMaterial_RemnantsFixationMaterialId");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Deadline).HasColumnType("datetime");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.RemnantsFixationMaterialRemnantsFixationMaterialId).HasColumnName("RemnantsFixationMaterial_RemnantsFixationMaterialId");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.RemnantsFixationRequests)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RemnantsFixationRequests_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.RemnantsFixationRequests)
                    .HasForeignKey(d => d.Object1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RemnantsFixationRequests_dbo.Object1_Object1Id");

                entity.HasOne(d => d.RemnantsFixationMaterialRemnantsFixationMaterial)
                    .WithMany(p => p.RemnantsFixationRequests)
                    .HasForeignKey(d => d.RemnantsFixationMaterialRemnantsFixationMaterialId)
                    .HasConstraintName("FK_dbo.RemnantsFixationRequests_dbo.RemnantsFixationMaterials_RemnantsFixationMaterial_RemnantsFixationMaterialId");
            });

            modelBuilder.Entity<RuleApprovements>(entity =>
            {
                entity.HasKey(e => e.RuleApprovementId)
                    .HasName("PK_dbo.RuleApprovements");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.RuleId)
                    .HasName("IX_RuleId");

                entity.Property(e => e.ApprovementDate).HasColumnType("datetime");

                entity.Property(e => e.IsApprovement).HasColumnName("isApprovement");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.RuleApprovements)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RuleApprovements_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.RuleApprovements)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RuleApprovements_dbo.Rules_RuleId");
            });

            modelBuilder.Entity<RuleAwaranesses>(entity =>
            {
                entity.HasKey(e => e.RuleAwaranessId)
                    .HasName("PK_dbo.RuleAwaranesses");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.RuleId)
                    .HasName("IX_RuleId");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.RuleAwaranesses)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RuleAwaranesses_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.RuleAwaranesses)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RuleAwaranesses_dbo.Rules_RuleId");
            });

            modelBuilder.Entity<RuleObjectBindles>(entity =>
            {
                entity.HasKey(e => e.RuleObjectBindleId)
                    .HasName("PK_dbo.RuleObjectBindles");

                entity.HasIndex(e => e.ObjectTypeId)
                    .HasName("IX_ObjectTypeId");

                entity.HasIndex(e => e.RuleId)
                    .HasName("IX_RuleId");

                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.RuleObjectBindles)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RuleObjectBindles_dbo.ObjectTypes_ObjectTypeId");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.RuleObjectBindles)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RuleObjectBindles_dbo.Rules_RuleId");
            });

            modelBuilder.Entity<RuleRoleBindles>(entity =>
            {
                entity.HasKey(e => e.RuleRoleBindleId)
                    .HasName("PK_dbo.RuleRoleBindles");

                entity.HasIndex(e => e.AppFuncRoleId)
                    .HasName("IX_AppFuncRoleId");

                entity.HasIndex(e => e.RuleId)
                    .HasName("IX_RuleId");

                entity.HasOne(d => d.AppFuncRole)
                    .WithMany(p => p.RuleRoleBindles)
                    .HasForeignKey(d => d.AppFuncRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RuleRoleBindles_dbo.AppFuncRoles_AppFuncRoleId");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.RuleRoleBindles)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RuleRoleBindles_dbo.Rules_RuleId");
            });

            modelBuilder.Entity<RuleTypes>(entity =>
            {
                entity.HasKey(e => e.RuleTypeId)
                    .HasName("PK_dbo.RuleTypes");

                entity.Property(e => e.RuleTypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<Rules>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK_dbo.Rules");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.RuleTypeId)
                    .HasName("IX_RuleTypeId");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.RuleImgPath).HasMaxLength(255);

                entity.Property(e => e.RuleTxt).HasMaxLength(500);

                entity.Property(e => e.RulesKey).HasMaxLength(100);

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.Rules)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Rules_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.RuleType)
                    .WithMany(p => p.Rules)
                    .HasForeignKey(d => d.RuleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Rules_dbo.RuleTypes_RuleTypeId");
            });

            modelBuilder.Entity<SalarySettings>(entity =>
            {
                entity.HasKey(e => e.SalarySettingId)
                    .HasName("PK_dbo.SalarySettings");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.FuncRoleId)
                    .HasName("IX_FuncRoleId");

                entity.HasIndex(e => e.Object1Id)
                    .HasName("IX_Object1Id");

                entity.Property(e => e.Condition).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Kpitext)
                    .HasColumnName("KPIText")
                    .HasMaxLength(255);

                entity.Property(e => e.SettingDate).HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.SalarySettings)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SalarySettings_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.FuncRole)
                    .WithMany(p => p.SalarySettings)
                    .HasForeignKey(d => d.FuncRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SalarySettings_dbo.AppFuncRoles_FuncRoleId");

                entity.HasOne(d => d.Object1)
                    .WithMany(p => p.SalarySettings)
                    .HasForeignKey(d => d.Object1Id)
                    .HasConstraintName("FK_dbo.SalarySettings_dbo.Object1_Object1Id");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat)
                    .HasName("IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => e.Score)
                    .HasName("IX_HangFire_Set_Score")
                    .HasFilter("([Score] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<StopLists>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaskControllingPersons>(entity =>
            {
                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.TaskId)
                    .HasName("IX_TaskId");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.TaskControllingPersons)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.ControllingPersons_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskControllingPersons)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_dbo.ControllingPersons_dbo.Tasks_TaskId");
            });

            modelBuilder.Entity<TaskDbModels>(entity =>
            {
                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.Property(e => e.FilePath).HasMaxLength(100);

                entity.Property(e => e.For).HasColumnType("datetime");

                entity.Property(e => e.Since).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.TaskDbModels)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.TaskDbModels_dbo.AppUsers_AppUserId");
            });

            modelBuilder.Entity<TaskDiscussionOfTheTasks>(entity =>
            {
                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.TaskId)
                    .HasName("IX_TaskId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FilePath).HasMaxLength(100);

                entity.Property(e => e.Text).HasMaxLength(2000);

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.TaskDiscussionOfTheTasks)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.DiscussionOfTheTasks_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskDiscussionOfTheTasks)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_dbo.DiscussionOfTheTasks_dbo.Tasks_TaskId");
            });

            modelBuilder.Entity<TaskStatusHistories>(entity =>
            {
                entity.HasIndex(e => e.UserTaskId)
                    .HasName("IX_UserTaskId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FilePath).HasMaxLength(100);

                entity.Property(e => e.Text).HasMaxLength(2000);

                entity.HasOne(d => d.UserTask)
                    .WithMany(p => p.TaskStatusHistories)
                    .HasForeignKey(d => d.UserTaskId)
                    .HasConstraintName("FK_dbo.TaskStatusHistories_dbo.TaskUserTasks_UserTaskId");
            });

            modelBuilder.Entity<TaskUserTasks>(entity =>
            {
                entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_AppUserId");

                entity.HasIndex(e => e.TaskId)
                    .HasName("IX_TaskId");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.TaskUserTasks)
                    .HasForeignKey(d => d.AppUserId)
                    .HasConstraintName("FK_dbo.UserTasks_dbo.AppUsers_AppUserId");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskUserTasks)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_dbo.UserTasks_dbo.Tasks_TaskId");
            });

            modelBuilder.Entity<UnloadColors>(entity =>
            {
                entity.Property(e => e.DefinedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserIntermediates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(32);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.Session).HasMaxLength(50);

                entity.Property(e => e.UserFio)
                    .IsRequired()
                    .HasColumnName("UserFIO");

                entity.Property(e => e.UserName).IsRequired();
            });
        }
    }
}
