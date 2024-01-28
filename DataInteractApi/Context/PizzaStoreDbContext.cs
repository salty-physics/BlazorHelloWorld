using DataInteractShared;
using Microsoft.EntityFrameworkCore;

namespace DataInteractApi.Context
{
    public class PizzaStoreDbContext : DbContext
    {
        public PizzaStoreDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyDatabase.db");
        }
        public DbSet<PizzaSpecial> Specials { get; set; }


    }
}
