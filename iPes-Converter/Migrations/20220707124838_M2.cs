using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DochazkaAPI.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_RoleZamestnancu_IdZam",
                table: "RoleZamestnancu",
                column: "IdZam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleZamestnancu");
        }
    }
}
