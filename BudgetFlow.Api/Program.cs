using BudgetFlow.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BudgetFlow.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddInfrastructure(builder.Configuration);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontendDev", builder =>
                {
                    builder.WithOrigins("http://localhost:3000")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });

            builder.Services.AddLogging();

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            var app = builder.Build();

            var logger = app.Services.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("BudgetFlow API is starting up...");

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Use middleware
            app.UseCors("AllowFrontendDev");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
