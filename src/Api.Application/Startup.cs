using CrossCutting.DependencyInjection;

using Domain.Interfaces.Services.User;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Services;

namespace application
{
    public static class Startup
    {
        public static WebApplication InitializaApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            ConfigureServices1(builder);
            var app = builder.Build();
            Configure(app);
            return app;
        }
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            ConfigureService.ConfigureDependenciesService(builder.Services);
            ConfigureRepository.ConfigureDependenciesRepository(builder.Services);
            builder.Services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }
        private static void ConfigureServices1(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }

        private static void Configure(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
