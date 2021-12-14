using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class _1423 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Output",
                table: "Output");

            migrationBuilder.RenameTable(
                name: "Output",
                newName: "Outputs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Outputs",
                table: "Outputs",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(387105860504));

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(387105860579));

            migrationBuilder.InsertData(
                table: "Outputs",
                columns: new[] { "ID", "Code", "CodeExplation", "DörrBenämning", "Person", "Tag", "Time" },
                values: new object[,]
                {
                    { 3, "DÖIN", "Öppnade dörr till lägenhet 0301 inifrån", "ut", "Göran Andresson", "0302A", new TimeSpan(387105860590) },
                    { 4, "DÖUT", "Öppnade dörr till lägenhet 0301 utifrån", "ut", "Ella Ahlström", "0302A", new TimeSpan(387105860598) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Outputs",
                table: "Outputs");

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "Outputs",
                newName: "Output");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Output",
                table: "Output",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Output",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(349170414754));

            migrationBuilder.UpdateData(
                table: "Output",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(349170414819));
        }
    }
}
