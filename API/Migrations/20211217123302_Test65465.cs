using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Test65465 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(487826722939));

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(487826722975));

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Time",
                value: new TimeSpan(487826722978));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(388888637628));

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(388888637676));

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Time",
                value: new TimeSpan(388888637680));
        }
    }
}
