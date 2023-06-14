using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DotNetEnv;
using Microsoft.AspNetCore.Cors;

namespace Backend
{
    public class Program
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Other configurations...

             // Add CORS policy
           

            // Other configurations...
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Other configurations...

            //app.UseCors();

            // Other configurations...
        }

        public static async Task Main(string[] args)
        {
            DotNetEnv.Env.Load();

            var builder = WebApplication.CreateBuilder(args);

            
            // Register services and configure the application

            var app = builder.Build();
            var dataAccess = app.Services.GetService<Backend.Models.AccDataAccess>();

            // Display message in the terminal
            System.Console.WriteLine("Database connection established successfully!");

            // Run the application
            app.Run();
        }
    }
}