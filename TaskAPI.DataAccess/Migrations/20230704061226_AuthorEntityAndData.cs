using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorEntityAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Sankha" },
                    { 2, "Yapa" },
                    { 3, "Priyamantha" },
                    { 4, "Bandara" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedDate", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2023, 7, 4, 11, 42, 26, 294, DateTimeKind.Local).AddTicks(4376), new DateTime(2023, 7, 9, 11, 42, 26, 294, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "Description", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2023, 7, 4, 11, 42, 26, 294, DateTimeKind.Local).AddTicks(4426), "Get some text books for school", 0, "Get books for school form DB", new DateTime(2023, 7, 9, 11, 42, 26, 294, DateTimeKind.Local).AddTicks(4428) },
                    { 3, 3, new DateTime(2023, 7, 4, 11, 42, 26, 294, DateTimeKind.Local).AddTicks(4430), "Get some text books for school", 0, "Get books for school form DB", new DateTime(2023, 7, 9, 11, 42, 26, 294, DateTimeKind.Local).AddTicks(4431) },
                    { 4, 4, new DateTime(2023, 7, 4, 11, 42, 26, 294, DateTimeKind.Local).AddTicks(4432), "Get some text books for school", 0, "Get books for school form DB", new DateTime(2023, 7, 9, 11, 42, 26, 294, DateTimeKind.Local).AddTicks(4433) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Author_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Author_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 4, 10, 52, 49, 752, DateTimeKind.Local).AddTicks(7360), new DateTime(2023, 7, 9, 10, 52, 49, 752, DateTimeKind.Local).AddTicks(7370) });
        }
    }
}
