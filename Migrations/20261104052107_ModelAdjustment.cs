using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesCh12.Migrations
{
    /// <inheritdoc />
    public partial class ModelAdjustment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentLocations_Loactions_LocationID",
                table: "DepartmentLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loactions",
                table: "Loactions");

            migrationBuilder.RenameTable(
                name: "Loactions",
                newName: "Locations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentLocations_Locations_LocationID",
                table: "DepartmentLocations",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentLocations_Locations_LocationID",
                table: "DepartmentLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Loactions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loactions",
                table: "Loactions",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentLocations_Loactions_LocationID",
                table: "DepartmentLocations",
                column: "LocationID",
                principalTable: "Loactions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
