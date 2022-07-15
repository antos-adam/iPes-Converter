using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iPes_Converter.Models
{
    public partial class Rezauta
    {
        [Key]
        public int IdRezerv { get; set; }
        public short IdZam { get; set; }
        [ForeignKey("IdZam")]
        public Zamestnanec? Zamestnanec { get; set; }
        public DateTime RezervOd { get; set; }
        public DateTime RezervDo { get; set; }
        public short IdOdbor { get; set; }
        public string? Cesta { get; set; }
        public string? Duvod { get; set; }
        public int IdSpolc1 { get; set; }
        public int IdRidic { get; set; }
        public int IdSpolc2 { get; set; }
        public int IdSpolc3 { get; set; }
        public int IdSpolc4 { get; set; }
        public bool Zmenaterm { get; set; }
        public int IdSpolc5 { get; set; }
        public byte Dulezitost { get; set; }
        public byte Stavrez { get; set; }
        public string? Pozadavky { get; set; }
        public string? Poznamky { get; set; }
        public bool ZamDele { get; set; }
        public bool OdpRead { get; set; }

        public short? IdAuta { get; set; }
        [ForeignKey("IdAuta")]
        public Auto? Auto { get; set; }
    }
}
