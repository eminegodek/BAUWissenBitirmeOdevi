namespace BilgeHotel.Models
{
    public class RoomInitializer
    {
        public static List<Room> InitializeRooms()
        {
            var rooms = new List<Room>();
            int roomId = 1;

            // 1. Kat: 3 kişilik ve 1 kişilik odalar
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(new Room
                {
                    Id = roomId++,
                    RoomType = "Üç Kişilik",
                    Capacity = 3,
                    Floor = 1,
                    HasBalcony = false,
                    HasMinibar = false,
                    HasAirConditioning = true,
                    HasTV = true,
                    HasHairdryer = true,
                    HasWiFi = true,
                    IsAvailable = true,
                    PricePerNight = 300
                });
            }
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(new Room
                {
                    Id = roomId++,
                    RoomType = "Tek Kişilik",
                    Capacity = 1,
                    Floor = 1,
                    HasBalcony = false,
                    HasMinibar = false,
                    HasAirConditioning = true,
                    HasTV = true,
                    HasHairdryer = true,
                    HasWiFi = true,
                    IsAvailable = true,
                    PricePerNight = 150
                });
            }

            // 2. Kat: 2 kişilik ve tek kişilik odalar
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(new Room
                {
                    Id = roomId++,
                    RoomType = "İki Kişilik",
                    Capacity = 2,
                    Floor = 2,
                    HasBalcony = false,
                    HasMinibar = true,
                    HasAirConditioning = true,
                    HasTV = true,
                    HasHairdryer = true,
                    HasWiFi = true,
                    IsAvailable = true,
                    PricePerNight = 250
                });
            }
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(new Room
                {
                    Id = roomId++,
                    RoomType = "Tek Kişilik",
                    Capacity = 1,
                    Floor = 2,
                    HasBalcony = false,
                    HasMinibar = false,
                    HasAirConditioning = true,
                    HasTV = true,
                    HasHairdryer = true,
                    HasWiFi = true,
                    IsAvailable = true,
                    PricePerNight = 150
                });
            }

            // 3. Kat: Balkonlu odalar
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(new Room
                {
                    Id = roomId++,
                    RoomType = "İki Kişilik",
                    Capacity = 2,
                    Floor = 3,
                    HasBalcony = true,
                    HasMinibar = true,
                    HasAirConditioning = true,
                    HasTV = true,
                    HasHairdryer = true,
                    HasWiFi = true,
                    IsAvailable = true,
                    PricePerNight = 350
                });
            }
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(new Room
                {
                    Id = roomId++,
                    RoomType = "Aile Odası",
                    Capacity = 3,
                    Floor = 3,
                    HasBalcony = true,
                    HasMinibar = true,
                    HasAirConditioning = true,
                    HasTV = true,
                    HasHairdryer = true,
                    HasWiFi = true,
                    IsAvailable = true,
                    PricePerNight = 450
                });
            }

            // 4. Kat: Kral Dairesi ve diğer odalar
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(new Room
                {
                    Id = roomId++,
                    RoomType = "İki Kişilik + Tek Kişilik",
                    Capacity = 3,
                    Floor = 4,
                    HasBalcony = true,
                    HasMinibar = true,
                    HasAirConditioning = true,
                    HasTV = true,
                    HasHairdryer = true,
                    HasWiFi = true,
                    IsAvailable = true,
                    PricePerNight = 500
                });
            }
            rooms.Add(new Room
            {
                Id = roomId++,
                RoomType = "Kral Dairesi",
                Capacity = 4,
                Floor = 4,
                HasBalcony = true,
                HasMinibar = true,
                HasAirConditioning = true,
                HasTV = true,
                HasHairdryer = true,
                HasWiFi = true,
                IsAvailable = true,
                PricePerNight = 1000
            });

            return rooms;
        }
    }
}
