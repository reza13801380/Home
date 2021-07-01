using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.Migrations
{
    public partial class ChangingCartinfoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartInfo_User_UserId",
                table: "CartInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartInfo",
                table: "CartInfo");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "CartInfo");

            migrationBuilder.RenameTable(
                name: "CartInfo",
                newName: "CartInfos");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "User",
                newName: "Phone");

            migrationBuilder.RenameIndex(
                name: "IX_CartInfo_UserId",
                table: "CartInfos",
                newName: "IX_CartInfos_UserId");

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "gender",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Balance",
                table: "CartInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Deposit",
                table: "CartInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpireDateMonth",
                table: "CartInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpireDateYear",
                table: "CartInfos",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartInfos",
                table: "CartInfos",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartInfos_User_UserId",
                table: "CartInfos",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartInfos_User_UserId",
                table: "CartInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartInfos",
                table: "CartInfos");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "User");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "CartInfos");

            migrationBuilder.DropColumn(
                name: "Deposit",
                table: "CartInfos");

            migrationBuilder.DropColumn(
                name: "ExpireDateMonth",
                table: "CartInfos");

            migrationBuilder.DropColumn(
                name: "ExpireDateYear",
                table: "CartInfos");

            migrationBuilder.RenameTable(
                name: "CartInfos",
                newName: "CartInfo");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "User",
                newName: "phone");

            migrationBuilder.RenameIndex(
                name: "IX_CartInfos_UserId",
                table: "CartInfo",
                newName: "IX_CartInfo_UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "CartInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartInfo",
                table: "CartInfo",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartInfo_User_UserId",
                table: "CartInfo",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
