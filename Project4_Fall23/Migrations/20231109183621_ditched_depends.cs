using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project4_Fall23.Migrations
{
    /// <inheritdoc />
    public partial class ditched_depends : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Market_PointOfContact_PocId",
                table: "Market");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_Market_MarketNumber",
                table: "Store");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_PointOfContact_PocId",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Store_MarketNumber",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Store_PocId",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Market_PocId",
                table: "Market");

            migrationBuilder.DropColumn(
                name: "MarketNumber",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "PocId",
                table: "Store");

            migrationBuilder.RenameColumn(
                name: "PocId",
                table: "Market",
                newName: "Stores");

            migrationBuilder.AddColumn<string>(
                name: "Poc",
                table: "Store",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Poc",
                table: "Market",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Poc",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "Poc",
                table: "Market");

            migrationBuilder.RenameColumn(
                name: "Stores",
                table: "Market",
                newName: "PocId");

            migrationBuilder.AddColumn<int>(
                name: "MarketNumber",
                table: "Store",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PocId",
                table: "Store",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Store_MarketNumber",
                table: "Store",
                column: "MarketNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Store_PocId",
                table: "Store",
                column: "PocId");

            migrationBuilder.CreateIndex(
                name: "IX_Market_PocId",
                table: "Market",
                column: "PocId");

            migrationBuilder.AddForeignKey(
                name: "FK_Market_PointOfContact_PocId",
                table: "Market",
                column: "PocId",
                principalTable: "PointOfContact",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Store_Market_MarketNumber",
                table: "Store",
                column: "MarketNumber",
                principalTable: "Market",
                principalColumn: "MarketNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Store_PointOfContact_PocId",
                table: "Store",
                column: "PocId",
                principalTable: "PointOfContact",
                principalColumn: "Id");
        }
    }
}
