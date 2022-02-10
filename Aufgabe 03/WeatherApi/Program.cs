using Microsoft.EntityFrameworkCore;
using WeatherApi.Data;
using WeatherApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddDbContext<WeatherDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<WeatherDbContext>(options => options.UseInMemoryDatabase("WeatherDb"));
builder.Services.AddControllers();

var app = builder.Build();

SeedData.Initialize(app.Services.CreateScope().ServiceProvider);

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
