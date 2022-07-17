using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Module4HW4.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teapots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Material = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Warranty = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<double>(type: "float", nullable: false),
                    ProducingCountry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teapots", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teapots",
                columns: new[] { "Id", "Capacity", "Color", "Manufacturer", "Material", "Power", "Price", "ProducingCountry", "Quantity", "Title", "Warranty" },
                values: new object[] { 1, 2.2999999999999998, "Black", "Xiaomi", "Plastic + Metal", 2400, 2199.0, "China", 10, "Teapot 1", 12 });

            migrationBuilder.InsertData(
                table: "Teapots",
                columns: new[] { "Id", "Capacity", "Color", "Manufacturer", "Material", "Power", "Price", "ProducingCountry", "Quantity", "Title", "Warranty" },
                values: new object[] { 2, 1.5, "Green", "Xiaomi", "Plastic", 1800, 1899.0, "China", 5, "Teapot 2", 18 });

            migrationBuilder.InsertData(
                table: "Teapots",
                columns: new[] { "Id", "Capacity", "Color", "Manufacturer", "Material", "Power", "Price", "ProducingCountry", "Quantity", "Title", "Warranty" },
                values: new object[] { 3, 1.8, "White", "Tefal", "Plastic + Metal", 2400, 2199.0, "China", 6, "Teapot 3", 24 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teapots");
        }
    }
}
