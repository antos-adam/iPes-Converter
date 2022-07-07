using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DochazkaAPI.Models
{
    public partial class Dochazka
    {
        [Key]
        public int IdDoch { get; set; }
        public short IdZam { get; set; }
        [ForeignKey("IdZam")]
        public Zamestnanec? Zamestnanec { get; set; }
        public short IdOdbor { get; set; }
        public short IdUdalosti { get; set; }
        [ForeignKey("IdUdalosti")]
        public Udalost? Udalost { get; set; }
        public DateTime Zacatek { get; set; }
        public DateTime Konec { get; set; }
        public byte Kvedzac { get; set; }
        public byte Kvedkon { get; set; }
        public double? Pocpracdnu { get; set; }
        public DateTime? RecZac { get; set; }
        public DateTime? RecKon { get; set; }
    }
}
