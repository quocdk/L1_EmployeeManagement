using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "Commune",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Commune",
                keyColumn: "Id",
                keyValue: new Guid("0d118c45-451d-4be9-aea5-21e727a4e68c"),
                column: "CityId",
                value: new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"));

            migrationBuilder.UpdateData(
                table: "Commune",
                keyColumn: "Id",
                keyValue: new Guid("c7b4e2be-4902-498f-954b-e35ebb7be2aa"),
                column: "CityId",
                value: new Guid("a0191258-172c-42ea-81b9-c71cd98b047b"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Commune");
        }
    }
}
