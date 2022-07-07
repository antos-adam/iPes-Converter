using System;
using System.Collections.Generic;

namespace iPes_Converter.ModelsOld
{
    public partial class Rezaut
    {
        public int IdRezerv { get; set; }
        public short IdZam { get; set; }
        public DateTime RezervOd { get; set; }
        public DateTime RezervDo { get; set; }
        public short IdOdbor { get; set; }
        public string Cesta { get; set; } = null!;
        public string Duvod { get; set; } = null!;
        public int IdSpolc1 { get; set; }
        public int IdRidic { get; set; }
        public int IdSpolc2 { get; set; }
        public int IdSpolc3 { get; set; }
        public int IdSpolc4 { get; set; }
        public bool Zmenaterm { get; set; }
        public int IdSpolc5 { get; set; }
        public byte Dulezitost { get; set; }
        public short? IdAuta { get; set; }
        public byte Stavrez { get; set; }
        public string? Pozadavky { get; set; }
        public string? Poznamky { get; set; }
        public bool ZamDele { get; set; }
        public bool OdpRead { get; set; }

        public virtual Zamest Id { get; set; } = null!;
        public virtual Autum? IdAutaNavigation { get; set; }
    }
}
