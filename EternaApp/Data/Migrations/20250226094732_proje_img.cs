using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class proje_img : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProjectImages_ProjectId",
                table: "ProjectImages");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImages_ProjectId",
                table: "ProjectImages",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProjectImages_ProjectId",
                table: "ProjectImages");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImages_ProjectId",
                table: "ProjectImages",
                column: "ProjectId",
                unique: true);
        }
    }
}
