using System;
using System.Collections.Generic;

namespace iPes_Converter.ModelsOld
{
    public partial class Wwwprac
    {
        public int IdWwwprac { get; set; }
        public short IdZam { get; set; }
        public short IdOdbor { get; set; }
        public short Protokol { get; set; }
        public string PageUrl { get; set; } = null!;
        public int? IdTypUrl { get; set; }
        public string? PopisUrl { get; set; }
        public short StatusUrl { get; set; }
        public DateTime? DatZapisu { get; set; }
        public DateTime? DatOpravy { get; set; }
        public int? IdZamAut { get; set; }
        public DateTime? DatAutor { get; set; }
        public bool? Checked { get; set; }

        public virtual Zamest Id { get; set; } = null!;
        public virtual TypUrl? IdTypUrlNavigation { get; set; }
    }
}
