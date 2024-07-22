using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ispit.Api.Migrations.ShoppingItem
{
    /// <inheritdoc />
    public partial class ShoppingItemDbCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ShoppingItems",
                columns: new[] { "Id", "Manufacturer", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "TechCorp", "Laptop", 999.99m },
                    { 2, "Gizmo Inc.", "Smartphone", 499.99m },
                    { 3, "AudioPro", "Headphones", 89.99m },
                    { 4, "KeyMaster", "Keyboard", 29.99m },
                    { 5, "Clicker", "Mouse", 19.99m },
                    { 6, "VisionTech", "Monitor", 149.99m },
                    { 7, "PrintMaster", "Printer", 79.99m },
                    { 8, "CamCo", "Webcam", 59.99m },
                    { 9, "DataStick", "USB Drive", 12.99m },
                    { 10, "StoragePlus", "External Hard Drive", 129.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingItems");
        }
    }
}
