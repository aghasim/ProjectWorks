using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class InvoiceNomenclatures
    {
        public int InvoicesNomenclatureId { get; set; }
        public int NomenclatureId { get; set; }
        public double ShippingWeight { get; set; }
        public int CountBags { get; set; }
        public double Balance { get; set; }
        public double Admixtures { get; set; }
        public int InvoicesId { get; set; }
        public int Confirm { get; set; }
        public double ConfirmWeight { get; set; }
        public double ConfirmRemains { get; set; }
        public DateTime PeriodBeginning { get; set; }

        public virtual Invoices Invoices { get; set; }
    }
}
