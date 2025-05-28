using Lekcja0101.Models;
using Microsoft.EntityFrameworkCore;

namespace Lekcja0101.Data
{
    public class LekcjaContext : DbContext
    {
        public LekcjaContext(DbContextOptions<LekcjaContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
