using CRUD_Operations_With_Modal_Popup.Data;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Operations_With_Modal_Popup
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("HealthCareDbContextPostgresSQL") ?? throw new InvalidOperationException("Connection string 'HealthCareDbContext' not found.");

            builder.Services.AddDbContext<HealthCareDbContext>(options => options.UseNpgsql(connectionString));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            await SeedData.MySeedData(app);

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}