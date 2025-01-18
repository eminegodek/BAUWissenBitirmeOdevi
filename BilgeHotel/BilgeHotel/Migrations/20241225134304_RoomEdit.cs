using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BilgeHotel.Migrations
{
    /// <inheritdoc />
    public partial class RoomEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.AddColumn<int>(
                name: "Floor",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MaintenanceStatus",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "Floor", "HasAirConditioning", "HasHairdryer", "HasTV", "HasWiFi", "MaintenanceStatus", "RoomType" },
                values: new object[] { 2, 0, false, false, false, false, "Müsait", "Standard" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Floor", "HasAirConditioning", "HasHairdryer", "HasTV", "HasWiFi", "MaintenanceStatus", "PricePerNight", "RoomType" },
                values: new object[] { 0, false, false, false, false, "Müsait", 150m, "Deluxe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Floor",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "MaintenanceStatus",
                table: "Rooms");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "HasAirConditioning", "HasHairdryer", "HasTV", "HasWiFi", "RoomType" },
                values: new object[] { 1, true, true, true, true, "Single" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HasAirConditioning", "HasHairdryer", "HasTV", "HasWiFi", "PricePerNight", "RoomType" },
                values: new object[] { true, true, true, true, 300m, "Triple" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "HasAirConditioning", "HasBalcony", "HasHairdryer", "HasMinibar", "HasTV", "HasWiFi", "IsAvailable", "PricePerNight", "RoomType" },
                values: new object[,]
                {
                    { 11, 1, true, false, true, false, true, true, true, 120m, "Single" },
                    { 12, 2, true, false, true, true, true, true, true, 200m, "Double" },
                    { 21, 2, true, true, true, true, true, true, true, 250m, "Double Deluxe" },
                    { 22, 3, true, true, true, true, true, true, true, 350m, "Triple Deluxe" },
                    { 31, 2, true, true, true, true, true, true, true, 300m, "Double Deluxe" },
                    { 32, 4, true, true, true, true, true, true, true, 500m, "Quadruple" },
                    { 33, 2, true, true, true, true, true, true, true, 1000m, "King Suite" }
                });
        }
    }
}
