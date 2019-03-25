using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class PropertyValParams
    {
        public PropertyValParams()
        {
            Business1C = new HashSet<Business1C>();
            LoadSchets = new HashSet<LoadSchets>();
            LoadStat1C = new HashSet<LoadStat1C>();
            NomenclatureBus = new HashSet<NomenclatureBus>();
            PointDisposes = new HashSet<PointDisposes>();
            PointPlans = new HashSet<PointPlans>();
            PointReportNoms = new HashSet<PointReportNoms>();
            PointReportNomsLogs = new HashSet<PointReportNomsLogs>();
            PointStatNoms = new HashSet<PointStatNoms>();
            PriceCompetitorAvgs = new HashSet<PriceCompetitorAvgs>();
            PriceCompetitorVisions = new HashSet<PriceCompetitorVisions>();
            PriceCompetitors = new HashSet<PriceCompetitors>();
            PropertyValues = new HashSet<PropertyValues>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int PropertyId { get; set; }
        public bool NotDel { get; set; }

        public virtual Properties Property { get; set; }
        public virtual ICollection<Business1C> Business1C { get; set; }
        public virtual ICollection<LoadSchets> LoadSchets { get; set; }
        public virtual ICollection<LoadStat1C> LoadStat1C { get; set; }
        public virtual ICollection<NomenclatureBus> NomenclatureBus { get; set; }
        public virtual ICollection<PointDisposes> PointDisposes { get; set; }
        public virtual ICollection<PointPlans> PointPlans { get; set; }
        public virtual ICollection<PointReportNoms> PointReportNoms { get; set; }
        public virtual ICollection<PointReportNomsLogs> PointReportNomsLogs { get; set; }
        public virtual ICollection<PointStatNoms> PointStatNoms { get; set; }
        public virtual ICollection<PriceCompetitorAvgs> PriceCompetitorAvgs { get; set; }
        public virtual ICollection<PriceCompetitorVisions> PriceCompetitorVisions { get; set; }
        public virtual ICollection<PriceCompetitors> PriceCompetitors { get; set; }
        public virtual ICollection<PropertyValues> PropertyValues { get; set; }
    }
}
