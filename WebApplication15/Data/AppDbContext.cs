using Microsoft.EntityFrameworkCore;
using WebApplication15.Models;

namespace MovieSearchApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Movie> Movies => Set<Movie>();
    }
}