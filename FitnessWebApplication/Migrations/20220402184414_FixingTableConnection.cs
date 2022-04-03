using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessWebApplication.Migrations
{
    public partial class FixingTableConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassesReservation");

            migrationBuilder.DropTable(
                name: "ClassesTrainer");

            migrationBuilder.AddColumn<int>(
                name: "ClassesId",
                table: "Trainers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassesId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ClassesId",
                table: "Reservations",
                column: "ClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TrainerId",
                table: "Classes",
                column: "TrainerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Trainers_TrainerId",
                table: "Classes",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Classes_ClassesId",
                table: "Reservations",
                column: "ClassesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Trainers_TrainerId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Classes_ClassesId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ClassesId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Classes_TrainerId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClassesId",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "ClassesId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Classes");

            migrationBuilder.CreateTable(
                name: "ClassesReservation",
                columns: table => new
                {
                    ClassesId = table.Column<int>(type: "int", nullable: false),
                    ReservationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassesReservation", x => new { x.ClassesId, x.ReservationsId });
                    table.ForeignKey(
                        name: "FK_ClassesReservation_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassesReservation_Reservations_ReservationsId",
                        column: x => x.ReservationsId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassesTrainer",
                columns: table => new
                {
                    ClassesId = table.Column<int>(type: "int", nullable: false),
                    TrainersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassesTrainer", x => new { x.ClassesId, x.TrainersId });
                    table.ForeignKey(
                        name: "FK_ClassesTrainer_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassesTrainer_Trainers_TrainersId",
                        column: x => x.TrainersId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassesReservation_ReservationsId",
                table: "ClassesReservation",
                column: "ReservationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassesTrainer_TrainersId",
                table: "ClassesTrainer",
                column: "TrainersId");
        }
    }
}
