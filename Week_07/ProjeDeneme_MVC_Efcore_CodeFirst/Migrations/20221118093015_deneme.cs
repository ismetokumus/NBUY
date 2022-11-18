using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjeDeneme_MVC_Efcore_CodeFirst.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Ipone 13" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Dell Xside" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Samsung A71" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Piranha X13" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "ProductId" },
                values: new object[] { 1, "Rize", 1 });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "ProductId" },
                values: new object[] { 2, "Kars", 2 });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "ProductId" },
                values: new object[] { 3, "Samsun", 3 });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "ProductId" },
                values: new object[] { 4, "İstanbul", 4 });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "ProductId" },
                values: new object[] { 5, "Ankara", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_City_ProductId",
                table: "City",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
