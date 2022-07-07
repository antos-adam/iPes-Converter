using System;
using System.Collections.Generic;

namespace iPes_Converter.ModelsOld
{
    public partial class Dochazka
    {
        public int IdDoch { get; set; }
        public short IdZam { get; set; }
        public short IdOdbor { get; set; }
        public short IdUdalosti { get; set; }
        public DateTime Zacatek { get; set; }
        public DateTime Konec { get; set; }
        public byte Kvedzac { get; set; }
        public byte Kvedkon { get; set; }
        public decimal? Pocpracdnu { get; set; }
        public DateTime? RecZac { get; set; }
        public DateTime? RecKon { get; set; }

        public virtual Zamest Id { get; set; } = null!;
        public virtual Udalost IdUdalostiNavigation { get; set; } = null!;
    }
}
