using CoreConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace CoreConsoleApp
{
    public class MyContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CoreConsoleApp.MyContext;Trusted_Connection=True;")
                .UseLoggerFactory(new LoggerFactory(new[] {new DebugLoggerProvider((s, level) => true)}));
        }
    }
}
