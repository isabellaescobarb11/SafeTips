using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SafeTips.Migrations
{
    /// <inheritdoc />
    public partial class SeedHousekeepers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Housekeepers",
                columns: new[] { "Id", "Description", "Hotel", "Name", "profImg" },
                values: new object[,]
                {
                    { 19863245, "Has worked here for 5 years", "Grand Village", "Marcyne", "" },
                    { 97393749, "Has worked here for 7 months", "Bonneville Mount", "Garry", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Housekeepers",
                keyColumn: "Id",
                keyValue: 19863245);

            migrationBuilder.DeleteData(
                table: "Housekeepers",
                keyColumn: "Id",
                keyValue: 97393749);
        }
    }
}
