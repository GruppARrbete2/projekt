using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Test5454 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: 637754358879726706L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: 637754358879726742L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Time",
                value: 637754358879726745L);

            migrationBuilder.InsertData(
                table: "Outputs",
                columns: new[] { "ID", "Code", "DörrBenämning", "Person", "Tag", "Time" },
                values: new object[,]
                {
                    { 4, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754358879726747L },
                    { 5, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754358879726749L },
                    { 6, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754358879726752L },
                    { 7, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754358879726754L },
                    { 8, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754358879726756L },
                    { 9, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754358879726758L },
                    { 10, "DÖIN", "Lägenhet", "Göran Ahlström", "0302A", 637754358879726760L },
                    { 11, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726762L },
                    { 12, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726764L },
                    { 13, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726766L },
                    { 14, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726769L },
                    { 15, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726771L },
                    { 16, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726773L },
                    { 17, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726775L },
                    { 18, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726777L },
                    { 19, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726779L },
                    { 20, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726780L },
                    { 21, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726783L },
                    { 22, "DÖIN", "TVÄTT", "Ella Ahlström", "0301A", 637754358879726785L }
                });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "TenantID", "Apartment", "LocationID", "Namne", "Tag" },
                values: new object[,]
                {
                    { 3, 1002, null, "Jonas Andersson", "1002B" },
                    { 4, 1001, null, "Stefan Andersson", "1002B" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "TenantID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Time",
                value: 637753531211374778L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Time",
                value: 637753531211374819L);

            migrationBuilder.UpdateData(
                table: "Outputs",
                keyColumn: "ID",
                keyValue: 3,
                column: "Time",
                value: 637753531211374823L);
        }
    }
}
