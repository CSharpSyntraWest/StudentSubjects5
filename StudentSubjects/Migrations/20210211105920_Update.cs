using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSubjects.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("515bc5f6-09ea-491d-b804-0b8a86445df0"));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                column: "BirthDate",
                value: new DateTime(1927, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                column: "BirthDate",
                value: new DateTime(1947, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "BirthDate", "FirstName", "LastName" },
                values: new object[] { new Guid("0a07190b-2eb6-476b-ac9c-2ead04b2f0d6"), new DateTime(2001, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Jansens" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("0a07190b-2eb6-476b-ac9c-2ead04b2f0d6"));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                column: "BirthDate",
                value: new DateTime(1996, 2, 11, 11, 34, 49, 310, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                column: "BirthDate",
                value: new DateTime(1976, 2, 11, 11, 34, 49, 303, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "BirthDate", "FirstName", "LastName" },
                values: new object[] { new Guid("515bc5f6-09ea-491d-b804-0b8a86445df0"), new DateTime(2002, 2, 11, 11, 34, 49, 310, DateTimeKind.Local).AddTicks(2389), "Jan", "Jansens" });
        }
    }
}
