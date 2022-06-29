using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_blog.Migrations
{
    public partial class te : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatagoryId = table.Column<int>(type: "int", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Catagories_Catagories_CatagoryId",
                        column: x => x.CatagoryId,
                        principalTable: "Catagories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Catagories_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "Id", "CatagoryId", "Name", "PostId" },
                values: new object[,]
                {
                    { 1, null, "Travel", null },
                    { 2, null, "Food", null },
                    { 3, null, "Pets", null },
                    { 4, null, "Hobbies", null },
                    { 5, null, "Family", null }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "DateTime", "Name", "Title" },
                values: new object[] { 1, new DateTime(2022, 6, 28, 11, 28, 43, 537, DateTimeKind.Local).AddTicks(3798), "Dina", "The high pitch scream" });

            migrationBuilder.CreateIndex(
                name: "IX_Catagories_CatagoryId",
                table: "Catagories",
                column: "CatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Catagories_PostId",
                table: "Catagories",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catagories");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
