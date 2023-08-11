using Microsoft.EntityFrameworkCore;

namespace MsSqlDriverBug
{
    public class GarbageDbContext : DbContext
    {
        public DbSet<LotsOfGarbage> Garbages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GarbageDb;Trusted_Connection=True;");
        }
    }
}
