using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Orbita.Challenge.Infra.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Cpf", "Email", "Name" },
                values: new object[] { new Guid("7094fa95-2959-40c8-b9ad-329e36410902"), "19857635408", "vinicius.estudos@escola.com", "Vinicius Rocha" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Cpf", "Email", "Name" },
                values: new object[] { new Guid("e67b1e3f-a26c-43d8-a70c-027a0402d2fe"), "78965325872", "isabelle.estudos@escola.com", "Isabelle" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Cpf", "Email", "Name" },
                values: new object[] { new Guid("368f8ce8-d6a8-4d71-a789-f067e1c2cab5"), "755634198635", "guilherme.estudos@escola.com", "Guilherme" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}