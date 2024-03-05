using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWise.Infrastructure.Migrations
{
    public partial class AddIdentityRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18f9c453-81b1-431d-bab3-58a84210770d", "8ef8ac77-65b7-4ae3-bae4-69323df49315", "User", null },
                    { "d95205f9-cdcb-42f9-a506-2dd11a84ba47", "39301a07-7e23-492e-be13-469be7fbc7a1", "Administrator", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin2856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a194bb4-b5e3-46e2-be96-b65bb8d21250", "AQAAAAEAACcQAAAAEAF+y114FuOLWgZT4g4FIoZWI8VqtwNjhHz2u9xO1nflAE4RQyr3T4IK7l38rwolQQ==", "b76327d3-ab3c-4cd4-9f49-b563b00028e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "gs6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4125c04-d464-4bc0-85bc-d9d1f809b8fd", "AQAAAAEAACcQAAAAEP2dbZv9NZvH9sZ4CMUGtq0uqRwKN59i78xzjvdG6//6sHapm6Q8AN+Io2CbVjMnvQ==", "83461274-c9b0-4ec0-98d5-18d536f620f0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18f9c453-81b1-431d-bab3-58a84210770d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d95205f9-cdcb-42f9-a506-2dd11a84ba47");

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
    }
}
