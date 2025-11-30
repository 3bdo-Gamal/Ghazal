using Ghazal.Models;
using Microsoft.EntityFrameworkCore;

namespace Ghazal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<GhazalContext>(options =>
            options.UseMySql(
             builder.Configuration.GetConnectionString("DefaultConnection"),
             new MySqlServerVersion(new Version(8, 0, 41))
             )
             );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<GhazalContext>();
                try
                {
                    if (db.Database.CanConnect())
                    {
                        Console.WriteLine(" Successfully connected to the database!");
                    }
                    else
                    {
                        Console.WriteLine(" Failed to connect to the database.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" Exception: {ex.Message}");
                }
            }

           

            app.Run();
        }
    }
}
