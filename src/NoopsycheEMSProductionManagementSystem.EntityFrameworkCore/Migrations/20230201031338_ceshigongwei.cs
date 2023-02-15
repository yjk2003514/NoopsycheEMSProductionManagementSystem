using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoopsycheEMSProductionManagementSystem.Migrations
{
    public partial class ceshigongwei : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestStation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestStationCoding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestStationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestStation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestStation");
        }
    }
}
