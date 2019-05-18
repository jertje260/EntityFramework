using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations.SecondLibrary
{
    public partial class enableSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4e375215-9286-4846-8aab-f6b24b07dd22"), "Author2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4e375215-9286-4846-8aab-f6b24b07dd22"));
        }
    }
}
