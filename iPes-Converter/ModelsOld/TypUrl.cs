using System;
using System.Collections.Generic;

namespace iPes_Converter.ModelsOld
{
    public partial class TypUrl
    {
        public TypUrl()
        {
            Wwwpracs = new HashSet<Wwwprac>();
        }

        public int IdTypUrl { get; set; }
        public string NazTypuUrl { get; set; } = null!;

        public virtual ICollection<Wwwprac> Wwwpracs { get; set; }
    }
}
