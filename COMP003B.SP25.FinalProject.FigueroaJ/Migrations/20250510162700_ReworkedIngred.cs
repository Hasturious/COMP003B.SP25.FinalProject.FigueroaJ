using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.SP25.FinalProject.FigueroaJ.Migrations
{
    /// <inheritdoc />
    public partial class ReworkedIngred : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diet",
                table: "Ingredients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Diet",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
