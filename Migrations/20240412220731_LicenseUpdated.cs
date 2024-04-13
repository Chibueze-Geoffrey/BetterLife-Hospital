using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetterLifeHospital.Migrations
{
    /// <inheritdoc />
    public partial class LicenseUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "License",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "License",
                table: "appointments");

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "1",
                column: "License",
                value: new Guid("0d212e08-adcb-4bd6-9aa1-c1a6f907888e"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "2",
                column: "License",
                value: new Guid("65328040-c514-4435-9b0f-1a4bfd5341d0"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "3",
                column: "License",
                value: new Guid("6d92ab1f-4788-42f1-ab27-5b50272389d2"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "4",
                column: "License",
                value: new Guid("0301b547-eef2-47ca-9d33-7c1b3d96daa5"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "License",
                table: "patients",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "License",
                table: "appointments",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "1",
                column: "License",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "2",
                column: "License",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "3",
                column: "License",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "4",
                column: "License",
                value: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
