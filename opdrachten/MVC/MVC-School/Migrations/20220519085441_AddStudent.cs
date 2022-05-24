using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_School.Migrations
{
    public partial class AddStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Docent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Achternaam = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LocatieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Docent_Locaties_LocatieId",
                        column: x => x.LocatieId,
                        principalTable: "Locaties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Docent_LocatieId",
                table: "Docent",
                column: "LocatieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docent");
        }
    }
}
