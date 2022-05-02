using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessWebApplication.Migrations
{
    public partial class faratrainerfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Classes_TrainerId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClassesId",
                table: "Trainers");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TrainerId",
                table: "Classes",
                column: "TrainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Classes_TrainerId",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "ClassesId",
                table: "Trainers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TrainerId",
                table: "Classes",
                column: "TrainerId",
                unique: true);
        }
    }
}
