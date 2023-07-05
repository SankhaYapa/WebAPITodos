using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class JobRoleFieldAddedToAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Author",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "Engineer");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9190), new DateTime(2023, 7, 10, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9208), new DateTime(2023, 7, 10, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9210), new DateTime(2023, 7, 10, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9212), new DateTime(2023, 7, 10, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9213) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Author");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 15, 5, 54, 691, DateTimeKind.Local).AddTicks(3035), new DateTime(2023, 7, 9, 15, 5, 54, 691, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 15, 5, 54, 691, DateTimeKind.Local).AddTicks(3062), new DateTime(2023, 7, 9, 15, 5, 54, 691, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 15, 5, 54, 691, DateTimeKind.Local).AddTicks(3065), new DateTime(2023, 7, 9, 15, 5, 54, 691, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 15, 5, 54, 691, DateTimeKind.Local).AddTicks(3068), new DateTime(2023, 7, 9, 15, 5, 54, 691, DateTimeKind.Local).AddTicks(3069) });
        }
    }
}
