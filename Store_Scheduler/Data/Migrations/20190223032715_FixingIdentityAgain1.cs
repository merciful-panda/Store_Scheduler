using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Store_Scheduler.Data.Migrations
{
    public partial class FixingIdentityAgain1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_positions_skills_skillID",
                table: "department_positions");

            migrationBuilder.DropForeignKey(
                name: "FK_employee_skills_skills_skillID",
                table: "employee_skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_skills",
                table: "skills");

            migrationBuilder.RenameTable(
                name: "skills",
                newName: "skillss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_skillss",
                table: "skillss",
                column: "skillID");

            migrationBuilder.AddForeignKey(
                name: "FK_department_positions_skillss_skillID",
                table: "department_positions",
                column: "skillID",
                principalTable: "skillss",
                principalColumn: "skillID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employee_skills_skillss_skillID",
                table: "employee_skills",
                column: "skillID",
                principalTable: "skillss",
                principalColumn: "skillID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_positions_skillss_skillID",
                table: "department_positions");

            migrationBuilder.DropForeignKey(
                name: "FK_employee_skills_skillss_skillID",
                table: "employee_skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_skillss",
                table: "skillss");

            migrationBuilder.RenameTable(
                name: "skillss",
                newName: "skills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_skills",
                table: "skills",
                column: "skillID");

            migrationBuilder.AddForeignKey(
                name: "FK_department_positions_skills_skillID",
                table: "department_positions",
                column: "skillID",
                principalTable: "skills",
                principalColumn: "skillID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employee_skills_skills_skillID",
                table: "employee_skills",
                column: "skillID",
                principalTable: "skills",
                principalColumn: "skillID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
