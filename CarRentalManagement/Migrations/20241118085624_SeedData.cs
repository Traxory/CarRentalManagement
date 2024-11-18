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
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Model",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Model",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Make",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Make",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Colour",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Colour",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(884), new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(894), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(897), new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(898), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1035), new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1035), "Bmw", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1037), new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1037), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1095), new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1095), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1097), new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1097), "x5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1098), new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1099), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 11, 18, 16, 56, 23, 482, DateTimeKind.Local).AddTicks(1100), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Make");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Make");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Colour");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Colour");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Booking");
        }
    }
}
