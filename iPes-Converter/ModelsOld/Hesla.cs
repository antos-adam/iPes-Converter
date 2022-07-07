using System;
using System.Collections.Generic;

namespace iPes_Converter.ModelsOld
{
    public partial class Hesla
    {
        public short IdZam { get; set; }
        public short IdOdbor { get; set; }
        public string NewHeslo { get; set; } = null!;
        public string? OldHeslo { get; set; }
        public DateTime DatZmeny { get; set; }

        public virtual Zamest Id { get; set; } = null!;
    }
}
