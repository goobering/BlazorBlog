using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Server.Migrations
{
    public partial class AddedImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "BlogPosts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Posted" },
                values: new object[] { "~/img/broken-egg.jpg", new DateTime(2019, 4, 3, 15, 48, 23, 254, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "Posted" },
                values: new object[] { "~/img/chalk.jpg", new DateTime(2019, 4, 2, 15, 48, 23, 256, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Posted" },
                values: new object[] { "~/img/glass.jpg", new DateTime(2019, 4, 1, 15, 48, 23, 256, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Posted" },
                values: new object[] { "~/img/hammer.jpg", new DateTime(2019, 3, 31, 15, 48, 23, 256, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Posted" },
                values: new object[] { "~/img/robot.jpg", new DateTime(2019, 3, 30, 15, 48, 23, 256, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "BlogPosts");

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
    }
}
