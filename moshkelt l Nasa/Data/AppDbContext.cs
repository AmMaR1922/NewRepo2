using Microsoft.EntityFrameworkCore;
using moshkelt_l_Nasa.models;

namespace moshkelt_l_Nasa.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<StringRecord> Strings { get; set; }
    }
}
