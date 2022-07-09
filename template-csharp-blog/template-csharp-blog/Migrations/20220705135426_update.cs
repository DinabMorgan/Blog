using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_blog.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 5, 9, 54, 25, 624, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 5, 9, 54, 25, 624, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 7, 5, 9, 54, 25, 624, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2022, 7, 5, 9, 54, 25, 624, DateTimeKind.Local).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2022, 7, 5, 9, 54, 25, 624, DateTimeKind.Local).AddTicks(6241));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2022, 7, 5, 9, 53, 35, 721, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2022, 7, 5, 9, 53, 35, 721, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2022, 7, 5, 9, 53, 35, 721, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2022, 7, 5, 9, 53, 35, 721, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2022, 7, 5, 9, 53, 35, 721, DateTimeKind.Local).AddTicks(836));
        }
    }
}
