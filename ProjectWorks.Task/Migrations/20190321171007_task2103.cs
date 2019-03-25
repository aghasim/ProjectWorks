using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWorks.Task.Migrations
{
    public partial class task2103 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectWorks_MainTask",
                columns: table => new
                {
                    TaskId = table.Column<Guid>(nullable: false),
                    TaskName = table.Column<string>(nullable: false),
                    ResponsibleId = table.Column<Guid>(nullable: false),
                    ResponsibleName = table.Column<string>(nullable: true),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeExecution = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    TimeCompletion = table.Column<DateTime>(nullable: false),
                    ManyForTask = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectWorks_MainTask", x => x.TaskId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectWorks_NestedTask",
                columns: table => new
                {
                    NestedTaskId = table.Column<Guid>(nullable: false),
                    TaskName = table.Column<string>(nullable: false),
                    ResponsibleId = table.Column<Guid>(nullable: false),
                    ResponsibleName = table.Column<string>(nullable: true),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeExecution = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    TimeCompletion = table.Column<DateTime>(nullable: false),
                    ManyForTask = table.Column<double>(nullable: false),
                    MainTaskId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectWorks_NestedTask", x => x.NestedTaskId);
                    table.ForeignKey(
                        name: "FK_ProjectWorks_NestedTask_ProjectWorks_MainTask_NestedTaskId",
                        column: x => x.NestedTaskId,
                        principalTable: "ProjectWorks_MainTask",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectWorks_MainTask_TaskId",
                table: "ProjectWorks_MainTask",
                column: "TaskId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectWorks_NestedTask_NestedTaskId",
                table: "ProjectWorks_NestedTask",
                column: "NestedTaskId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectWorks_NestedTask");

            migrationBuilder.DropTable(
                name: "ProjectWorks_MainTask");
        }
    }
}
