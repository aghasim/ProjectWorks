using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Nomenclatures
    {
        public Nomenclatures()
        {
            LoadDocs = new HashSet<LoadDocs>();
            LoadRevisionNots = new HashSet<LoadRevisionNots>();
            LoadRevisionOks = new HashSet<LoadRevisionOks>();
            LoadSchetLogs = new HashSet<LoadSchetLogs>();
            LoadSchets = new HashSet<LoadSchets>();
            NomenclatureBus = new HashSet<NomenclatureBus>();
            Object1 = new HashSet<Object1>();
            PointReportNoms = new HashSet<PointReportNoms>();
            PointReportNomsLogs = new HashSet<PointReportNomsLogs>();
            PointStatNoms = new HashSet<PointStatNoms>();
            PriceCompetitorVisions = new HashSet<PriceCompetitorVisions>();
            PriceCompetitors = new HashSet<PriceCompetitors>();
            PriceListFirsts = new HashSet<PriceListFirsts>();
            PriceListIndependents = new HashSet<PriceListIndependents>();
            PriceListSeconds = new HashSet<PriceListSeconds>();
            RemnantsFixationAnswerDetails = new HashSet<RemnantsFixationAnswerDetails>();
            RemnantsFixationMaterials = new HashSet<RemnantsFixationMaterials>();
        }

        public int Id { get; set; }
        public string Code1C { get; set; }
        public string Name { get; set; }
        public bool IsGrp { get; set; }
        public int ParentId { get; set; }
        public int TopGrpId { get; set; }
        public int Rang { get; set; }
        public int SortIndex { get; set; }
        public string SortKey { get; set; }
        public string FullKey { get; set; }
        public int? BusinessId { get; set; }

        public virtual Business1C Business { get; set; }
        public virtual ICollection<LoadDocs> LoadDocs { get; set; }
        public virtual ICollection<LoadRevisionNots> LoadRevisionNots { get; set; }
        public virtual ICollection<LoadRevisionOks> LoadRevisionOks { get; set; }
        public virtual ICollection<LoadSchetLogs> LoadSchetLogs { get; set; }
        public virtual ICollection<LoadSchets> LoadSchets { get; set; }
        public virtual ICollection<NomenclatureBus> NomenclatureBus { get; set; }
        public virtual ICollection<Object1> Object1 { get; set; }
        public virtual ICollection<PointReportNoms> PointReportNoms { get; set; }
        public virtual ICollection<PointReportNomsLogs> PointReportNomsLogs { get; set; }
        public virtual ICollection<PointStatNoms> PointStatNoms { get; set; }
        public virtual ICollection<PriceCompetitorVisions> PriceCompetitorVisions { get; set; }
        public virtual ICollection<PriceCompetitors> PriceCompetitors { get; set; }
        public virtual ICollection<PriceListFirsts> PriceListFirsts { get; set; }
        public virtual ICollection<PriceListIndependents> PriceListIndependents { get; set; }
        public virtual ICollection<PriceListSeconds> PriceListSeconds { get; set; }
        public virtual ICollection<RemnantsFixationAnswerDetails> RemnantsFixationAnswerDetails { get; set; }
        public virtual ICollection<RemnantsFixationMaterials> RemnantsFixationMaterials { get; set; }
    }
}
