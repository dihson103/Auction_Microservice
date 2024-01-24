using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionItems.API.Migrations
{
    /// <inheritdoc />
    public partial class AuctionItemsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuctionItems",
                columns: table => new
                {
                    AuctionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinnerUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinAmountIncrease = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KindOfCar = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LicenseType = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionItems", x => x.AuctionId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuctionItems");
        }
    }
}
