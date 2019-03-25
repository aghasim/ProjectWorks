using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class RemnantsFixationAnswerDetails
    {
        public int RemnantsFixationAnswerDetailId { get; set; }
        public double Remnants { get; set; }
        public int RemnantsFixationAnswerId { get; set; }
        public int NomenclatureId { get; set; }

        public virtual Nomenclatures Nomenclature { get; set; }
        public virtual RemnantsFixationAnswers RemnantsFixationAnswer { get; set; }
    }
}
