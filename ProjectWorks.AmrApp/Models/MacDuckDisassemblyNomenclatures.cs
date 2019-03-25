using System;
using System.Collections.Generic;

namespace ProjectWorks.AmrApp.Models
{
    public partial class MacDuckDisassemblyNomenclatures
    {
        public string Id { get; set; }
        public string DisassemblyId { get; set; }
        public double Garbagge { get; set; }
        public int NomenclatureId { get; set; }
        public decimal Price { get; set; }
        public double StandartGarbagge { get; set; }
        public double Weight { get; set; }

        public virtual MacDuckDisassemblies Disassembly { get; set; }
        public virtual Object1 Nomenclature { get; set; }
    }
}
