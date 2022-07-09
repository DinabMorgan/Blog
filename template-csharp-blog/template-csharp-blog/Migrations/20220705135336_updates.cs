using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_blog.Migrations
{
    public partial class updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catagories_Catagories_CatagoryId",
                table: "Catagories");

            migrationBuilder.DropForeignKey(
                name: "FK_Catagories_Posts_PostId",
                table: "Catagories");

            migrationBuilder.DropIndex(
                name: "IX_Catagories_CatagoryId",
                table: "Catagories");

            migrationBuilder.DropIndex(
                name: "IX_Catagories_PostId",
                table: "Catagories");

            migrationBuilder.DropColumn(
                name: "CatagoryId",
                table: "Catagories");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Catagories");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Posts",
                newName: "Thoughts");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CatagoryId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsRewatchable",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PlatformId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Action");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Comedy");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "RomCom");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Drama");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "SciFi");

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Fantasy" },
                    { 7, "Animation" },
                    { 8, "Kids" },
                    { 9, "Mystical" },
                    { 10, "Reality" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Cost", "Name" },
                values: new object[,]
                {
                    { 1, 15.99, "Netflix" },
                    { 2, 10.99, "Hulu" },
                    { 3, 5.9900000000000002, "AppleTV" },
                    { 4, 5.9900000000000002, "Disney+" },
                    { 5, 2.9900000000000002, "Noggin" },
                    { 6, 8.9900000000000002, "Prime" },
                    { 7, 12.99, "HBOMax" },
                    { 8, 44.990000000000002, "Cable" },
                    { 9, 0.0, "CW" },
                    { 10, 5.9900000000000002, "Paramount+" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "CatagoryId", "DateTime", "IsRewatchable", "PlatformId", "Rating", "Thoughts", "Title" },
                values: new object[] { "Dina", 1, new DateTime(2022, 7, 5, 9, 53, 35, 721, DateTimeKind.Local).AddTicks(765), true, 4, 8, "Gripping", "MoonKnight" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "CatagoryId", "DateTime", "IsRewatchable", "PlatformId", "Rating", "Thoughts", "Title" },
                values: new object[,]
                {
                    { 2, "Dina", 2, new DateTime(2022, 7, 5, 9, 53, 35, 721, DateTimeKind.Local).AddTicks(822), true, 1, 10, "Well Wishes and Warmest Regards", "Schitt's Creek" },
                    { 3, "Dina", 5, new DateTime(2022, 7, 5, 9, 53, 35, 721, DateTimeKind.Local).AddTicks(828), true, 10, 10, "", "Star Trek" },
                    { 4, "Dina", 7, new DateTime(2022, 7, 5, 9, 53, 35, 721, DateTimeKind.Local).AddTicks(833), true, 1, 10, "By the power of Greyskull", "She-Ra" },
                    { 5, "Dina", 4, new DateTime(2022, 7, 5, 9, 53, 35, 721, DateTimeKind.Local).AddTicks(836), false, 8, 2, "Very Repeatative ", "NCIS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CatagoryId",
                table: "Posts",
                column: "CatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PlatformId",
                table: "Posts",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Catagories_CatagoryId",
                table: "Posts",
                column: "CatagoryId",
                principalTable: "Catagories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Platforms_PlatformId",
                table: "Posts",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Catagories_CatagoryId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Platforms_PlatformId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CatagoryId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PlatformId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CatagoryId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsRewatchable",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PlatformId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "Thoughts",
                table: "Posts",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "CatagoryId",
                table: "Catagories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Catagories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Travel");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Food");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Pets");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Hobbies");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Family");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "Name", "Title" },
                values: new object[] { new DateTime(2022, 6, 28, 11, 28, 43, 537, DateTimeKind.Local).AddTicks(3798), "Dina", "The high pitch scream" });

            migrationBuilder.CreateIndex(
                name: "IX_Catagories_CatagoryId",
                table: "Catagories",
                column: "CatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Catagories_PostId",
                table: "Catagories",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catagories_Catagories_CatagoryId",
                table: "Catagories",
                column: "CatagoryId",
                principalTable: "Catagories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Catagories_Posts_PostId",
                table: "Catagories",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }
    }
}
