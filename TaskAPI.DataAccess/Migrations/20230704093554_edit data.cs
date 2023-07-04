using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class editdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "AuthorId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 7, 4, 15, 5, 54, 691, DateTimeKind.Local).AddTicks(3062), new DateTime(2023, 7, 9, 15, 5, 54, 691, DateTimeKind.Local).AddTicks(3063) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 14, 2, 34, 575, DateTimeKind.Local).AddTicks(8063), new DateTime(2023, 7, 9, 14, 2, 34, 575, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2023, 7, 4, 14, 2, 34, 575, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 7, 9, 14, 2, 34, 575, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 14, 2, 34, 575, DateTimeKind.Local).AddTicks(8105), new DateTime(2023, 7, 9, 14, 2, 34, 575, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 14, 2, 34, 575, DateTimeKind.Local).AddTicks(8107), new DateTime(2023, 7, 9, 14, 2, 34, 575, DateTimeKind.Local).AddTicks(8108) });
        }
    }
}
