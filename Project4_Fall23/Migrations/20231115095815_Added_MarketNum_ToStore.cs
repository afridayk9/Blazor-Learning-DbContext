using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project4_Fall23.Migrations
{
    /// <inheritdoc />
    public partial class Added_MarketNum_ToStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MarketNumber",
                table: "Store",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarketNumber",
                table: "Store");
        }
    }
}
