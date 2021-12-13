using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoorsOpened",
                columns: table => new
                {
                    DoorOpenedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantID = table.Column<int>(type: "int", nullable: true),
                    Time = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorsOpened", x => x.DoorOpenedId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoorsOpened");
        }
    }
}
