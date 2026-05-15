using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicWeb.Migrations
{

    public partial class AddAppointmentFields : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentServices_Services_ServiceId",
                table: "AppointmentServices");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentServices_AppointmentId_ServiceId",
                table: "AppointmentServices");

            migrationBuilder.AlterColumn<int>(
                name: "PetId",
                table: "Appointments",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Appointments",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "Appointments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicalRecordId",
                table: "Appointments",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Appointments",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServices_AppointmentId",
                table: "AppointmentServices",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentServices_Services_ServiceId",
                table: "AppointmentServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentServices_Services_ServiceId",
                table: "AppointmentServices");

            migrationBuilder.DropIndex(
                name: "IX_AppointmentServices_AppointmentId",
                table: "AppointmentServices");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "MedicalRecordId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "PetId",
                table: "Appointments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Appointments",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServices_AppointmentId_ServiceId",
                table: "AppointmentServices",
                columns: new[] { "AppointmentId", "ServiceId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentServices_Services_ServiceId",
                table: "AppointmentServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
