using System;
using System.Collections.Generic;

namespace iPes_Converter.ModelsOld
{
    public partial class Zamest
    {
        public Zamest()
        {
            Dochazkas = new HashSet<Dochazka>();
            Rezauts = new HashSet<Rezaut>();
            Wwwpracs = new HashSet<Wwwprac>();
        }

        public short IdZam { get; set; }
        public short IdOdbor { get; set; }
        public string Prijmeni { get; set; } = null!;
        public string Jmeno { get; set; } = null!;
        public string? Titul { get; set; }
        public decimal Denuvazek { get; set; }
        public decimal Mesuvazek { get; set; }
        public bool Vedouci { get; set; }
        public bool AdminRa { get; set; }
        public bool AdminDo { get; set; }
        public bool AdminAll { get; set; }
        public bool PrObedy { get; set; }
        public bool PrPritomnost { get; set; }
        public short PrDochazka { get; set; }
        public bool? Pr1 { get; set; }
        public bool? Pr2 { get; set; }
        public bool? Pr3 { get; set; }
        public bool? Pr4 { get; set; }
        public bool? Pr5 { get; set; }
        public bool? Pr6 { get; set; }
        public bool? Pr7 { get; set; }
        public bool? Pr8 { get; set; }
        public bool? Pr9 { get; set; }
        public bool? Pr0 { get; set; }
        public bool Vyrazen { get; set; }
        public short IdSqluser { get; set; }
        public string? TsMobil { get; set; }
        public string? TsPevna { get; set; }
        public string? TsEmail { get; set; }
        public DateTime? TsDaktmob { get; set; }
        public DateTime? TsDaktpev { get; set; }

        public virtual Odbory IdOdborNavigation { get; set; } = null!;
        public virtual Hesla Hesla { get; set; } = null!;
        public virtual ICollection<Dochazka> Dochazkas { get; set; }
        public virtual ICollection<Rezaut> Rezauts { get; set; }
        public virtual ICollection<Wwwprac> Wwwpracs { get; set; }
    }
}
