using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "be814e1a-0076-4e01-aa8c-c8c857a44f4d", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBfeCf7/523ZhYDI/0MlGRZDMpdnU3nTFvWEf+haU3PVSD0udE2oSI0VAouy9y5GHg==", null, false, "033b0e6a-150d-4c74-bb2e-137134a3dff5", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9465), new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9610), new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9612), new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9676), new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9678), new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9680), new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9681), new DateTime(2024, 11, 18, 17, 55, 20, 754, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6745), new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6877), new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6879), new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6944), new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6946), new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6947), new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6949), new DateTime(2024, 11, 18, 17, 41, 35, 974, DateTimeKind.Local).AddTicks(6949) });
        }
    }
}
