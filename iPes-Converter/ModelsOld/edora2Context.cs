using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace iPes_Converter.ModelsOld
{
    public partial class edora2Context : DbContext
    {
        public edora2Context()
        {
        }

        public edora2Context(DbContextOptions<edora2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Autum> Auta { get; set; } = null!;
        public virtual DbSet<Dochazka> Dochazkas { get; set; } = null!;
        public virtual DbSet<Hesla> Heslas { get; set; } = null!;
        public virtual DbSet<Odbory> Odbories { get; set; } = null!;
        public virtual DbSet<Parametry> Parametries { get; set; } = null!;
        public virtual DbSet<Pracdny> Pracdnies { get; set; } = null!;
        public virtual DbSet<Rezaut> Rezauts { get; set; } = null!;
        public virtual DbSet<Svatky> Svatkies { get; set; } = null!;
        public virtual DbSet<TypUrl> TypUrls { get; set; } = null!;
        public virtual DbSet<Udalost> Udalosts { get; set; } = null!;
        public virtual DbSet<Wwwprac> Wwwpracs { get; set; } = null!;
        public virtual DbSet<WwwpracVyber> WwwpracVybers { get; set; } = null!;
        public virtual DbSet<Zamest> Zamests { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=edora2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Czech_CP1250_CI_AS");

            modelBuilder.Entity<Autum>(entity =>
            {
                entity.HasKey(e => e.IdAuta)
                    .HasName("PK__auta__0519C6AF");

                entity.ToTable("auta");

                entity.Property(e => e.IdAuta).HasColumnName("id_auta");

                entity.Property(e => e.Barva)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("barva");

                entity.Property(e => e.Benzin)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("benzin");

                entity.Property(e => e.Maxpocmist).HasColumnName("maxpocmist");

                entity.Property(e => e.Parkuje)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parkuje");

                entity.Property(e => e.Platnostccs)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("platnostccs");

                entity.Property(e => e.Spotreba)
                    .HasColumnType("numeric(4, 1)")
                    .HasColumnName("spotreba");

                entity.Property(e => e.Spz)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("spz");

                entity.Property(e => e.Techkontr)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("techkontr");

                entity.Property(e => e.Techstav)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("techstav");

                entity.Property(e => e.Typauta)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("typauta");

                entity.Property(e => e.Vyrazeno).HasColumnName("vyrazeno");
            });

            modelBuilder.Entity<Dochazka>(entity =>
            {
                entity.HasKey(e => new { e.IdDoch, e.IdZam, e.IdOdbor, e.IdUdalosti })
                    .HasName("PK__dochazka__1FCDBCEB")
                    .IsClustered(false);

                entity.ToTable("dochazka");

                entity.HasIndex(e => e.Konec, "XIEkonec");

                entity.HasIndex(e => e.Zacatek, "XIEzacatek");

                entity.HasIndex(e => new { e.IdZam, e.IdOdbor }, "XIF7dochazka");

                entity.HasIndex(e => e.IdUdalosti, "XIF8dochazka");

                entity.Property(e => e.IdDoch)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_doch");

                entity.Property(e => e.IdZam).HasColumnName("id_zam");

                entity.Property(e => e.IdOdbor).HasColumnName("id_odbor");

                entity.Property(e => e.IdUdalosti).HasColumnName("id_udalosti");

                entity.Property(e => e.Konec)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("konec")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Kvedkon).HasColumnName("kvedkon");

                entity.Property(e => e.Kvedzac).HasColumnName("kvedzac");

                entity.Property(e => e.Pocpracdnu)
                    .HasColumnType("numeric(4, 1)")
                    .HasColumnName("pocpracdnu");

                entity.Property(e => e.RecKon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("rec_kon");

                entity.Property(e => e.RecZac)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("rec_zac");

                entity.Property(e => e.Zacatek)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("zacatek")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdUdalostiNavigation)
                    .WithMany(p => p.Dochazkas)
                    .HasForeignKey(d => d.IdUdalosti)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dochazka__id_uda__24927208");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.Dochazkas)
                    .HasForeignKey(d => new { d.IdZam, d.IdOdbor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__dochazka__25869641");
            });

            modelBuilder.Entity<Hesla>(entity =>
            {
                entity.HasKey(e => new { e.IdZam, e.IdOdbor })
                    .HasName("PK__hesla__656C112C");

                entity.ToTable("hesla");

                entity.Property(e => e.IdZam).HasColumnName("id_zam");

                entity.Property(e => e.IdOdbor).HasColumnName("id_odbor");

                entity.Property(e => e.DatZmeny)
                    .HasColumnType("datetime")
                    .HasColumnName("dat_zmeny");

                entity.Property(e => e.NewHeslo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("new_heslo");

                entity.Property(e => e.OldHeslo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("old_heslo");

                entity.HasOne(d => d.Id)
                    .WithOne(p => p.Hesla)
                    .HasForeignKey<Hesla>(d => new { d.IdZam, d.IdOdbor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__hesla__66603565");
            });

            modelBuilder.Entity<Odbory>(entity =>
            {
                entity.HasKey(e => e.IdOdbor)
                    .HasName("PK__odbory__76CBA758");

                entity.ToTable("odbory");

                entity.Property(e => e.IdOdbor).HasColumnName("id_odbor");

                entity.Property(e => e.NazevOd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nazev_od");

                entity.Property(e => e.ZkrOd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("zkr_od")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Parametry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("parametry");

                entity.Property(e => e.DelObed)
                    .HasColumnName("del_obed")
                    .HasDefaultValueSql("(30)");

                entity.Property(e => e.IdObed).HasColumnName("id_obed");

                entity.Property(e => e.IdParam)
                    .HasColumnName("ID_PARAM")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.IdPd).HasColumnName("id_pd");

                entity.Property(e => e.KorekceKonec).HasColumnName("korekce_konec");

                entity.Property(e => e.KorekceZacatek).HasColumnName("korekce_zacatek");

                entity.Property(e => e.MinZacPdGt)
                    .HasMaxLength(5)
                    .HasColumnName("min_zac_pd_gt")
                    .IsFixedLength();

                entity.Property(e => e.Nazevorg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nazevorg");

                entity.Property(e => e.RefreshInt).HasColumnName("refresh_int");

                entity.Property(e => e.TsUstredna)
                    .HasMaxLength(10)
                    .HasColumnName("ts_ustredna")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pracdny>(entity =>
            {
                entity.HasKey(e => e.Rok)
                    .HasName("PK__pracdny__276EDEB3");

                entity.ToTable("pracdny");

                entity.Property(e => e.Rok)
                    .ValueGeneratedNever()
                    .HasColumnName("rok");

                entity.Property(e => e.Mes01).HasColumnName("mes01");

                entity.Property(e => e.Mes02).HasColumnName("mes02");

                entity.Property(e => e.Mes03).HasColumnName("mes03");

                entity.Property(e => e.Mes04).HasColumnName("mes04");

                entity.Property(e => e.Mes05).HasColumnName("mes05");

                entity.Property(e => e.Mes06).HasColumnName("mes06");

                entity.Property(e => e.Mes07).HasColumnName("mes07");

                entity.Property(e => e.Mes08).HasColumnName("mes08");

                entity.Property(e => e.Mes09).HasColumnName("mes09");

                entity.Property(e => e.Mes10).HasColumnName("mes10");

                entity.Property(e => e.Mes11).HasColumnName("mes11");

                entity.Property(e => e.Mes12).HasColumnName("mes12");
            });

            modelBuilder.Entity<Rezaut>(entity =>
            {
                entity.HasKey(e => new { e.IdRezerv, e.IdZam, e.IdOdbor })
                    .HasName("PK__rezaut__4AB81AF0");

                entity.ToTable("rezaut");

                entity.HasIndex(e => new { e.IdZam, e.IdOdbor }, "XIF3rezaut");

                entity.HasIndex(e => e.IdAuta, "XIF6rezaut");

                entity.HasIndex(e => e.RezervDo, "xirezdo");

                entity.HasIndex(e => e.RezervOd, "xirezod");

                entity.Property(e => e.IdRezerv)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_rezerv");

                entity.Property(e => e.IdZam).HasColumnName("id_zam");

                entity.Property(e => e.IdOdbor).HasColumnName("id_odbor");

                entity.Property(e => e.Cesta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cesta");

                entity.Property(e => e.Dulezitost)
                    .HasColumnName("dulezitost")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Duvod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("duvod");

                entity.Property(e => e.IdAuta).HasColumnName("id_auta");

                entity.Property(e => e.IdRidic).HasColumnName("id_ridic");

                entity.Property(e => e.IdSpolc1).HasColumnName("id_spolc1");

                entity.Property(e => e.IdSpolc2).HasColumnName("id_spolc2");

                entity.Property(e => e.IdSpolc3).HasColumnName("id_spolc3");

                entity.Property(e => e.IdSpolc4).HasColumnName("id_spolc4");

                entity.Property(e => e.IdSpolc5).HasColumnName("id_spolc5");

                entity.Property(e => e.OdpRead).HasColumnName("odp_read");

                entity.Property(e => e.Pozadavky)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("pozadavky");

                entity.Property(e => e.Poznamky)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("poznamky");

                entity.Property(e => e.RezervDo)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("rezerv_do")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RezervOd)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("rezerv_od")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stavrez).HasColumnName("stavrez");

                entity.Property(e => e.ZamDele).HasColumnName("zam_dele");

                entity.Property(e => e.Zmenaterm).HasColumnName("zmenaterm");

                entity.HasOne(d => d.IdAutaNavigation)
                    .WithMany(p => p.Rezauts)
                    .HasForeignKey(d => d.IdAuta)
                    .HasConstraintName("FK__rezaut__id_auta__5629CD9C");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.Rezauts)
                    .HasForeignKey(d => new { d.IdZam, d.IdOdbor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__rezaut__571DF1D5");
            });

            modelBuilder.Entity<Svatky>(entity =>
            {
                entity.HasKey(e => e.IdSvatku)
                    .HasName("PK__svatky__6383C8BA");

                entity.ToTable("svatky");

                entity.Property(e => e.IdSvatku).HasColumnName("id_svatku");

                entity.Property(e => e.DatSvat)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_svat");

                entity.Property(e => e.NazSvat)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("naz_svat");
            });

            modelBuilder.Entity<TypUrl>(entity =>
            {
                entity.HasKey(e => e.IdTypUrl)
                    .HasName("PK__typ_url__68487DD7");

                entity.ToTable("typ_url");

                entity.Property(e => e.IdTypUrl).HasColumnName("id_typ_url");

                entity.Property(e => e.NazTypuUrl)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("naz_typu_url");
            });

            modelBuilder.Entity<Udalost>(entity =>
            {
                entity.HasKey(e => e.IdUdalosti)
                    .HasName("PK__udalost__117F9D94");

                entity.ToTable("udalost");

                entity.Property(e => e.IdUdalosti).HasColumnName("id_udalosti");

                entity.Property(e => e.CasIn).HasColumnName("cas_in");

                entity.Property(e => e.DatumIn).HasColumnName("datum_in");

                entity.Property(e => e.DnyIn)
                    .HasColumnName("dny_in")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MaxCas)
                    .HasColumnName("max_cas")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.MaxDny)
                    .HasColumnType("numeric(4, 1)")
                    .HasColumnName("max_dny")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.MaxOpak).HasColumnName("max_opak");

                entity.Property(e => e.MinCas)
                    .HasColumnName("min_cas")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.MinDny)
                    .HasColumnType("numeric(4, 1)")
                    .HasColumnName("min_dny");

                entity.Property(e => e.Nazev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nazev");

                entity.Property(e => e.Prepovol).HasColumnName("prepovol");

                entity.Property(e => e.Preruseni).HasColumnName("preruseni");

                entity.Property(e => e.System).HasColumnName("system");

                entity.Property(e => e.TypuTisk).HasColumnName("typu_tisk");

                entity.Property(e => e.VypObedy).HasColumnName("vyp_obedy");

                entity.Property(e => e.VypPracdoby).HasColumnName("vyp_pracdoby");

                entity.Property(e => e.Vysvetlivky)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vysvetlivky");

                entity.Property(e => e.Zakladni).HasColumnName("zakladni");

                entity.Property(e => e.ZkrUdal)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("zkr_udal")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Wwwprac>(entity =>
            {
                entity.HasKey(e => e.IdWwwprac)
                    .HasName("PK__wwwprac__6A30C649");

                entity.ToTable("wwwprac");

                entity.HasIndex(e => e.PageUrl, "page_url")
                    .IsUnique();

                entity.Property(e => e.IdWwwprac).HasColumnName("id_wwwprac");

                entity.Property(e => e.Checked)
                    .HasColumnName("checked")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DatAutor)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_autor");

                entity.Property(e => e.DatOpravy)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_opravy");

                entity.Property(e => e.DatZapisu)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_zapisu");

                entity.Property(e => e.IdOdbor).HasColumnName("id_odbor");

                entity.Property(e => e.IdTypUrl).HasColumnName("id_typ_url");

                entity.Property(e => e.IdZam).HasColumnName("id_zam");

                entity.Property(e => e.IdZamAut).HasColumnName("id_zam_aut");

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("page_url");

                entity.Property(e => e.PopisUrl)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("popis_url");

                entity.Property(e => e.Protokol).HasColumnName("protokol");

                entity.Property(e => e.StatusUrl).HasColumnName("status_url");

                entity.HasOne(d => d.IdTypUrlNavigation)
                    .WithMany(p => p.Wwwpracs)
                    .HasForeignKey(d => d.IdTypUrl)
                    .HasConstraintName("FK__wwwprac__id_typ___6D0D32F4");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.Wwwpracs)
                    .HasForeignKey(d => new { d.IdZam, d.IdOdbor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__wwwprac__6E01572D");
            });

            modelBuilder.Entity<WwwpracVyber>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("wwwprac_vyber");

                entity.Property(e => e.DatAutor)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dat_autor");

                entity.Property(e => e.JmenoAutor)
                    .HasMaxLength(41)
                    .IsUnicode(false)
                    .HasColumnName("jmeno_autor");

                entity.Property(e => e.NazTypuUrl)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("naz_typu_url");

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("page_url");

                entity.Property(e => e.PopisUrl)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("popis_url");

                entity.Property(e => e.Protokol).HasColumnName("protokol");
            });

            modelBuilder.Entity<Zamest>(entity =>
            {
                entity.HasKey(e => new { e.IdZam, e.IdOdbor })
                    .HasName("PK__zamest__78B3EFCA");

                entity.ToTable("zamest");

                entity.HasIndex(e => e.IdOdbor, "XIF4zamest");

                entity.Property(e => e.IdZam)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_zam");

                entity.Property(e => e.IdOdbor).HasColumnName("id_odbor");

                entity.Property(e => e.AdminAll).HasColumnName("admin_all");

                entity.Property(e => e.AdminDo).HasColumnName("admin_do");

                entity.Property(e => e.AdminRa).HasColumnName("admin_ra");

                entity.Property(e => e.Denuvazek)
                    .HasColumnType("numeric(4, 1)")
                    .HasColumnName("denuvazek");

                entity.Property(e => e.IdSqluser).HasColumnName("id_sqluser");

                entity.Property(e => e.Jmeno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jmeno");

                entity.Property(e => e.Mesuvazek)
                    .HasColumnType("numeric(4, 1)")
                    .HasColumnName("mesuvazek");

                entity.Property(e => e.Pr0).HasColumnName("pr_0");

                entity.Property(e => e.Pr1).HasColumnName("pr_1");

                entity.Property(e => e.Pr2).HasColumnName("pr_2");

                entity.Property(e => e.Pr3).HasColumnName("pr_3");

                entity.Property(e => e.Pr4).HasColumnName("pr_4");

                entity.Property(e => e.Pr5).HasColumnName("pr_5");

                entity.Property(e => e.Pr6).HasColumnName("pr_6");

                entity.Property(e => e.Pr7).HasColumnName("pr_7");

                entity.Property(e => e.Pr8).HasColumnName("pr_8");

                entity.Property(e => e.Pr9).HasColumnName("pr_9");

                entity.Property(e => e.PrDochazka).HasColumnName("pr_dochazka");

                entity.Property(e => e.PrObedy).HasColumnName("pr_obedy");

                entity.Property(e => e.PrPritomnost).HasColumnName("pr_pritomnost");

                entity.Property(e => e.Prijmeni)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("prijmeni");

                entity.Property(e => e.Titul)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("titul");

                entity.Property(e => e.TsDaktmob)
                    .HasColumnType("datetime")
                    .HasColumnName("ts_daktmob");

                entity.Property(e => e.TsDaktpev)
                    .HasColumnType("datetime")
                    .HasColumnName("ts_daktpev");

                entity.Property(e => e.TsEmail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ts_email");

                entity.Property(e => e.TsMobil)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ts_mobil");

                entity.Property(e => e.TsPevna)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ts_pevna");

                entity.Property(e => e.Vedouci).HasColumnName("vedouci");

                entity.Property(e => e.Vyrazen).HasColumnName("vyrazen");

                entity.HasOne(d => d.IdOdborNavigation)
                    .WithMany(p => p.Zamests)
                    .HasForeignKey(d => d.IdOdbor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__zamest__id_odbor__03317E3D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
