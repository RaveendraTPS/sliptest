using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efcore.Migrations
{
    /// <inheritdoc />
    public partial class addedisactive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Location",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Departments");
        }
    }
}
