using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoopsycheEMSProductionManagementSystem.Migrations
{
    public partial class disanzhoubiaoyi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestOneTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestOneTableNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestOneTableJobNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestOneTableModelNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestOneTableZero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestOneTableLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestOneTableA1Axlea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestOneTableA2Axleb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestOneTableA3Axlec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestOneTableA4Axld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestOneTableA5Axlee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestOneTableA6Axlef = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestOneTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestTwoTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestTwoTableNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestTwoTableModelNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestTwoTableInsulationInspection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestTwoTableJobNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestTwoTableDebugging = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestTwoTableRunningin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestTwoTableMaterialCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestTwoTableMaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestTwoTableAxle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestTwoTableTheoreticalQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestTwoTableRealQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTwoTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestOneTable");

            migrationBuilder.DropTable(
                name: "TestTwoTable");
        }
    }
}
