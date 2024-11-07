using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PromotionsMicroservice.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promotion_Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotion_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Promotion_SaleId = table.Column<int>(type: "int", nullable: false),
                    Product_Category_Id = table.Column<int>(type: "int", nullable: false),
                    Product_Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promotion_Details_Promotion_Sales_Promotion_SaleId",
                        column: x => x.Promotion_SaleId,
                        principalTable: "Promotion_Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promotion_Details_Promotion_SaleId",
                table: "Promotion_Details",
                column: "Promotion_SaleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Promotion_Details");

            migrationBuilder.DropTable(
                name: "Promotion_Sales");
        }
    }
}
