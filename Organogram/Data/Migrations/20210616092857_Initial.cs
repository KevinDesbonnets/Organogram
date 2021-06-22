using Microsoft.EntityFrameworkCore.Migrations;

namespace Organogram.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Worker_Worker_SeniorID",
                table: "Worker");

            migrationBuilder.DropIndex(
                name: "IX_Worker_SeniorID",
                table: "Worker");

            migrationBuilder.DropColumn(
                name: "SeniorID",
                table: "Worker");

            migrationBuilder.AddColumn<int>(
                name: "SeniorIDID",
                table: "Worker",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Worker_SeniorIDID",
                table: "Worker",
                column: "SeniorIDID");

            migrationBuilder.AddForeignKey(
                name: "FK_Worker_Worker_SeniorIDID",
                table: "Worker",
                column: "SeniorIDID",
                principalTable: "Worker",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Worker_Worker_SeniorIDID",
                table: "Worker");

            migrationBuilder.DropIndex(
                name: "IX_Worker_SeniorIDID",
                table: "Worker");

            migrationBuilder.DropColumn(
                name: "SeniorIDID",
                table: "Worker");

            migrationBuilder.AddColumn<int>(
                name: "SeniorID",
                table: "Worker",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Worker_SeniorID",
                table: "Worker",
                column: "SeniorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Worker_Worker_SeniorID",
                table: "Worker",
                column: "SeniorID",
                principalTable: "Worker",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
