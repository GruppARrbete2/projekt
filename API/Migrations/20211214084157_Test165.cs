using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Test165 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Output",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<TimeSpan>(type: "time", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeExplation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DörrBenämning = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Output", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Output",
                columns: new[] { "ID", "Code", "CodeExplation", "DörrBenämning", "Person", "Tag", "Time" },
                values: new object[] { 1, "DÖIN", "Öppnade dörr till lägenhet 0301 inifrån", "TVÄTT", "Ella Ahlström", "0301A", new TimeSpan(349170414754) });

            migrationBuilder.InsertData(
                table: "Output",
                columns: new[] { "ID", "Code", "CodeExplation", "DörrBenämning", "Person", "Tag", "Time" },
                values: new object[] { 2, "DÖUT", "Öppnade dörr till lägenhet 0301 utifrån", "TVÄTT", "Ella Ahlström", "0301A", new TimeSpan(349170414819) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Output");
        }
    }
}
