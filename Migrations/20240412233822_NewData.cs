using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetterLifeHospital.Migrations
{
    /// <inheritdoc />
    public partial class NewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
