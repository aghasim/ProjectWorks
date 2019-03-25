using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class InvoiceZeroShipments
    {
        public int ZeroShipmentId { get; set; }
        public int PointId { get; set; }
        public string PointName { get; set; }
        public int NomenclatureId { get; set; }
        public string NomenclatureName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime ShipmentDate { get; set; }
        public int? InvoiceId { get; set; }

        public virtual Invoices Invoice { get; set; }
    }
}
