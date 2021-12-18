using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Testing4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoorsOpened",
                columns: table => new
                {
                    DoorOpenedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantID = table.Column<int>(type: "int", nullable: true),
                    DoorID = table.Column<int>(type: "int", nullable: true),
                    Time = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorsOpened", x => x.DoorOpenedId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Outputs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<long>(type: "bigint", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DörrBenämning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Person = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outputs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Doors",
                columns: table => new
                {
                    DoorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DörrBenämning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doors", x => x.DoorID);
                    table.ForeignKey(
                        name: "FK_Doors_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID");
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    TenantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apartment = table.Column<int>(type: "int", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.TenantID);
                    table.ForeignKey(
                        name: "FK_Tenants_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID");
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "DoorID", "DörrBenämning", "Explanation", "LocationID" },
                values: new object[,]
                {
                    { 1, "Tvätt", "Dörr mot tvättstuga", null },
                    { 2, "LGH", "Dörr till lägenhet", null }
                });

            migrationBuilder.InsertData(
                table: "Outputs",
                columns: new[] { "ID", "Code", "DörrBenämning", "Person", "Tag", "Time" },
                values: new object[,]
                {
                    { 1, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637753529944035947L },
                    { 2, "DÖUT", "TVÄTT", "Ella Ahlström", "0301A", 637753529944035977L },
                    { 3, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637753529944035979L }
                });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "TenantID", "Apartment", "LocationID", "Namne", "Tag" },
                values: new object[,]
                {
                    { 1, 1001, null, "Göran Svensson", "1001A" },
                    { 2, 1002, null, "Göran Andersson", "1002A" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doors_LocationID",
                table: "Doors",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_LocationID",
                table: "Tenants",
                column: "LocationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doors");

            migrationBuilder.DropTable(
                name: "DoorsOpened");

            migrationBuilder.DropTable(
                name: "Outputs");

            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
