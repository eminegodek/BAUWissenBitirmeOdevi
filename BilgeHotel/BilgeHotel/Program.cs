using BilgeHotel.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BilgeHotel
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                using (var scope = app.Services.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                    var rooms = await context.Rooms.ToListAsync();
                    foreach (var room in rooms)
                    {
                        Console.WriteLine($"Room: {room.RoomType}, Capacity: {room.Capacity}");
                    }

                    var reservations = await context.Reservations
                        .Include(r => r.Room)
                        .Include(r => r.Customer)
                        .ToListAsync();
                    foreach (var reservation in reservations)
                    {
                        Console.WriteLine($"Reservation: RoomType={reservation.Room.RoomType}, Customer={reservation.Customer.FullName}, StartDate={reservation.StartDate}, EndDate={reservation.EndDate}");
                    }

                    var customers = await context.Customers.ToListAsync();
                    foreach (var customer in customers)
                    {
                        Console.WriteLine($"Customer: FullName={customer.FullName}, Email={customer.Email}");
                    }
                }
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
