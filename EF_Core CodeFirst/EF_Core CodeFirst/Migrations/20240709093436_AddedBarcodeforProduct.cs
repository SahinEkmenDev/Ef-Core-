using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddedBarcodeforProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "barcode",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "barcode",
                table: "Products");
        }
    }
}
