using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.Migrations
{
    public partial class Model2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "financialTransactions",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "finances",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_financialTransactions_UserId",
                table: "financialTransactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_finances_UserId",
                table: "finances",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_finances_User_UserId",
                table: "finances",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_financialTransactions_User_UserId",
                table: "financialTransactions",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_finances_User_UserId",
                table: "finances");

            migrationBuilder.DropForeignKey(
                name: "FK_financialTransactions_User_UserId",
                table: "financialTransactions");

            migrationBuilder.DropIndex(
                name: "IX_financialTransactions_UserId",
                table: "financialTransactions");

            migrationBuilder.DropIndex(
                name: "IX_finances_UserId",
                table: "finances");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "financialTransactions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "finances");
        }
    }
}
