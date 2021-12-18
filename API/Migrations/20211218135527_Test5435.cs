using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Test5435 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Locations_LocationID",
                table: "Tenants");

            migrationBuilder.DropTable(
                name: "Doors");

            migrationBuilder.DropTable(
                name: "DoorsOpened");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_LocationID",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Tenants");

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: 637754361274794554L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: 637754361274794588L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Time",
                value: 637754361274794591L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 4,
                column: "Time",
                value: 637754361274794593L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 5,
                column: "Time",
                value: 637754361274794595L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 6,
                column: "Time",
                value: 637754361274794598L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 7,
                column: "Time",
                value: 637754361274794599L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 8,
                column: "Time",
                value: 637754361274794601L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 9,
                column: "Time",
                value: 637754361274794603L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 10,
                column: "Time",
                value: 637754361274794605L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 11,
                column: "Time",
                value: 637754361274794607L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 12,
                column: "Time",
                value: 637754361274794609L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 13,
                column: "Time",
                value: 637754361274794611L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 14,
                column: "Time",
                value: 637754361274794613L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 15,
                column: "Time",
                value: 637754361274794615L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 16,
                column: "Time",
                value: 637754361274794618L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 17,
                column: "Time",
                value: 637754361274794620L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 18,
                column: "Time",
                value: 637754361274794622L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 19,
                column: "Time",
                value: 637754361274794624L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 20,
                column: "Time",
                value: 637754361274794626L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 21,
                column: "Time",
                value: 637754361274794628L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 22,
                column: "Time",
                value: 637754361274794631L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Tenants",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DoorsOpened",
                columns: table => new
                {
                    DoorOpenedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoorID = table.Column<int>(type: "int", nullable: true),
                    TenantID = table.Column<int>(type: "int", nullable: true),
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

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "DoorID", "DörrBenämning", "Explanation", "LocationID" },
                values: new object[,]
                {
                    { 1, "Tvätt", "Dörr mot tvättstuga", null },
                    { 2, "LGH", "Dörr till lägenhet", null }
                });

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: 637754358879726706L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: 637754358879726742L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Time",
                value: 637754358879726745L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 4,
                column: "Time",
                value: 637754358879726747L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 5,
                column: "Time",
                value: 637754358879726749L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 6,
                column: "Time",
                value: 637754358879726752L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 7,
                column: "Time",
                value: 637754358879726754L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 8,
                column: "Time",
                value: 637754358879726756L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 9,
                column: "Time",
                value: 637754358879726758L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 10,
                column: "Time",
                value: 637754358879726760L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 11,
                column: "Time",
                value: 637754358879726762L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 12,
                column: "Time",
                value: 637754358879726764L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 13,
                column: "Time",
                value: 637754358879726766L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 14,
                column: "Time",
                value: 637754358879726769L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 15,
                column: "Time",
                value: 637754358879726771L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 16,
                column: "Time",
                value: 637754358879726773L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 17,
                column: "Time",
                value: 637754358879726775L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 18,
                column: "Time",
                value: 637754358879726777L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 19,
                column: "Time",
                value: 637754358879726779L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 20,
                column: "Time",
                value: 637754358879726780L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 21,
                column: "Time",
                value: 637754358879726783L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 22,
                column: "Time",
                value: 637754358879726785L);

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_LocationID",
                table: "Tenants",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Doors_LocationID",
                table: "Doors",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Locations_LocationID",
                table: "Tenants",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID");
        }
    }
}
