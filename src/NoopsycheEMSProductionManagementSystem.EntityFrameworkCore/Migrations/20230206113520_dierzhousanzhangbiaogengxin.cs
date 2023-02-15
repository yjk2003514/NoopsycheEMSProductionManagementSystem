using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoopsycheEMSProductionManagementSystem.Migrations
{
    public partial class dierzhousanzhangbiaogengxin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectricalMachineryTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectricalMachineryTableRobotnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricalMachineryTableJobNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricalMachineryTableAxle = table.Column<int>(type: "int", nullable: false),
                    ElectricalMachineryTableNumModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricalMachineryTableScanTheBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricalMachineryTableDescribe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricalMachineryTableMaterialCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricalMachineryTableMaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricalMachineryTableSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricalMachineryTableAssembler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricalMachineryTableDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricalMachineryTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GearCaseTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GearCaseTableRobotnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableJobNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableAxle = table.Column<int>(type: "int", nullable: false),
                    GearCaseTableNumModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableScanTheBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableDescribe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableMaterialCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableMaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableWorker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GearCaseTableFillingStandard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableActualValueOfOilInjection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableDeviationValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GearCaseTableUploadResults = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearCaseTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KeyComponentsAndTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyComponentsAndTableRobotnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyComponentsAndTableNonStandardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyComponentsAndTableScanTheBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyComponentsAndTableJobNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyComponentsAndTableAxle = table.Column<int>(type: "int", nullable: false),
                    KeyComponentsAndTableNumModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyComponentsAndTableNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyComponentsAndTableDescribe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyComponentsAndTableMaterialCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyComponentsAndTableMaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyComponentsAndTableAssembler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyComponentsAndTableDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyComponentsAndTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectricalMachineryTable");

            migrationBuilder.DropTable(
                name: "GearCaseTable");

            migrationBuilder.DropTable(
                name: "KeyComponentsAndTable");
        }
    }
}
