using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TehnDotNet.Migrations
{
    /// <inheritdoc />
    public partial class Added_IsDamaged_Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDamaged",
                table: "Books",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDamaged",
                table: "Books");
        }
    }
}
