using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iPes_Converter.Models
{
    public partial class Odbor
    {
        [Key]
        public short IdOdbor { get; set; }
        public string? NazevOd { get; set; }
        public string? ZkrOd { get; set; }
        public ICollection<Zamestnanec>? Zamestnanci { get; set; }
    }
}
