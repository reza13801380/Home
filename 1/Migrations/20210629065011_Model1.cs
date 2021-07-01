using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.Migrations
{
    public partial class Model1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "finances",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    assetclassification = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    CartID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_finances", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "financialTransactions",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    transaction_Classification = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    CartID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_financialTransactions", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "finances");

            migrationBuilder.DropTable(
                name: "financialTransactions");
        }
    }
}
