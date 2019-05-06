using System.Data.Entity;
using System.Diagnostics;
using FullFrameworkConsoleApp.Entities;

namespace FullFrameworkConsoleApp
{
    public class MyContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public MyContext() : base(@"Server=(localdb)\MSSQLLocalDB;Database=FullFrameworkConsoleApp.MyContext;Trusted_Connection=True;")
        {
            Database.Log = s => Debug.Write(s);

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyContext, Migrations.Configuration>());
        }
    }
}