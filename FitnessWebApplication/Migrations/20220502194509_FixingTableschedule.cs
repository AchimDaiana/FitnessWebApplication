using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessWebApplication.Migrations
{
    public partial class FixingTableschedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schedule_ScheduleId",
                table: "Classes");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Classes_ScheduleId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndHour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartHour = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ScheduleId",
                table: "Classes",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schedule_ScheduleId",
                table: "Classes",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
