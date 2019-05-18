using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations.FirstLibrary
{
    public partial class addbook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Title" },
                values: new object[] { new Guid("b909fb4f-7122-4dc3-b0aa-96b2ee24d401"), new Guid("f49a617d-da70-4266-aad4-3e1f4daedcf1"), "My First Book" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b909fb4f-7122-4dc3-b0aa-96b2ee24d401"));
        }
    }
}
