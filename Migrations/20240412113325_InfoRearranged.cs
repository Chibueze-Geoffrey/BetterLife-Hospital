using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BetterLifeHospital.Migrations
{
    /// <inheritdoc />
    public partial class InfoRearranged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Chibueze", "Geoffrey" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Chibuike", "Aneke" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Patrick", "Isak" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Cristiano", "Alvaro" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "", "" });
        }
    }
}
