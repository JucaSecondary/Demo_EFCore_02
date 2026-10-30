using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlayers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName", "NickName" },
                values: new object[,]
                {
                    { 1, "Katrine", "Heiton", "PotatoRagi" },
                    { 2, "Kaleena", "MacGilmartin", "VictoriousClovito" },
                    { 3, "Gay", "Mc Faul", "HirjiDisgusted" },
                    { 4, "Nealy", "Danielsky", "PalladiumDysprosium" },
                    { 5, "Lorita", "Blumire", "SickLonely" },
                    { 6, "Arleta", "Venables", "AliveTurnip" },
                    { 7, "Kimbell", "Tirte", "PotatoManil" },
                    { 8, "Roobbie", "Rosekilly", "AliveMizuchi" },
                    { 9, "Nita", "Dragon", "ToadValkyrie" },
                    { 10, "Olva", "Dukes", "MoscoviumObnoxious" },
                    { 11, "Leroy", "Jenkins", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
