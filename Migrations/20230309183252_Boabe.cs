using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cafenea.Migrations
{
    public partial class Boabe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipBoabeID",
                table: "Cafea",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TipBoabe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DenumireBoabe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipBoabe", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cafea_TipBoabeID",
                table: "Cafea",
                column: "TipBoabeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cafea_TipBoabe_TipBoabeID",
                table: "Cafea",
                column: "TipBoabeID",
                principalTable: "TipBoabe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cafea_TipBoabe_TipBoabeID",
                table: "Cafea");

            migrationBuilder.DropTable(
                name: "TipBoabe");

            migrationBuilder.DropIndex(
                name: "IX_Cafea_TipBoabeID",
                table: "Cafea");

            migrationBuilder.DropColumn(
                name: "TipBoabeID",
                table: "Cafea");
        }
    }
}
