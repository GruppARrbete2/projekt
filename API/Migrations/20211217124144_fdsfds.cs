using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class fdsfds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(493044728460));

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(493044728499));

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Time",
                value: new TimeSpan(493044728502));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
