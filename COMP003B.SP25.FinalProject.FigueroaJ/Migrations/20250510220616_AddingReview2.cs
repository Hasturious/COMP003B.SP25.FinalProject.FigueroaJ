using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.SP25.FinalProject.FigueroaJ.Migrations
{
    /// <inheritdoc />
    public partial class AddingReview2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reccoment",
                table: "Reviews",
                newName: "Reccomend");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reccomend",
                table: "Reviews",
                newName: "Reccoment");
        }
    }
}
