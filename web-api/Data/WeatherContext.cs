using web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace web_api.Data
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {
        }

        public DbSet<Weather> Weather { get; set; }
    }
}