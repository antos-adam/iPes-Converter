using System;
using System.Collections.Generic;

namespace iPes_Converter.ModelsOld
{
    public partial class WwwpracVyber
    {
        public string PageUrl { get; set; } = null!;
        public string? PopisUrl { get; set; }
        public string NazTypuUrl { get; set; } = null!;
        public string? JmenoAutor { get; set; }
        public DateTime? DatAutor { get; set; }
        public short Protokol { get; set; }
    }
}
