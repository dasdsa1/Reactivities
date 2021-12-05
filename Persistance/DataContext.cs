using Microsoft.EntityFrameworkCore;
using Domain;
using SQLitePCL;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Persistance
{
    public class DataContext : IdentityDbContext<AppUser>
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
