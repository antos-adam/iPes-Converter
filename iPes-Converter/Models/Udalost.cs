using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DochazkaAPI.Models
{
    public partial class Udalost
    {
        [Key]
        public short IdUdalosti { get; set; }
        public string? ZkrUdal { get; set; }
        public string? Nazev { get; set; }
        public bool Preruseni { get; set; }
        public bool Zakladni { get; set; }
        public bool System { get; set; }
        public short VypPracdoby { get; set; }
        public short VypObedy { get; set; }
        public bool DatumIn { get; set; }
        public bool CasIn { get; set; }
        public bool? DnyIn { get; set; }
        public double MinDny { get; set; }
        public double MaxDny { get; set; }
        public int? MinCas { get; set; }
        public int? MaxCas { get; set; }
        public bool Prepovol { get; set; }
        public short MaxOpak { get; set; }
        public string? Vysvetlivky { get; set; }
        public short TypuTisk { get; set; }
        public ICollection<Dochazka>? Dochazka { get; set; }
    }
}
