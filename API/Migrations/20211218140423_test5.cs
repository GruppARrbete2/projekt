using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Apartment",
                table: "Tenants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: 637754366628079589L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: 637754366628079623L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Time",
                value: 637754366628079629L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 4,
                column: "Time",
                value: 637754366628079631L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 5,
                column: "Time",
                value: 637754366628079632L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 6,
                column: "Time",
                value: 637754366628079634L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 7,
                column: "Time",
                value: 637754366628079637L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 8,
                column: "Time",
                value: 637754366628079639L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 9,
                column: "Time",
                value: 637754366628079642L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 10,
                column: "Time",
                value: 637754366628079643L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 11,
                column: "Time",
                value: 637754366628079645L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 12,
                column: "Time",
                value: 637754366628079647L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 13,
                column: "Time",
                value: 637754366628079649L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 14,
                column: "Time",
                value: 637754366628079650L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 15,
                column: "Time",
                value: 637754366628079652L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 16,
                column: "Time",
                value: 637754366628079654L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 17,
                column: "Time",
                value: 637754366628079656L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 18,
                column: "Time",
                value: 637754366628079658L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 19,
                column: "Time",
                value: 637754366628079659L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 20,
                column: "Time",
                value: 637754366628079661L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 21,
                column: "Time",
                value: 637754366628079663L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 22,
                column: "Time",
                value: 637754366628079665L);

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "TenantID",
                keyValue: 1,
                column: "Apartment",
                value: "1001");

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "TenantID",
                keyValue: 2,
                column: "Apartment",
                value: "1002");

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "TenantID",
                keyValue: 3,
                column: "Apartment",
                value: "1002");

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "TenantID",
                keyValue: 4,
                column: "Apartment",
                value: "1001");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Apartment",
                table: "Tenants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: 637754363807826772L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: 637754363807826939L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Time",
                value: 637754363807826942L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 4,
                column: "Time",
                value: 637754363807826944L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 5,
                column: "Time",
                value: 637754363807826947L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 6,
                column: "Time",
                value: 637754363807826949L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 7,
                column: "Time",
                value: 637754363807826951L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 8,
                column: "Time",
                value: 637754363807826953L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 9,
                column: "Time",
                value: 637754363807826955L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 10,
                column: "Time",
                value: 637754363807826957L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 11,
                column: "Time",
                value: 637754363807826958L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 12,
                column: "Time",
                value: 637754363807826960L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 13,
                column: "Time",
                value: 637754363807826962L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 14,
                column: "Time",
                value: 637754363807826963L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 15,
                column: "Time",
                value: 637754363807826965L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 16,
                column: "Time",
                value: 637754363807826969L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 17,
                column: "Time",
                value: 637754363807826971L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 18,
                column: "Time",
                value: 637754363807826973L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 19,
                column: "Time",
                value: 637754363807826974L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 20,
                column: "Time",
                value: 637754363807826976L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 21,
                column: "Time",
                value: 637754363807826978L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 22,
                column: "Time",
                value: 637754363807826979L);

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "TenantID",
                keyValue: 1,
                column: "Apartment",
                value: 1001);

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "TenantID",
                keyValue: 2,
                column: "Apartment",
                value: 1002);

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "TenantID",
                keyValue: 3,
                column: "Apartment",
                value: 1002);

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "TenantID",
                keyValue: 4,
                column: "Apartment",
                value: 1001);
        }
    }
}
