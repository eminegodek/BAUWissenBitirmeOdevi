using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BilgeHotel.Migrations
{
    /// <inheritdoc />
    public partial class CreateRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "Floor", "HasAirConditioning", "HasBalcony", "HasHairdryer", "HasMinibar", "HasTV", "HasWiFi", "IsAvailable", "MaintenanceStatus", "PricePerNight", "RoomType" },
                values: new object[,]
                {
                    { 1, 3, 1, true, false, true, false, true, true, true, null, 300m, "Üç Kişilik" },
                    { 2, 3, 1, true, false, true, false, true, true, true, null, 300m, "Üç Kişilik" },
                    { 3, 3, 1, true, false, true, false, true, true, true, null, 300m, "Üç Kişilik" },
                    { 4, 3, 1, true, false, true, false, true, true, true, null, 300m, "Üç Kişilik" },
                    { 5, 3, 1, true, false, true, false, true, true, true, null, 300m, "Üç Kişilik" },
                    { 6, 3, 1, true, false, true, false, true, true, true, null, 300m, "Üç Kişilik" },
                    { 7, 3, 1, true, false, true, false, true, true, true, null, 300m, "Üç Kişilik" },
                    { 8, 3, 1, true, false, true, false, true, true, true, null, 300m, "Üç Kişilik" },
                    { 9, 3, 1, true, false, true, false, true, true, true, null, 300m, "Üç Kişilik" },
                    { 10, 3, 1, true, false, true, false, true, true, true, null, 300m, "Üç Kişilik" },
                    { 11, 1, 1, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 12, 1, 1, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 13, 1, 1, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 14, 1, 1, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 15, 1, 1, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 16, 1, 1, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 17, 1, 1, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 18, 1, 1, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 19, 1, 1, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 20, 1, 1, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 21, 2, 2, true, false, true, true, true, true, true, null, 250m, "İki Kişilik" },
                    { 22, 2, 2, true, false, true, true, true, true, true, null, 250m, "İki Kişilik" },
                    { 23, 2, 2, true, false, true, true, true, true, true, null, 250m, "İki Kişilik" },
                    { 24, 2, 2, true, false, true, true, true, true, true, null, 250m, "İki Kişilik" },
                    { 25, 2, 2, true, false, true, true, true, true, true, null, 250m, "İki Kişilik" },
                    { 26, 2, 2, true, false, true, true, true, true, true, null, 250m, "İki Kişilik" },
                    { 27, 2, 2, true, false, true, true, true, true, true, null, 250m, "İki Kişilik" },
                    { 28, 2, 2, true, false, true, true, true, true, true, null, 250m, "İki Kişilik" },
                    { 29, 2, 2, true, false, true, true, true, true, true, null, 250m, "İki Kişilik" },
                    { 30, 2, 2, true, false, true, true, true, true, true, null, 250m, "İki Kişilik" },
                    { 31, 1, 2, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 32, 1, 2, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 33, 1, 2, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 34, 1, 2, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 35, 1, 2, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 36, 1, 2, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 37, 1, 2, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 38, 1, 2, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 39, 1, 2, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 40, 1, 2, true, false, true, false, true, true, true, null, 150m, "Tek Kişilik" },
                    { 41, 2, 3, true, true, true, true, true, true, true, null, 350m, "İki Kişilik" },
                    { 42, 2, 3, true, true, true, true, true, true, true, null, 350m, "İki Kişilik" },
                    { 43, 2, 3, true, true, true, true, true, true, true, null, 350m, "İki Kişilik" },
                    { 44, 2, 3, true, true, true, true, true, true, true, null, 350m, "İki Kişilik" },
                    { 45, 2, 3, true, true, true, true, true, true, true, null, 350m, "İki Kişilik" },
                    { 46, 2, 3, true, true, true, true, true, true, true, null, 350m, "İki Kişilik" },
                    { 47, 2, 3, true, true, true, true, true, true, true, null, 350m, "İki Kişilik" },
                    { 48, 2, 3, true, true, true, true, true, true, true, null, 350m, "İki Kişilik" },
                    { 49, 2, 3, true, true, true, true, true, true, true, null, 350m, "İki Kişilik" },
                    { 50, 2, 3, true, true, true, true, true, true, true, null, 350m, "İki Kişilik" },
                    { 51, 3, 3, true, true, true, true, true, true, true, null, 450m, "Aile Odası" },
                    { 52, 3, 3, true, true, true, true, true, true, true, null, 450m, "Aile Odası" },
                    { 53, 3, 3, true, true, true, true, true, true, true, null, 450m, "Aile Odası" },
                    { 54, 3, 3, true, true, true, true, true, true, true, null, 450m, "Aile Odası" },
                    { 55, 3, 3, true, true, true, true, true, true, true, null, 450m, "Aile Odası" },
                    { 56, 3, 3, true, true, true, true, true, true, true, null, 450m, "Aile Odası" },
                    { 57, 3, 3, true, true, true, true, true, true, true, null, 450m, "Aile Odası" },
                    { 58, 3, 3, true, true, true, true, true, true, true, null, 450m, "Aile Odası" },
                    { 59, 3, 3, true, true, true, true, true, true, true, null, 450m, "Aile Odası" },
                    { 60, 3, 3, true, true, true, true, true, true, true, null, 450m, "Aile Odası" },
                    { 61, 3, 4, true, true, true, true, true, true, true, null, 500m, "İki Kişilik + Tek Kişilik" },
                    { 62, 3, 4, true, true, true, true, true, true, true, null, 500m, "İki Kişilik + Tek Kişilik" },
                    { 63, 3, 4, true, true, true, true, true, true, true, null, 500m, "İki Kişilik + Tek Kişilik" },
                    { 64, 3, 4, true, true, true, true, true, true, true, null, 500m, "İki Kişilik + Tek Kişilik" },
                    { 65, 3, 4, true, true, true, true, true, true, true, null, 500m, "İki Kişilik + Tek Kişilik" },
                    { 66, 3, 4, true, true, true, true, true, true, true, null, 500m, "İki Kişilik + Tek Kişilik" },
                    { 67, 3, 4, true, true, true, true, true, true, true, null, 500m, "İki Kişilik + Tek Kişilik" },
                    { 68, 3, 4, true, true, true, true, true, true, true, null, 500m, "İki Kişilik + Tek Kişilik" },
                    { 69, 3, 4, true, true, true, true, true, true, true, null, 500m, "İki Kişilik + Tek Kişilik" },
                    { 70, 3, 4, true, true, true, true, true, true, true, null, 500m, "İki Kişilik + Tek Kişilik" },
                    { 71, 4, 4, true, true, true, true, true, true, true, null, 1000m, "Kral Dairesi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

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
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20);

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
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30);

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

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71);
        }
    }
}
