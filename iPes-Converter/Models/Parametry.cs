using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DochazkaAPI.Models
{
    public partial class Parametry
    {
        [Key]
        public short IdParam { get; set; }
        public string? Nazevorg { get; set; }
        public short DelObed { get; set; }
        public short KorekceZacatek { get; set; }
        public short KorekceKonec { get; set; }
        public short IdPd { get; set; }
        public short IdObed { get; set; }
        public string? MinZacPdGt { get; set; }
        public string? TsUstredna { get; set; }
        public short? RefreshInt { get; set; }
    }
}
