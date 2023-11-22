using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BodyBuilding.Infrastructuer.Migrations
{
    /// <inheritdoc />
    public partial class changeAndDeletegender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Athletes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Athletes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
