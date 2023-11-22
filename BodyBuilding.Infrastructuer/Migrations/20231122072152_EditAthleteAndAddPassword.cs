using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BodyBuilding.Infrastructuer.Migrations
{
    /// <inheritdoc />
    public partial class EditAthleteAndAddPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Athletes");
        }
    }
}
