using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ethnic",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ethnic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Commune",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commune", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commune_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    EthnicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OccupationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CitizenIdentityCard = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommuneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecificAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiplomaNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Commune_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "Commune",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employee_Ethnic_EthnicId",
                        column: x => x.EthnicId,
                        principalTable: "Ethnic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employee_Occupation_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Diploma",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diploma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diploma_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Diploma_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"), "Hà Nội" },
                    { new Guid("d9ccef94-ba5e-4746-9150-c7ffa4492d6d"), "Thái Bình" }
                });

            migrationBuilder.InsertData(
                table: "Ethnic",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("192f5268-6de2-4093-a720-4f4409dbc707"), "Mường" },
                    { new Guid("41b20ba1-2ce1-405f-b828-30e2a975db67"), "Kinh" }
                });

            migrationBuilder.InsertData(
                table: "Occupation",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4f8d1e94-7904-4598-8343-f2984ee1af87"), "Nhân viên bán hàng" },
                    { new Guid("9c6764d2-508c-4ea8-a916-bd8c39900a6c"), "Lập trình viên" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { new Guid("48868dd6-6ef9-4d85-ab33-3e68369f3542"), new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"), "Hoài Đức" },
                    { new Guid("8df1f290-ed39-43d9-9f86-76eb7570bbe6"), new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"), "Đan Phượng" }
                });

            migrationBuilder.InsertData(
                table: "Commune",
                columns: new[] { "Id", "DistrictId", "Name" },
                values: new object[,]
                {
                    { new Guid("0d118c45-451d-4be9-aea5-21e727a4e68c"), new Guid("8df1f290-ed39-43d9-9f86-76eb7570bbe6"), "Tân Hội" },
                    { new Guid("c7b4e2be-4902-498f-954b-e35ebb7be2aa"), new Guid("8df1f290-ed39-43d9-9f86-76eb7570bbe6"), "Tân Lập" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Age", "CitizenIdentityCard", "CityId", "CommuneId", "DateOfBirth", "DiplomaNumber", "DistrictId", "EthnicId", "FullName", "OccupationId", "PhoneNumber", "SpecificAddress" },
                values: new object[,]
                {
                    { new Guid("1e35b504-4a19-429a-9fe9-a14151e6ebd5"), 22, "012345678912", new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"), new Guid("0d118c45-451d-4be9-aea5-21e727a4e68c"), new DateTime(2003, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("8df1f290-ed39-43d9-9f86-76eb7570bbe6"), new Guid("192f5268-6de2-4093-a720-4f4409dbc707"), "Đinh Kiến Quốc 2", new Guid("4f8d1e94-7904-4598-8343-f2984ee1af87"), "0123456782", "cụm 2" },
                    { new Guid("db3fc518-b1f8-4694-ab71-b5657c6a663a"), 22, "012345678911", new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"), new Guid("c7b4e2be-4902-498f-954b-e35ebb7be2aa"), new DateTime(2003, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("8df1f290-ed39-43d9-9f86-76eb7570bbe6"), new Guid("41b20ba1-2ce1-405f-b828-30e2a975db67"), "Đinh Kiến Quốc 1", new Guid("9c6764d2-508c-4ea8-a916-bd8c39900a6c"), "0123456781", "Cụm 1" }
                });

            migrationBuilder.InsertData(
                table: "Diploma",
                columns: new[] { "Id", "CityId", "EmployeeId", "ExpiryDate", "IssueDate", "Name" },
                values: new object[,]
                {
                    { new Guid("60c03512-f941-4bd0-ae94-62f2315b05b9"), new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"), new Guid("db3fc518-b1f8-4694-ab71-b5657c6a663a"), new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Văn bằng 1" },
                    { new Guid("84caaff9-1259-42fd-9e48-4507dc9b5cb4"), new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"), new Guid("1e35b504-4a19-429a-9fe9-a14151e6ebd5"), new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Văn bằng 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commune_DistrictId",
                table: "Commune",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Diploma_CityId",
                table: "Diploma",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Diploma_EmployeeId",
                table: "Diploma",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_District_CityId",
                table: "District",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CommuneId",
                table: "Employee",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EthnicId",
                table: "Employee",
                column: "EthnicId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_OccupationId",
                table: "Employee",
                column: "OccupationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diploma");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Commune");

            migrationBuilder.DropTable(
                name: "Ethnic");

            migrationBuilder.DropTable(
                name: "Occupation");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
