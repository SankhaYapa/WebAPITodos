using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "CreatedDate", "Description", "Status", "Title", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 7, 4, 10, 52, 49, 752, DateTimeKind.Local).AddTicks(7360), "Get some text books for school", 0, "Get books for school form DB", new DateTime(2023, 7, 9, 10, 52, 49, 752, DateTimeKind.Local).AddTicks(7370) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
