using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_School.Migrations
{
    public partial class Docent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docent_Locaties_LocatieId",
                table: "Docent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Docent",
                table: "Docent");

            migrationBuilder.RenameTable(
                name: "Docent",
                newName: "Docenten");

            migrationBuilder.RenameIndex(
                name: "IX_Docent_LocatieId",
                table: "Docenten",
                newName: "IX_Docenten_LocatieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Docenten",
                table: "Docenten",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Docenten_Locaties_LocatieId",
                table: "Docenten",
                column: "LocatieId",
                principalTable: "Locaties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docenten_Locaties_LocatieId",
                table: "Docenten");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Docenten",
                table: "Docenten");

            migrationBuilder.RenameTable(
                name: "Docenten",
                newName: "Docent");

            migrationBuilder.RenameIndex(
                name: "IX_Docenten_LocatieId",
                table: "Docent",
                newName: "IX_Docent_LocatieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Docent",
                table: "Docent",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Docent_Locaties_LocatieId",
                table: "Docent",
                column: "LocatieId",
                principalTable: "Locaties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
