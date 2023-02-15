using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoopsycheEMSProductionManagementSystem.Migrations
{
    public partial class xinzengwuliaopeizhi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaterialAllocationTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialAllocationTableDescribe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialAllocationTableCoding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialAllocationTableTab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialAllocationTableAxle = table.Column<int>(type: "int", nullable: false),
                    MaterialAllocationTableStandard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialAllocationTableDeviation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialAllocationTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialAllocationTable");
        }
    }
}
