using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Server.Migrations
{
    public partial class TestingsecretconnectionString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Posted",
                value: new DateTime(2019, 4, 1, 11, 47, 14, 518, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Posted",
                value: new DateTime(2019, 3, 31, 11, 47, 14, 520, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Posted",
                value: new DateTime(2019, 3, 30, 11, 47, 14, 520, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Posted",
                value: new DateTime(2019, 3, 29, 11, 47, 14, 520, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Posted",
                value: new DateTime(2019, 3, 28, 11, 47, 14, 520, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Posted",
                value: new DateTime(2019, 3, 29, 17, 43, 59, 671, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Posted",
                value: new DateTime(2019, 3, 28, 17, 43, 59, 674, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Posted",
                value: new DateTime(2019, 3, 27, 17, 43, 59, 674, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Posted",
                value: new DateTime(2019, 3, 26, 17, 43, 59, 674, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Posted",
                value: new DateTime(2019, 3, 25, 17, 43, 59, 674, DateTimeKind.Local));
        }
    }
}
