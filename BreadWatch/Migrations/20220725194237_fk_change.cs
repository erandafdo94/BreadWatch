using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BreadWatch.Migrations
{
    public partial class fk_change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bread_Budgets_AspNetUsers_UserId",
                table: "bread_Budgets");

            migrationBuilder.DropIndex(
                name: "IX_bread_Budgets_UserId",
                table: "bread_Budgets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("057ffd99-3c61-4ac5-8cdf-75d1ba4858e1"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6a5682b4-7e19-4336-824d-f36140b4729d"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "bread_Budgets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("9c9a6064-f6da-4391-b378-cc523f66156a"), "bd597cf8-46a9-4d1f-8219-7dd781e3f03e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("ab715c84-cbe7-4568-936d-51d39f63bf6f"), "c6bd288d-09f9-41a0-a21f-ed1faf9c5fa5", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_bread_Budgets_UserGuid",
                table: "bread_Budgets",
                column: "UserGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_bread_Budgets_AspNetUsers_UserGuid",
                table: "bread_Budgets",
                column: "UserGuid",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bread_Budgets_AspNetUsers_UserGuid",
                table: "bread_Budgets");

            migrationBuilder.DropIndex(
                name: "IX_bread_Budgets_UserGuid",
                table: "bread_Budgets");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9c9a6064-f6da-4391-b378-cc523f66156a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ab715c84-cbe7-4568-936d-51d39f63bf6f"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "bread_Budgets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("057ffd99-3c61-4ac5-8cdf-75d1ba4858e1"), "842c705e-737c-42fd-aeeb-fdebce7f3b6b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("6a5682b4-7e19-4336-824d-f36140b4729d"), "20e8616e-b8e3-469a-84e0-87dfe9aecc7d", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_bread_Budgets_UserId",
                table: "bread_Budgets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_bread_Budgets_AspNetUsers_UserId",
                table: "bread_Budgets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
