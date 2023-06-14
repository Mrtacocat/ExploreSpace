using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DotNetEnv;
using Microsoft.AspNetCore.Cors;
using Backend.Models;

namespace Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DotNetEnv.Env.Load();

            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile("appsettings.json");

            // Register services and configure the application
            ConfigureServices(builder.Services);

            var app = builder.Build();

            // Add the CORS middleware
            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Display message in the terminal
            System.Console.WriteLine("Database connection established successfully!");

            // Run the application
            app.Run();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            // Other configurations...
            services.AddSingleton<AccDataAccess>(); 
            // Add CORS policy
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.WithOrigins("http://localhost:3000")
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });

            // Add authorization services
            services.AddAuthorization();

            // Add controllers
            services.AddControllers();

            // Other configurations...
        }
    }
}
