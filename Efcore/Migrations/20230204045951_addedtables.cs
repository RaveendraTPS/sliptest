using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Efcore.Migrations
{
    /// <inheritdoc />
    public partial class addedtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PKRoleId",
                table: "Role",
                newName: "PKJobId");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    PKDepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.PKDepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    PkLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    country = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    state = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    pincode = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.PkLocationID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.RenameColumn(
                name: "PKJobId",
                table: "Role",
                newName: "PKRoleId");
        }
    }
}
