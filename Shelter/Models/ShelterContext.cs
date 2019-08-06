using Microsoft.EntityFrameworkCore;

namespace Shelter.Models
{
    public class ShelterContext : DbContext
    {
        public DbSet<Animal> Animal { get; set; }

        public ShelterContext(DbContextOptions options) : base(options) { }
    }
}