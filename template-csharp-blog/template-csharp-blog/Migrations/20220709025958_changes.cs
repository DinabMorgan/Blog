using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_blog.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thoughts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRewatchable = table.Column<bool>(type: "bit", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Comedy" },
                    { 3, "RomCom" },
                    { 4, "Drama" },
                    { 5, "SciFi" },
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

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "CategoryId", "DateTime", "IsRewatchable", "PlatformId", "Rating", "Thoughts", "Title" },
                values: new object[,]
                {
                    { 1, "Dina", 1, new DateTime(2022, 7, 8, 22, 59, 58, 1, DateTimeKind.Local).AddTicks(4007), true, 4, 8, "Gripping", "MoonKnight" },
                    { 2, "Dina", 2, new DateTime(2022, 7, 8, 22, 59, 58, 1, DateTimeKind.Local).AddTicks(4046), true, 1, 10, "Well Wishes and Warmest Regards", "Schitt's Creek" },
                    { 3, "Dina", 5, new DateTime(2022, 7, 8, 22, 59, 58, 1, DateTimeKind.Local).AddTicks(4049), true, 10, 10, "", "Star Trek" },
                    { 4, "Dina", 7, new DateTime(2022, 7, 8, 22, 59, 58, 1, DateTimeKind.Local).AddTicks(4052), true, 1, 10, "By the power of Greyskull", "She-Ra" },
                    { 5, "Dina", 4, new DateTime(2022, 7, 8, 22, 59, 58, 1, DateTimeKind.Local).AddTicks(4053), false, 8, 2, "Very Repeatative ", "NCIS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PlatformId",
                table: "Posts",
                column: "PlatformId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
