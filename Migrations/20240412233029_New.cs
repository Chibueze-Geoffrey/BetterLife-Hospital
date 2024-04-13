using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetterLifeHospital.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "License",
                value: new Guid("d7ae908f-13d6-48f5-81d9-f3d1eb6e85d7"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "License",
                value: new Guid("5f84fd99-0e24-4de3-bdc9-c48e68313ac3"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "License",
                value: new Guid("7c93393a-b09b-4115-93e5-a194b06ee87e"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "License",
                value: new Guid("e507985e-ad2f-4604-98ea-7aa52603061b"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "License",
                value: new Guid("61793209-74fa-4148-9c2a-751097ab1f67"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "License",
                value: new Guid("6fa28154-d4ab-4129-a135-cae6537a2bac"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "License",
                value: new Guid("73c00d2d-3a9d-4f24-95d7-4b3ed88e8d33"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "License",
                value: new Guid("6cf7689d-09be-49b1-9a96-b98a63d1a4ab"));
        }
    }
}
