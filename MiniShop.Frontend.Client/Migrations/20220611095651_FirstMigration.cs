using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniShop.Frontend.Client.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopId = table.Column<Guid>(nullable: false),
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    ParentCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopId = table.Column<Guid>(nullable: false),
                    CategorieId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    PurchasePrice = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    PriceType = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    Picture = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysParm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopId = table.Column<Guid>(nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysParm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopId = table.Column<Guid>(nullable: false),
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "SysParm");

            migrationBuilder.DropTable(
                name: "Unit");
        }
    }
}
