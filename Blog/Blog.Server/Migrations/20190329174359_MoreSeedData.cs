using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Server.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Posted",
                value: new DateTime(2019, 3, 29, 17, 43, 59, 671, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "Post", "Posted", "Title" },
                values: new object[,]
                {
                    { 2, "Joe Cloggs", "2 This is a sample blog post.", new DateTime(2019, 3, 28, 17, 43, 59, 674, DateTimeKind.Local), "Sample Post Title 2" },
                    { 3, "Joe Doggs", "3 This is a sample blog post.", new DateTime(2019, 3, 27, 17, 43, 59, 674, DateTimeKind.Local), "Sample Post Title 3" },
                    { 4, "Joe Eloggs", "4 This is a sample blog post.", new DateTime(2019, 3, 26, 17, 43, 59, 674, DateTimeKind.Local), "Sample Post Title 4" },
                    { 5, "Joe Floggs", "5 This is a sample blog post.", new DateTime(2019, 3, 25, 17, 43, 59, 674, DateTimeKind.Local), "Sample Post Title 5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Posted",
                value: new DateTime(2019, 3, 29, 16, 33, 16, 316, DateTimeKind.Local));
        }
    }
}
