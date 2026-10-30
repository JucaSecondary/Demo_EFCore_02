using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
  /// <inheritdoc />
  public partial class Initialize : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Players",
          columns: table => new
          {
            Id = table.Column<int>(type: "int", nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            LastName = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
            NickName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Players", x => x.Id)
                      .Annotation("SqlServer:Clustered", true);
          });

      migrationBuilder.CreateIndex(
          name: "IDX_Players_Name",
          table: "Players",
          columns: new[] { "FirstName", "LastName" },
          unique: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Players");
    }
  }
}