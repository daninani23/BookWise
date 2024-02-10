using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWise.Infrastructure.Migrations
{
    public partial class ChangeReviewTextLenght : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewText",
                table: "Reviews",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin2856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "633e11a9-d441-4324-9756-9644be473702", "AQAAAAEAACcQAAAAEESQjLoy2EV4b44AYe819/2/699BFAmGptRyXnqMF/DycSQQbTD7xF2q0A5VmI7WyQ==", "9b2c45fd-6eb1-46b0-87d4-d5630415cd78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "gs6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fb4b40a-97c6-432d-9303-b3e211741c32", "AQAAAAEAACcQAAAAECrc8H3qGWgTTIRY67u84u+ywVlWuBxKEqeZhirnIW+O3TwDQ6TtmkgNsHgKr/maUw==", "539e0dce-73bf-4b60-91e1-5bb3be706293" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewText",
                table: "Reviews",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin2856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abc011b3-d32a-40f8-8434-0c97ac96f83a", "AQAAAAEAACcQAAAAENpDLs6Ua8Pgp8FsVg6mueum+/d4wXIDxEih0xfAKR7Usr60vT82qm78M/lnQuKXvA==", "ddfc2fdf-92d1-4bbf-9bf1-12ba100d15a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "gs6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e91295e9-2bdc-48d4-b1b1-14060c2aa4c0", "AQAAAAEAACcQAAAAEPOmCskkbjVSNiwi8gMcihQMtk5q79ZeGq/r9hDHQyqw4OX47NJhtbos4NV9Dxfx8Q==", "aac06a45-6d75-4309-b426-8f075b65c1d0" });
        }
    }
}
