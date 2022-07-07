using System;
using System.Collections.Generic;

namespace iPes_Converter.ModelsOld
{
    public partial class Odbory
    {
        public Odbory()
        {
            Zamests = new HashSet<Zamest>();
        }

        public short IdOdbor { get; set; }
        public string NazevOd { get; set; } = null!;
        public string ZkrOd { get; set; } = null!;

        public virtual ICollection<Zamest> Zamests { get; set; }
    }
}
