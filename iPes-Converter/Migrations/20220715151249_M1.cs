using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iPes_Converter.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auta",
                columns: table => new
                {
                    IdAuta = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Typauta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spotreba = table.Column<double>(type: "float", nullable: true),
                    Barva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Techstav = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maxpocmist = table.Column<byte>(type: "tinyint", nullable: true),
                    Vyrazeno = table.Column<bool>(type: "bit", nullable: false),
                    Benzin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Techkontr = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Platnostccs = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auta", x => x.IdAuta);
                });

            migrationBuilder.CreateTable(
                name: "Odbory",
                columns: table => new
                {
                    IdOdbor = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazevOd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZkrOd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odbory", x => x.IdOdbor);
                });

            migrationBuilder.CreateTable(
                name: "Parametry",
                columns: table => new
                {
                    IdParam = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazevorg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DelObed = table.Column<short>(type: "smallint", nullable: false),
                    KorekceZacatek = table.Column<short>(type: "smallint", nullable: false),
                    KorekceKonec = table.Column<short>(type: "smallint", nullable: false),
                    IdPd = table.Column<short>(type: "smallint", nullable: false),
                    IdObed = table.Column<short>(type: "smallint", nullable: false),
                    MinZacPdGt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TsUstredna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshInt = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametry", x => x.IdParam);
                });

            migrationBuilder.CreateTable(
                name: "Pracdny",
                columns: table => new
                {
                    Rok = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mes01 = table.Column<int>(type: "int", nullable: false),
                    Mes02 = table.Column<int>(type: "int", nullable: false),
                    Mes03 = table.Column<int>(type: "int", nullable: false),
                    Mes04 = table.Column<int>(type: "int", nullable: false),
                    Mes05 = table.Column<int>(type: "int", nullable: false),
                    Mes06 = table.Column<int>(type: "int", nullable: false),
                    Mes07 = table.Column<int>(type: "int", nullable: false),
                    Mes08 = table.Column<int>(type: "int", nullable: false),
                    Mes09 = table.Column<int>(type: "int", nullable: false),
                    Mes10 = table.Column<int>(type: "int", nullable: false),
                    Mes11 = table.Column<int>(type: "int", nullable: false),
                    Mes12 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracdny", x => x.Rok);
                });

            migrationBuilder.CreateTable(
                name: "Svatky",
                columns: table => new
                {
                    IdSvatku = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatSvat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NazSvat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Svatky", x => x.IdSvatku);
                });

            migrationBuilder.CreateTable(
                name: "Udalosti",
                columns: table => new
                {
                    IdUdalosti = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZkrUdal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preruseni = table.Column<bool>(type: "bit", nullable: false),
                    Zakladni = table.Column<bool>(type: "bit", nullable: false),
                    System = table.Column<bool>(type: "bit", nullable: false),
                    VypPracdoby = table.Column<short>(type: "smallint", nullable: false),
                    VypObedy = table.Column<short>(type: "smallint", nullable: false),
                    DatumIn = table.Column<bool>(type: "bit", nullable: false),
                    CasIn = table.Column<bool>(type: "bit", nullable: false),
                    DnyIn = table.Column<bool>(type: "bit", nullable: true),
                    MinDny = table.Column<double>(type: "float", nullable: false),
                    MaxDny = table.Column<double>(type: "float", nullable: false),
                    MinCas = table.Column<int>(type: "int", nullable: true),
                    MaxCas = table.Column<int>(type: "int", nullable: true),
                    Prepovol = table.Column<bool>(type: "bit", nullable: false),
                    MaxOpak = table.Column<short>(type: "smallint", nullable: false),
                    Vysvetlivky = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypuTisk = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Udalosti", x => x.IdUdalosti);
                });

            migrationBuilder.CreateTable(
                name: "Zamestnanci",
                columns: table => new
                {
                    IdZam = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOdbor = table.Column<short>(type: "smallint", nullable: false),
                    Prijmeni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jmeno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titul = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomenaPrihlasovaciJmeno = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Denuvazek = table.Column<double>(type: "float", nullable: false),
                    Mesuvazek = table.Column<double>(type: "float", nullable: true),
                    ZobrazVKontPritom = table.Column<bool>(type: "bit", nullable: true),
                    NevkladatPauzuObed = table.Column<bool>(type: "bit", nullable: true),
                    NezkracovatPriViceHod = table.Column<bool>(type: "bit", nullable: true),
                    NezobrazVNepritomnosti = table.Column<bool>(type: "bit", nullable: true),
                    Vyrazen = table.Column<bool>(type: "bit", nullable: false),
                    TsMobil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TsPevna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TsEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TsDaktmob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TsDaktpev = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamestnanci", x => x.IdZam);
                    table.ForeignKey(
                        name: "FK_Zamestnanci_Odbory_IdOdbor",
                        column: x => x.IdOdbor,
                        principalTable: "Odbory",
                        principalColumn: "IdOdbor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dochazka",
                columns: table => new
                {
                    IdDoch = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdZam = table.Column<short>(type: "smallint", nullable: false),
                    IdOdbor = table.Column<short>(type: "smallint", nullable: false),
                    IdUdalosti = table.Column<short>(type: "smallint", nullable: false),
                    Zacatek = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Konec = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kvedzac = table.Column<byte>(type: "tinyint", nullable: false),
                    Kvedkon = table.Column<byte>(type: "tinyint", nullable: false),
                    Pocpracdnu = table.Column<double>(type: "float", nullable: true),
                    RecZac = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RecKon = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dochazka", x => x.IdDoch);
                    table.ForeignKey(
                        name: "FK_Dochazka_Udalosti_IdUdalosti",
                        column: x => x.IdUdalosti,
                        principalTable: "Udalosti",
                        principalColumn: "IdUdalosti",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dochazka_Zamestnanci_IdZam",
                        column: x => x.IdZam,
                        principalTable: "Zamestnanci",
                        principalColumn: "IdZam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezaut",
                columns: table => new
                {
                    IdRezerv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdZam = table.Column<short>(type: "smallint", nullable: false),
                    RezervOd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RezervDo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdOdbor = table.Column<short>(type: "smallint", nullable: false),
                    Cesta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duvod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSpolc1 = table.Column<int>(type: "int", nullable: false),
                    IdRidic = table.Column<int>(type: "int", nullable: false),
                    IdSpolc2 = table.Column<int>(type: "int", nullable: false),
                    IdSpolc3 = table.Column<int>(type: "int", nullable: false),
                    IdSpolc4 = table.Column<int>(type: "int", nullable: false),
                    Zmenaterm = table.Column<bool>(type: "bit", nullable: false),
                    IdSpolc5 = table.Column<int>(type: "int", nullable: false),
                    Dulezitost = table.Column<byte>(type: "tinyint", nullable: false),
                    Stavrez = table.Column<byte>(type: "tinyint", nullable: false),
                    Pozadavky = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poznamky = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZamDele = table.Column<bool>(type: "bit", nullable: false),
                    OdpRead = table.Column<bool>(type: "bit", nullable: false),
                    IdAuta = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezaut", x => x.IdRezerv);
                    table.ForeignKey(
                        name: "FK_Rezaut_Auta_IdAuta",
                        column: x => x.IdAuta,
                        principalTable: "Auta",
                        principalColumn: "IdAuta");
                    table.ForeignKey(
                        name: "FK_Rezaut_Zamestnanci_IdZam",
                        column: x => x.IdZam,
                        principalTable: "Zamestnanci",
                        principalColumn: "IdZam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleZamestnancu",
                columns: table => new
                {
                    IdRoleZam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdZam = table.Column<short>(type: "smallint", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Agenda = table.Column<int>(type: "int", nullable: false),
                    VychoziRole = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleZamestnancu", x => x.IdRoleZam);
                    table.ForeignKey(
                        name: "FK_RoleZamestnancu_Zamestnanci_IdZam",
                        column: x => x.IdZam,
                        principalTable: "Zamestnanci",
                        principalColumn: "IdZam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dochazka_IdUdalosti",
                table: "Dochazka",
                column: "IdUdalosti");

            migrationBuilder.CreateIndex(
                name: "IX_Dochazka_IdZam",
                table: "Dochazka",
                column: "IdZam");

            migrationBuilder.CreateIndex(
                name: "IX_Dochazka_Konec",
                table: "Dochazka",
                column: "Konec");

            migrationBuilder.CreateIndex(
                name: "IX_Dochazka_Zacatek",
                table: "Dochazka",
                column: "Zacatek");

            migrationBuilder.CreateIndex(
                name: "IX_Rezaut_IdAuta",
                table: "Rezaut",
                column: "IdAuta");

            migrationBuilder.CreateIndex(
                name: "IX_Rezaut_IdZam",
                table: "Rezaut",
                column: "IdZam");

            migrationBuilder.CreateIndex(
                name: "IX_RoleZamestnancu_IdZam",
                table: "RoleZamestnancu",
                column: "IdZam");

            migrationBuilder.CreateIndex(
                name: "IX_Zamestnanci_DomenaPrihlasovaciJmeno",
                table: "Zamestnanci",
                column: "DomenaPrihlasovaciJmeno");

            migrationBuilder.CreateIndex(
                name: "IX_Zamestnanci_IdOdbor",
                table: "Zamestnanci",
                column: "IdOdbor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dochazka");

            migrationBuilder.DropTable(
                name: "Parametry");

            migrationBuilder.DropTable(
                name: "Pracdny");

            migrationBuilder.DropTable(
                name: "Rezaut");

            migrationBuilder.DropTable(
                name: "RoleZamestnancu");

            migrationBuilder.DropTable(
                name: "Svatky");

            migrationBuilder.DropTable(
                name: "Udalosti");

            migrationBuilder.DropTable(
                name: "Auta");

            migrationBuilder.DropTable(
                name: "Zamestnanci");

            migrationBuilder.DropTable(
                name: "Odbory");
        }
    }
}
