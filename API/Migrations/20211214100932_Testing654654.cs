using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Testing654654 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CodeExplation", "Time" },
                values: new object[] { "Öppnade dörr till tvätten 0301 inifrån", new TimeSpan(401717986745) });

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CodeExplation", "Time" },
                values: new object[] { "Öppnade dörr till tvätten 0301 utifrån", new TimeSpan(401717986809) });

            migrationBuilder.InsertData(
                table: "Outputs",
                columns: new[] { "ID", "Code", "CodeExplation", "DörrBenämning", "Person", "Tag", "Time" },
                values: new object[] { 3, "DÖIN", "Öppnade dörr till lägenhet 0301 utifrån", "Lägenhet", "Göran Ahlström", "0302A", new TimeSpan(401717986817) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CodeExplation", "Time" },
                values: new object[] { "Öppnade dörr till lägenhet 0301 inifrån", new TimeSpan(388357458664) });

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CodeExplation", "Time" },
                values: new object[] { "Öppnade dörr till lägenhet 0301 utifrån", new TimeSpan(388357458720) });
        }
    }
}
