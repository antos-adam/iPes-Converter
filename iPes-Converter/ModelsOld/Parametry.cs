using System;
using System.Collections.Generic;

namespace iPes_Converter.ModelsOld
{
    public partial class Parametry
    {
        public string Nazevorg { get; set; } = null!;
        public short DelObed { get; set; }
        public short IdParam { get; set; }
        public short KorekceZacatek { get; set; }
        public short KorekceKonec { get; set; }
        public short IdPd { get; set; }
        public short IdObed { get; set; }
        public string? MinZacPdGt { get; set; }
        public string? TsUstredna { get; set; }
        public short? RefreshInt { get; set; }
    }
}
