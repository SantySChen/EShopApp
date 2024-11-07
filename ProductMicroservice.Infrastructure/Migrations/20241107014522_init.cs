using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductMicroservice.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent_Category_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category_Variations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_CategoryId = table.Column<int>(type: "int", nullable: false),
                    Variation_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_Variations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Variations_Product_Categories_Product_CategoryId",
                        column: x => x.Product_CategoryId,
                        principalTable: "Product_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_CategoryId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    Product_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Product_Categories_Product_CategoryId",
                        column: x => x.Product_CategoryId,
                        principalTable: "Product_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Variation_Values",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_VariationId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variation_Values", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variation_Values_Category_Variations_Category_VariationId",
                        column: x => x.Category_VariationId,
                        principalTable: "Category_Variations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_Variation_Values",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false),
                    Variation_Value_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Variation_Values", x => new { x.Product_Id, x.Variation_Value_Id });
                    table.ForeignKey(
                        name: "FK_Product_Variation_Values_Products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Variation_Values_Variation_Values_Variation_Value_Id",
                        column: x => x.Variation_Value_Id,
                        principalTable: "Variation_Values",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_Variations_Product_CategoryId",
                table: "Category_Variations",
                column: "Product_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Variation_Values_Variation_Value_Id",
                table: "Product_Variation_Values",
                column: "Variation_Value_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Product_CategoryId",
                table: "Products",
                column: "Product_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Variation_Values_Category_VariationId",
                table: "Variation_Values",
                column: "Category_VariationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product_Variation_Values");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Variation_Values");

            migrationBuilder.DropTable(
                name: "Category_Variations");

            migrationBuilder.DropTable(
                name: "Product_Categories");
        }
    }
}
