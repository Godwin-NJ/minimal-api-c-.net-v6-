using Microsoft.EntityFrameworkCore;
using minimum_api_tutorial.model;

namespace minimum_api_tutorial.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();

    }
}
