using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diploma_City_CityId",
                table: "Diploma");

            migrationBuilder.DropForeignKey(
                name: "FK_Diploma_Employee_EmployeeId",
                table: "Diploma");

            migrationBuilder.DropForeignKey(
                name: "FK_District_City_CityId",
                table: "District");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Commune_CommuneId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Ethnic_EthnicId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Occupation_OccupationId",
                table: "Employee");

            migrationBuilder.AddForeignKey(
                name: "FK_Diploma_City_CityId",
                table: "Diploma",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diploma_Employee_EmployeeId",
                table: "Diploma",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_District_City_CityId",
                table: "District",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Commune_CommuneId",
                table: "Employee",
                column: "CommuneId",
                principalTable: "Commune",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Ethnic_EthnicId",
                table: "Employee",
                column: "EthnicId",
                principalTable: "Ethnic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Occupation_OccupationId",
                table: "Employee",
                column: "OccupationId",
                principalTable: "Occupation",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diploma_City_CityId",
                table: "Diploma");

            migrationBuilder.DropForeignKey(
                name: "FK_Diploma_Employee_EmployeeId",
                table: "Diploma");

            migrationBuilder.DropForeignKey(
                name: "FK_District_City_CityId",
                table: "District");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Commune_CommuneId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Ethnic_EthnicId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Occupation_OccupationId",
                table: "Employee");

            migrationBuilder.AddForeignKey(
                name: "FK_Diploma_City_CityId",
                table: "Diploma",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diploma_Employee_EmployeeId",
                table: "Diploma",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_District_City_CityId",
                table: "District",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Commune_CommuneId",
                table: "Employee",
                column: "CommuneId",
                principalTable: "Commune",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Ethnic_EthnicId",
                table: "Employee",
                column: "EthnicId",
                principalTable: "Ethnic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Occupation_OccupationId",
                table: "Employee",
                column: "OccupationId",
                principalTable: "Occupation",
                principalColumn: "Id");
        }
    }
}
