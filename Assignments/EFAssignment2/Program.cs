using Microsoft.EntityFrameworkCore;
using EFAssignment2.DataBase; // Added this

namespace EFAssignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Retrieve the connection string
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            // Register the DbContext for Dependency Injection
            builder.Services.AddDbContext<StudentDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews(); // Add this line

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"); // Add this line

            app.Run();
        }
    }
}
