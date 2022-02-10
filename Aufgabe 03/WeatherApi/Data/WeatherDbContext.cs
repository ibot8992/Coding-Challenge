using Microsoft.EntityFrameworkCore;

namespace WeatherApi.Data
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options)
        {
        }

        public DbSet<WeatherData> Weathers { get; set; }
    }
}
