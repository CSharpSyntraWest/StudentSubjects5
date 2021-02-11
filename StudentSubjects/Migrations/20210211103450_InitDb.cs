using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSubjects.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentSubject_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new DateTime(1976, 2, 11, 11, 34, 49, 303, DateTimeKind.Local).AddTicks(1862), "Jos", "De Klos" },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new DateTime(1996, 2, 11, 11, 34, 49, 310, DateTimeKind.Local).AddTicks(2289), "Joke", "De Klos" },
                    { new Guid("515bc5f6-09ea-491d-b804-0b8a86445df0"), new DateTime(2002, 2, 11, 11, 34, 49, 310, DateTimeKind.Local).AddTicks(2389), "Jan", "Jansens" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "SubjectId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "Csharp programming language", "C#" },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "Sql Server for beginners", "Database" },
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "Web applications in ASP.NET Core", "Web apps" }
                });

            migrationBuilder.InsertData(
                table: "StudentSubject",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new Guid("80abbca8-664d-4b20-b5de-024705497d4a") },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new Guid("80abbca8-664d-4b20-b5de-024705497d4a") },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a") },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectId",
                table: "StudentSubject",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
