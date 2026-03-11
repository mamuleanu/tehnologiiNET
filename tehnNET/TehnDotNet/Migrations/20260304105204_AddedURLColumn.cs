using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TehnDotNet.Migrations
{
    /// <inheritdoc />
    public partial class AddedURLColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Books",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Books");
        }
    }
}
