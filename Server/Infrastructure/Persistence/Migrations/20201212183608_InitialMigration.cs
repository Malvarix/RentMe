using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bikes",
                columns: new[] { "Id", "Price", "Status", "Title", "Type" },
                values: new object[] { 1, 20.99m, 0, "Giant Contend AR 2 2020", 0 });

            migrationBuilder.InsertData(
                table: "Bikes",
                columns: new[] { "Id", "Price", "Status", "Title", "Type" },
                values: new object[] { 2, 18.99m, 0, "Cyclone MMXX 29 2020", 1 });

            migrationBuilder.InsertData(
                table: "Bikes",
                columns: new[] { "Id", "Price", "Status", "Title", "Type" },
                values: new object[] { 3, 15.99m, 0, "Trek Domane AL 3 2019", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bikes");
        }
    }
}
