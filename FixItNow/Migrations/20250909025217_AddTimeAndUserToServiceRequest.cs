using Microsoft.EntityFrameworkCore.Migrations;

namespace FixItNow.Migrations
{
    public partial class AddTimeAndUserToServiceRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PreferredTime",
                table: "ServiceRequests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ServiceRequests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_UserId",
                table: "ServiceRequests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRequests_Users_UserId",
                table: "ServiceRequests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRequests_Users_UserId",
                table: "ServiceRequests");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRequests_UserId",
                table: "ServiceRequests");

            migrationBuilder.DropColumn(
                name: "PreferredTime",
                table: "ServiceRequests");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ServiceRequests");
        }
    }
}
