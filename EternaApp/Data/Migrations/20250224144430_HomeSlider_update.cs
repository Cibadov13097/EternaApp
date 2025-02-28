using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class HomeSlider_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "HomeSliders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "HomeSliders");
        }
    }
}
