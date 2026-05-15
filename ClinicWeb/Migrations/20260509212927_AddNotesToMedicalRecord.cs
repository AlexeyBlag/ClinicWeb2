using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicWeb.Migrations
{

    public partial class AddNotesToMedicalRecord : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "MedicalRecords",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "MedicalRecords");
        }
    }
}
