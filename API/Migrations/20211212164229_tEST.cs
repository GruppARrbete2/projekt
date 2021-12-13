using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class tEST : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorID",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "DoorID", "Access", "Code", "DörrBenämning", "Explanation", "LocationID", "TenantID", "Time" },
                values: new object[] { 1, false, null, "Tvätt", "Dörr mot tvättstuga", null, null, null });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "DoorID", "Access", "Code", "DörrBenämning", "Explanation", "LocationID", "TenantID", "Time" },
                values: new object[] { 2, false, null, "LGH", "Dörr till lägenhet", null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorID",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "DoorID", "Access", "Code", "DörrBenämning", "Explanation", "LocationID", "TenantID", "Time" },
                values: new object[] { -2, false, null, "LGH", "Dörr till lägenhet", null, null, null });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "DoorID", "Access", "Code", "DörrBenämning", "Explanation", "LocationID", "TenantID", "Time" },
                values: new object[] { -1, false, null, "Tvätt", "Dörr mot tvättstuga", null, null, null });
        }
    }
}
