using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Access",
                table: "Doors");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Doors");

            migrationBuilder.DropColumn(
                name: "TenantID",
                table: "Doors");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Doors");

            migrationBuilder.AlterColumn<string>(
                name: "Explanation",
                table: "Doors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DörrBenämning",
                table: "Doors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Explanation",
                table: "Doors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DörrBenämning",
                table: "Doors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Access",
                table: "Doors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Doors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantID",
                table: "Doors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Doors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
