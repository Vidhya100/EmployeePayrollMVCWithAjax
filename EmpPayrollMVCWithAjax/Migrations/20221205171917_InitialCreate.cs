using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmpPayrollMVCWithAjax.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpData",
                columns: table => new
                {
                    EmpID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    ProfileImg = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    Salary = table.Column<float>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpData", x => x.EmpID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpData");
        }
    }
}
