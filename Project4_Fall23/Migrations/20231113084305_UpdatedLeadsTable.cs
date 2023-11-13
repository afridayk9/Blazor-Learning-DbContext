using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project4_Fall23.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedLeadsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QueryRan",
                table: "Leads",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QueryRan",
                table: "Leads");
        }
    }
}
