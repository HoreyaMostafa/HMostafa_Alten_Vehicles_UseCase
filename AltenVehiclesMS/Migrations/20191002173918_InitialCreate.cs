using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AltenVehiclesMS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VIN = table.Column<string>(nullable: true),
                    Regnr = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    LastSeen = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "ID", "CustomerId", "CustomerName", "LastSeen", "Regnr", "VIN" },
                values: new object[,]
                {
                    { 1, 1, "", null, "ABC123", " YS2R4X20005399401" },
                    { 2, 1, "Kalles Grustransporter AB", null, "DEF456", "VLUR4X20009093588" },
                    { 3, 1, "Kalles Grustransporter AB", null, "GHI789", "VLUR4X20009048066" },
                    { 4, 2, "Johans Bulk AB ", null, "JKL012", "YS2R4X20005388011" },
                    { 5, 2, "Johans Bulk AB ", null, "MNO345", "YS2R4X20005387949" },
                    { 6, 3, "Haralds Värdetransporter AB", null, "PQR678", "VLUR4X20009048066" },
                    { 7, 3, "Haralds Värdetransporter AB", null, "STU901", "YS2R4X20005387055" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
