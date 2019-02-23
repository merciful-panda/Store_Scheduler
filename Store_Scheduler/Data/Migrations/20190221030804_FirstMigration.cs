using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Store_Scheduler.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    roleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.roleID);
                });

            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    skillID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills", x => x.skillID);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    storeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    address = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    storeName = table.Column<string>(nullable: true),
                    zipcode = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.storeID);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    birthDate = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "weeklySchedule",
                columns: table => new
                {
                    weeklyScheduleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(nullable: false),
                    employeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weeklySchedule", x => x.weeklyScheduleID);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    departmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    openspot = table.Column<int>(nullable: false),
                    priority = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    storeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.departmentID);
                    table.ForeignKey(
                        name: "FK_departments_stores_storeID",
                        column: x => x.storeID,
                        principalTable: "stores",
                        principalColumn: "storeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sales",
                columns: table => new
                {
                    salesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(nullable: false),
                    laborCost = table.Column<double>(nullable: false),
                    revenue = table.Column<double>(nullable: false),
                    storeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales", x => x.salesID);
                    table.ForeignKey(
                        name: "FK_sales_stores_storeID",
                        column: x => x.storeID,
                        principalTable: "stores",
                        principalColumn: "storeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    employeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    hourlyRate = table.Column<double>(nullable: true),
                    overtimeRate = table.Column<double>(nullable: true),
                    payType = table.Column<int>(nullable: false),
                    roleID = table.Column<int>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    userID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.employeeID);
                    table.ForeignKey(
                        name: "FK_employees_roles_roleID",
                        column: x => x.roleID,
                        principalTable: "roles",
                        principalColumn: "roleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_users_userID",
                        column: x => x.userID,
                        principalTable: "users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_skills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    employeeID = table.Column<int>(nullable: false),
                    experience = table.Column<int>(nullable: false),
                    skillID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_skills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_employee_skills_employees_employeeID",
                        column: x => x.employeeID,
                        principalTable: "employees",
                        principalColumn: "employeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_skills_skills_skillID",
                        column: x => x.skillID,
                        principalTable: "skills",
                        principalColumn: "skillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee_stores",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    employeeID = table.Column<int>(nullable: false),
                    storeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_stores", x => x.ID);
                    table.ForeignKey(
                        name: "FK_employee_stores_employees_employeeID",
                        column: x => x.employeeID,
                        principalTable: "employees",
                        principalColumn: "employeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_stores_stores_storeID",
                        column: x => x.storeID,
                        principalTable: "stores",
                        principalColumn: "storeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "shifts",
                columns: table => new
                {
                    shiftID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    assignedBy = table.Column<int>(nullable: false),
                    employeeID = table.Column<int>(nullable: false),
                    endTime = table.Column<DateTime>(nullable: true),
                    startTime = table.Column<DateTime>(nullable: false),
                    weeklyScheduleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shifts", x => x.shiftID);
                    table.ForeignKey(
                        name: "FK_shifts_employees_employeeID",
                        column: x => x.employeeID,
                        principalTable: "employees",
                        principalColumn: "employeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shifts_weeklySchedule_weeklyScheduleID",
                        column: x => x.weeklyScheduleID,
                        principalTable: "weeklySchedule",
                        principalColumn: "weeklyScheduleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "department_positions",
                columns: table => new
                {
                    positionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    departmentID = table.Column<int>(nullable: false),
                    openSpots = table.Column<int>(nullable: false),
                    positionName = table.Column<string>(nullable: true),
                    shiftID = table.Column<int>(nullable: false),
                    skillID = table.Column<int>(nullable: false),
                    skillLevel = table.Column<int>(nullable: false),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department_positions", x => x.positionID);
                    table.ForeignKey(
                        name: "FK_department_positions_departments_departmentID",
                        column: x => x.departmentID,
                        principalTable: "departments",
                        principalColumn: "departmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_department_positions_shifts_shiftID",
                        column: x => x.shiftID,
                        principalTable: "shifts",
                        principalColumn: "shiftID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_department_positions_skills_skillID",
                        column: x => x.skillID,
                        principalTable: "skills",
                        principalColumn: "skillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_department_positions_departmentID",
                table: "department_positions",
                column: "departmentID");

            migrationBuilder.CreateIndex(
                name: "IX_department_positions_shiftID",
                table: "department_positions",
                column: "shiftID");

            migrationBuilder.CreateIndex(
                name: "IX_department_positions_skillID",
                table: "department_positions",
                column: "skillID");

            migrationBuilder.CreateIndex(
                name: "IX_departments_storeID",
                table: "departments",
                column: "storeID");

            migrationBuilder.CreateIndex(
                name: "IX_employee_skills_employeeID",
                table: "employee_skills",
                column: "employeeID");

            migrationBuilder.CreateIndex(
                name: "IX_employee_skills_skillID",
                table: "employee_skills",
                column: "skillID");

            migrationBuilder.CreateIndex(
                name: "IX_employee_stores_employeeID",
                table: "employee_stores",
                column: "employeeID");

            migrationBuilder.CreateIndex(
                name: "IX_employee_stores_storeID",
                table: "employee_stores",
                column: "storeID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_roleID",
                table: "employees",
                column: "roleID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_userID",
                table: "employees",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_sales_storeID",
                table: "sales",
                column: "storeID");

            migrationBuilder.CreateIndex(
                name: "IX_shifts_employeeID",
                table: "shifts",
                column: "employeeID");

            migrationBuilder.CreateIndex(
                name: "IX_shifts_weeklyScheduleID",
                table: "shifts",
                column: "weeklyScheduleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "department_positions");

            migrationBuilder.DropTable(
                name: "employee_skills");

            migrationBuilder.DropTable(
                name: "employee_stores");

            migrationBuilder.DropTable(
                name: "sales");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "shifts");

            migrationBuilder.DropTable(
                name: "skills");

            migrationBuilder.DropTable(
                name: "stores");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "weeklySchedule");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
