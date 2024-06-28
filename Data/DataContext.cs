using Microsoft.EntityFrameworkCore;
using TodoApi.Entities;

namespace TodoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext>options) : base(options)
        {

        }
        public DbSet<SuperHero> SuperHeroes {get; set;}
    }
}