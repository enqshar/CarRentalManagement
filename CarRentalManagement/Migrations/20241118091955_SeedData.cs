using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(4813), new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5122), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5123), new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5123), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5210), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5211), new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5212), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5213), new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5213), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5214), new DateTime(2024, 11, 18, 17, 19, 54, 648, DateTimeKind.Local).AddTicks(5215), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(7808), new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(7825), new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(7989), new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(7989), "BMW", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(7991), new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(7991), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 5, "System", new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(8084), new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(8084), "i4", "System" },
                    { 6, "System", new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(8086), new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(8086), "X5", "System" },
                    { 7, "System", new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(8087), new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(8088), "Prius", "System" },
                    { 8, "System", new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(8089), new DateTime(2024, 11, 18, 17, 11, 37, 899, DateTimeKind.Local).AddTicks(8090), "C-HR", "System" }
                });
        }
    }
}
