using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DochazkaAPI.Models
{
    public partial class Auto
    {
        [Key]
        public short IdAuta { get; set; }
        public string? Typauta { get; set; }
        public double? Spotreba { get; set; }
        public string? Barva { get; set; }
        public string? Spz { get; set; }
        public string? Techstav { get; set; }
        public byte? Maxpocmist { get; set; }
        public bool Vyrazeno { get; set; }
        public string? Benzin { get; set; }
        public DateTime? Techkontr { get; set; }
        public DateTime? Platnostccs { get; set; }
        public ICollection<Rezauta>? Rezaut { get; set; }
    }
}
