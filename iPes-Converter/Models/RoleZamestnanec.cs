using iPes_Converter.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iPes_Converter.Models
{
    public class RoleZamestnanec
    {
        [Key]
        public int IdRoleZam { get; set; }
        public short IdZam { get; set; }
        [ForeignKey("IdZam")]
        public Zamestnanec? Zamestnanec { get; set; }
        public RoleEnum Role { get; set; }
        public AgendaEnum Agenda { get; set; }
        public bool VychoziRole { get; set; }
    }
}
