using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeesCh12.Migrations
{
    /// <inheritdoc />
    public partial class correctModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Departments",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Departments",
                table: "Employees",
                type: "int",
                nullable: true);
        }
    }
}
