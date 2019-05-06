using CoreWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApi
{
    public class MyContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public MyContext(DbContextOptions options) : base(options)
        {}
    }
}
