using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DochazkaAPI.Models
{
    public partial class PracdenRok
    {
        [Key]
        public int PracDenId { get; set; }
        public int Rok { get; set; }
        public int Mes01 { get; set; }
        public int Mes02 { get; set; }
        public int Mes03 { get; set; }
        public int Mes04 { get; set; }
        public int Mes05 { get; set; }
        public int Mes06 { get; set; }
        public int Mes07 { get; set; }
        public int Mes08 { get; set; }
        public int Mes09 { get; set; }
        public int Mes10 { get; set; }
        public int Mes11 { get; set; }
        public int Mes12 { get; set; }
    }
}
