using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace iPes_Converter.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            Database.SetCommandTimeout(15000000);
        }

        public virtual DbSet<Auto>? Auta { get; set; }
        public virtual DbSet<Dochazka>? Dochazka { get; set; }
        public virtual DbSet<Odbor>? Odbory { get; set; }
        public virtual DbSet<Parametry>? Parametry { get; set; }
        public virtual DbSet<PracdenRok>? Pracdny { get; set; }
        public virtual DbSet<Rezauta>? Rezaut { get; set; }
        public virtual DbSet<Svatek>? Svatky { get; set; }
        public virtual DbSet<Udalost>? Udalosti { get; set; }
        public virtual DbSet<Zamestnanec>? Zamestnanci { get; set; }
        public virtual DbSet<RoleZamestnanec>? RoleZamestnancu { get; set; }
    }
}
