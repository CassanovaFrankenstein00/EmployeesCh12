using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeesCh12.Migrations
{
    /// <inheritdoc />
    public partial class updateContextAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Benefits",
                columns: new[] { "ID", "Category", "Dental", "Health", "LifeIns", "Vision" },
                values: new object[,]
                {
                    { 1, 0, false, false, 0m, false },
                    { 2, 2, true, true, 100000m, true },
                    { 3, 1, true, true, 100000m, true }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 5, "Management" },
                    { 6, "Plant" },
                    { 7, "Shipping" },
                    { 8, "Warehouse" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "Address", "Type", "Zipcode" },
                values: new object[,]
                {
                    { 1, "2200 Park Ave", 1, "49696" },
                    { 2, "2200 Park Ave", 4, "49696" },
                    { 3, "2200 Park Ave", 0, "49696" },
                    { 4, "2100 Park Ave", 3, "49696" },
                    { 5, "6 Hickory Blvd.", 3, "49696" },
                    { 6, "6 Hickory Blvd.", 2, "49696" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentLocations",
                columns: new[] { "DepartmentID", "LocationID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 4 },
                    { 7, 2 },
                    { 7, 5 },
                    { 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "BenefitsID", "DepartmentID", "FirstName", "HireDate", "LastName" },
                values: new object[,]
                {
                    { 100, 1, 1, "Judy", new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jetson" },
                    { 101, 2, 1, "Daphne", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blake" },
                    { 1012, 1, 1, "Freddie", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flintstone" },
                    { 1067, 1, 2, "Wilma", new DateTime(2005, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flintstone" },
                    { 1098, 2, 3, "Barney", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rubble" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DepartmentLocations",
                keyColumns: new[] { "DepartmentID", "LocationID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentLocations",
                keyColumns: new[] { "DepartmentID", "LocationID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentLocations",
                keyColumns: new[] { "DepartmentID", "LocationID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentLocations",
                keyColumns: new[] { "DepartmentID", "LocationID" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentLocations",
                keyColumns: new[] { "DepartmentID", "LocationID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentLocations",
                keyColumns: new[] { "DepartmentID", "LocationID" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentLocations",
                keyColumns: new[] { "DepartmentID", "LocationID" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentLocations",
                keyColumns: new[] { "DepartmentID", "LocationID" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "DepartmentLocations",
                keyColumns: new[] { "DepartmentID", "LocationID" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
