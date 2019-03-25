using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class Invoices
    {
        public Invoices()
        {
            InvoiceNomenclatures = new HashSet<InvoiceNomenclatures>();
            InvoiceZeroShipments = new HashSet<InvoiceZeroShipments>();
        }

        public int InvoicesId { get; set; }
        public string NunberInvoice { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Acceptor { get; set; }
        public int? AddUserId { get; set; }
        public int? AppUserId { get; set; }
        public string Drivers { get; set; }
        public string Auto { get; set; }
        public int Subdivision { get; set; }
        public int FilialId { get; set; }
        public string Comment { get; set; }
        public int? CreatorId { get; set; }

        public virtual AppUsers AppUser { get; set; }
        public virtual AppUsers Creator { get; set; }
        public virtual ICollection<InvoiceNomenclatures> InvoiceNomenclatures { get; set; }
        public virtual ICollection<InvoiceZeroShipments> InvoiceZeroShipments { get; set; }
    }
}
