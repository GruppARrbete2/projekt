using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Tenants",
                columns: table => new
                {
                    TenantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apartment = table.Column<int>(type: "int", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.TenantID);
                });

            migrationBuilder.InsertData(
                table: "Outputs",
                columns: new[] { "ID", "Code", "DörrBenämning", "Person", "Tag", "Time" },
                values: new object[,]
                {
                    { 1, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826772L },
                    { 2, "DÖUT", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826939L },
                    { 3, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754363807826942L },
                    { 4, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754363807826944L },
                    { 5, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754363807826947L },
                    { 6, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754363807826949L },
                    { 7, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754363807826951L },
                    { 8, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754363807826953L },
                    { 9, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754363807826955L },
                    { 10, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754363807826957L },
                    { 11, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826958L },
                    { 12, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826960L },
                    { 13, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826962L },
                    { 14, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826963L },
                    { 15, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826965L },
                    { 16, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826969L },
                    { 17, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826971L },
                    { 18, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826973L },
                    { 19, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826974L },
                    { 20, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826976L },
                    { 21, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826978L },
                    { 22, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754363807826979L }
                });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "TenantID", "Apartment", "Namne", "Tag" },
                values: new object[,]
                {
                    { 1, 1001, "Göran Svensson", "1001A" },
                    { 2, 1002, "Göran Andersson", "1002A" },
                    { 3, 1002, "Jonas Andersson", "1002B" },
                    { 4, 1001, "Stefan Andersson", "1002B" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Outputs");

            migrationBuilder.DropTable(
                name: "Tenants");
        }
    }
}
