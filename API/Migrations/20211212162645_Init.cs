using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    DörrBenämning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantID = table.Column<int>(type: "int", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Access = table.Column<bool>(type: "bit", nullable: false),
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
                columns: new[] { "DoorID", "Access", "Code", "DörrBenämning", "Explanation", "LocationID", "TenantID", "Time" },
                values: new object[,]
                {
                    { -2, false, null, "LGH", "Dörr till lägenhet", null, null, null },
                    { -1, false, null, "Tvätt", "Dörr mot tvättstuga", null, null, null }
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
                name: "Tenants");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
