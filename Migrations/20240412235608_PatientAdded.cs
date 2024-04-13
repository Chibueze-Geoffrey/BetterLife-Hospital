using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetterLifeHospital.Migrations
{
    /// <inheritdoc />
    public partial class PatientAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "License",
                value: new Guid("c7d3b2ec-1050-407d-8c30-18ade5ab5eec"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "License",
                value: new Guid("71e8e776-fcc3-4cbc-9b82-0c73e3f0e9b1"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "License",
                value: new Guid("368d7ad9-73e3-4b88-a6f7-2a12fed0db63"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "License",
                value: new Guid("b7bc75b6-0fa2-4f97-89d6-3233a0783a14"));

            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "Id", "DoctorId", "FirstName", "LastName", "Problem" },
                values: new object[] { 100, 1, "Linda", "Lee", "Head ache" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "License",
                value: new Guid("c18caded-efd6-48a2-a833-780cf17224fa"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "License",
                value: new Guid("552d2e88-4fa6-44df-865c-c031b9f1e358"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "License",
                value: new Guid("ba54e429-f7f6-4682-8a3b-534452a9fbad"));

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "License",
                value: new Guid("1e0b2905-4318-4a65-8757-074baee40f30"));
        }
    }
}
