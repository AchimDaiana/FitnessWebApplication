using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessWebApplication.Migrations
{
    public partial class FixingName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSubcriptions_Subscriptions_SubscriptionId",
                table: "UserSubcriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubcriptions_Users_UserId",
                table: "UserSubcriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSubcriptions",
                table: "UserSubcriptions");

            migrationBuilder.RenameTable(
                name: "UserSubcriptions",
                newName: "User_Subcriptions");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubcriptions_UserId",
                table: "User_Subcriptions",
                newName: "IX_User_Subcriptions_UserId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Subscriptions",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Subcriptions",
                table: "User_Subcriptions",
                columns: new[] { "SubscriptionId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_User_Subcriptions_Subscriptions_SubscriptionId",
                table: "User_Subcriptions",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Subcriptions_Users_UserId",
                table: "User_Subcriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Subcriptions_Subscriptions_SubscriptionId",
                table: "User_Subcriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Subcriptions_Users_UserId",
                table: "User_Subcriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Subcriptions",
                table: "User_Subcriptions");

            migrationBuilder.RenameTable(
                name: "User_Subcriptions",
                newName: "UserSubcriptions");

            migrationBuilder.RenameIndex(
                name: "IX_User_Subcriptions_UserId",
                table: "UserSubcriptions",
                newName: "IX_UserSubcriptions_UserId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Subscriptions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSubcriptions",
                table: "UserSubcriptions",
                columns: new[] { "SubscriptionId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubcriptions_Subscriptions_SubscriptionId",
                table: "UserSubcriptions",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubcriptions_Users_UserId",
                table: "UserSubcriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
