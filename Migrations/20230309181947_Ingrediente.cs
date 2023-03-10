using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cafenea.Migrations
{
    public partial class Ingrediente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aroma",
                table: "Cafea");

            migrationBuilder.DropColumn(
                name: "Lapte",
                table: "Cafea");

            migrationBuilder.DropColumn(
                name: "TipCafea",
                table: "Cafea");

            migrationBuilder.DropColumn(
                name: "Topping",
                table: "Cafea");

            migrationBuilder.AlterColumn<decimal>(
                name: "PretFinal",
                table: "Cafea",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "AromaID",
                table: "Cafea",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LapteID",
                table: "Cafea",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipCafeaID",
                table: "Cafea",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToppingID",
                table: "Cafea",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Aroma",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DenumireAroma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aroma", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lapte",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DenumireLapte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lapte", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipCafea",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipCafea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Topping",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DenumireTopping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topping", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cafea_AromaID",
                table: "Cafea",
                column: "AromaID");

            migrationBuilder.CreateIndex(
                name: "IX_Cafea_LapteID",
                table: "Cafea",
                column: "LapteID");

            migrationBuilder.CreateIndex(
                name: "IX_Cafea_TipCafeaID",
                table: "Cafea",
                column: "TipCafeaID");

            migrationBuilder.CreateIndex(
                name: "IX_Cafea_ToppingID",
                table: "Cafea",
                column: "ToppingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cafea_Aroma_AromaID",
                table: "Cafea",
                column: "AromaID",
                principalTable: "Aroma",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cafea_Lapte_LapteID",
                table: "Cafea",
                column: "LapteID",
                principalTable: "Lapte",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cafea_TipCafea_TipCafeaID",
                table: "Cafea",
                column: "TipCafeaID",
                principalTable: "TipCafea",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cafea_Topping_ToppingID",
                table: "Cafea",
                column: "ToppingID",
                principalTable: "Topping",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cafea_Aroma_AromaID",
                table: "Cafea");

            migrationBuilder.DropForeignKey(
                name: "FK_Cafea_Lapte_LapteID",
                table: "Cafea");

            migrationBuilder.DropForeignKey(
                name: "FK_Cafea_TipCafea_TipCafeaID",
                table: "Cafea");

            migrationBuilder.DropForeignKey(
                name: "FK_Cafea_Topping_ToppingID",
                table: "Cafea");

            migrationBuilder.DropTable(
                name: "Aroma");

            migrationBuilder.DropTable(
                name: "Lapte");

            migrationBuilder.DropTable(
                name: "TipCafea");

            migrationBuilder.DropTable(
                name: "Topping");

            migrationBuilder.DropIndex(
                name: "IX_Cafea_AromaID",
                table: "Cafea");

            migrationBuilder.DropIndex(
                name: "IX_Cafea_LapteID",
                table: "Cafea");

            migrationBuilder.DropIndex(
                name: "IX_Cafea_TipCafeaID",
                table: "Cafea");

            migrationBuilder.DropIndex(
                name: "IX_Cafea_ToppingID",
                table: "Cafea");

            migrationBuilder.DropColumn(
                name: "AromaID",
                table: "Cafea");

            migrationBuilder.DropColumn(
                name: "LapteID",
                table: "Cafea");

            migrationBuilder.DropColumn(
                name: "TipCafeaID",
                table: "Cafea");

            migrationBuilder.DropColumn(
                name: "ToppingID",
                table: "Cafea");

            migrationBuilder.AlterColumn<decimal>(
                name: "PretFinal",
                table: "Cafea",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AddColumn<string>(
                name: "Aroma",
                table: "Cafea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lapte",
                table: "Cafea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipCafea",
                table: "Cafea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Topping",
                table: "Cafea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
