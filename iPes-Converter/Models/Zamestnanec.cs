using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DochazkaAPI.Models
{
    public partial class Zamestnanec
    {
        [Key]
        public short IdZam { get; set; }
        public short IdOdbor { get; set; }
        [ForeignKey("IdOdbor")]
        public Odbor? Odbor { get; set; }
        public string? Prijmeni { get; set; }
        public string? Jmeno { get; set; }
        public string? Titul { get; set; }
        public string? DomenaPrihlasovaciJmeno { get; set; }
        public double Denuvazek { get; set; }
        public double? Mesuvazek { get; set; }
        //public bool Vedouci { get; set; }
        //public bool AdminRa { get; set; }
        //public bool AdminDo { get; set; }
        //public bool AdminAll { get; set; }
        //public bool PrObedy { get; set; } - sestavy obědů - neřešit (bude v roli Personalista)
        //public bool PrPritomnost { get; set; } - nahlížení do přítomnosti (mají všichni)
        //public short PrDochazka { get; set; } - bude se řídit dle rolí
        public bool? ZobrazVKontPritom { get; set; } //Pr3 - zobrazovat v kontaktech + přítomnosti
        public bool? NevkladatPauzuObed { get; set; } //Pr4 - nevkládat automaticky pauzu na oběd (asi zůstává)
        public bool? NezkracovatPriViceHod { get; set; } //Pr5 - nezkracovat při zadání více hodin než je úvazek
        public bool? NezobrazVNepritomnosti { get; set; } //Pr0 - nezobrazovat v nepřítomnosti zaměstnanců
        public bool Vyrazen { get; set; }
        //public short IdSqluser { get; set; }
        public string? TsMobil { get; set; }
        public string? TsPevna { get; set; }
        public string? TsEmail { get; set; }
        public DateTime? TsDaktmob { get; set; }
        public DateTime? TsDaktpev { get; set; }
        public ICollection<Dochazka>? Dochazka { get; set; }
        public ICollection<Rezauta>? Rezaut { get; set; }
    }
}
