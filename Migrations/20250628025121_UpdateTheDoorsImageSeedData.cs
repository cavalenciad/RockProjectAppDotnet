using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RockProjectBackend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTheDoorsImageSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 14,
                column: "Imagen",
                value: "https://static.stereogum.com/uploads/2015/07/the_doors.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 14,
                column: "Imagen",
                value: "https://static.stereogum.com/uploads/2015/07/the_doors.jpgg");
        }
    }
}
