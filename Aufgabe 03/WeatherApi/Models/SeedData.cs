using Microsoft.EntityFrameworkCore;
using WeatherApi.Data;

namespace WeatherApi.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WeatherDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<WeatherDbContext>>()))
            {
                // Look for any movies.
                if (context.Weathers.Any())
                {
                    return;   // DB has been seeded
                }

                context.Weathers.AddRange(
                    new WeatherData
                    {
                        Id = 2929670,
                        name = "Erfurt",
                        temp = 279.16f,
                        feels_like = 273.88f,
                        temp_min = 277.6f,
                        temp_max = 280.49f,
                        pressure = 1002,
                        humidity = 81,
                        speed = 10.8f,
                        deg = 220
                    });

                context.Weathers.AddRange(
                    new WeatherData
                    {

                        Id = 2826287,
                        name = "Stralsund",
                        temp = 280.47f,
                        feels_like = 276.71f,
                        temp_min = 279.83f,
                        temp_max = 280.96f,
                        pressure = 995,
                        humidity = 92,
                        speed = 6.81f,
                        deg = 246
                    });

                context.Weathers.AddRange(
                    new WeatherData
                    {
                        Id = 2856198,
                        name = "Ostseebad Binz",
                        temp = 280.34f,
                        feels_like = 276.23f,
                        temp_min = 280.34f,
                        temp_max = 281.47f,
                        pressure = 994,
                        humidity = 92,
                        speed = 7.8f,
                        deg = 240
                    });

                context.Weathers.AddRange(
                    new WeatherData
                    {
                        Id = 2935022,
                        name = "Dresden",
                        temp = 280.77f,
                        feels_like = 279.02f,
                        temp_min = 278.25f,
                        temp_max = 281.48f,
                        pressure = 997,
                        humidity = 71,
                        speed = 2.68f,
                        deg = 227
                    });

                context.Weathers.AddRange(
                    new WeatherData
                    {
                        Id = 2925533,
                        name = "Frankfurt am Main",
                        temp = 279.47f,
                        feels_like = 278.27f,
                        temp_min = 277.73f,
                        temp_max = 280.85f,
                        pressure = 1008f,
                        humidity = 76,
                        speed = 1.79f,
                        deg = 5,
                    });

                context.Weathers.AddRange(
                    new WeatherData
                    {
                        Id = 2911298,
                        name = "Hamburg",
                        temp = 279.19f,
                        feels_like = 276.22f,
                        temp_min = 278.65f,
                        temp_max = 280.16f,
                        pressure = 995,
                        humidity = 95,
                        speed = 4.12f,
                        deg = 240
                    });

                context.Weathers.AddRange(
                    new WeatherData
                    {
                        Id = 2886242,
                        name = "Köln",
                        temp = 280.73f,
                        feels_like = 280.73f,
                        temp_min = 279.23f,
                        temp_max = 281.94f,
                        pressure = 994,
                        humidity = 81,
                        speed = 0.89f,
                        deg = 183,
                    });

                context.Weathers.AddRange(
                    new WeatherData
                    {
                        Id = 6548737,
                        name = "Leipzig",
                        temp = 280.62f,
                        feels_like = 275.94f,
                        temp_min = 279.32f,
                        temp_max = 281.47f,
                        pressure = 1004,
                        humidity = 72,
                        speed = 10.28f,
                        deg = 220,
                    });

                context.Weathers.AddRange(
                    new WeatherData
                    {
                        Id = 2874225,
                        name = "Mainz",
                        temp = 279.38f,
                        feels_like = 279.38f,
                        temp_min = 278.25f,
                        temp_max = 280.96f,
                        pressure = 1008,
                        humidity = 90,
                        speed = 0.89f,
                        deg = 230,
                    });

                context.Weathers.AddRange(
                    new WeatherData
                    {
                        Id = 2867714,
                        name = "München",
                        temp = 278.9f,
                        feels_like = 275.92f,
                        temp_min = 276.99f,
                        temp_max = 280.7f,
                        pressure = 1019,
                        humidity = 58,
                        speed = 4.02f,
                        deg = 267,
                    });

                context.SaveChanges();
            }
        }
    }
}
