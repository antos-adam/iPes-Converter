using System;
using System.Collections.Generic;

namespace iPes_Converter.ModelsOld
{
    public partial class Autum
    {
        public Autum()
        {
            Rezauts = new HashSet<Rezaut>();
        }

        public short IdAuta { get; set; }
        public string Typauta { get; set; } = null!;
        public decimal? Spotreba { get; set; }
        public string? Barva { get; set; }
        public string? Spz { get; set; }
        public string? Techstav { get; set; }
        public byte? Maxpocmist { get; set; }
        public bool Vyrazeno { get; set; }
        public string? Benzin { get; set; }
        public DateTime? Techkontr { get; set; }
        public DateTime? Platnostccs { get; set; }
        public string? Parkuje { get; set; }

        public virtual ICollection<Rezaut> Rezauts { get; set; }
    }
}
