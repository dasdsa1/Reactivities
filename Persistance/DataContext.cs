using Microsoft.EntityFrameworkCore;
using Domain;
using SQLitePCL;


namespace Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Activity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mydb.db");
            SQLitePCL.Batteries.Init();
        }

    }
}
