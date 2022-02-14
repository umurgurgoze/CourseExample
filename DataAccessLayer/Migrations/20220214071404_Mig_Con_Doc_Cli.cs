using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Mig_Con_Doc_Cli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_ClinicId",
                table: "Doctors",
                column: "ClinicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Clinics_ClinicId",
                table: "Doctors",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "ClinicId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Clinics_ClinicId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_ClinicId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "Doctors");
        }
    }
}
