using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iPes_Converter.Models
{
    public partial class Svatek
    {
        [Key]
        public short IdSvatku { get; set; }
        public DateTime DatSvat { get; set; }
        public string? NazSvat { get; set; }
    }
}
