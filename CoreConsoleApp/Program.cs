using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new MyContext();
            ctx.Database.Migrate();

            var cars = ctx.Cars.Select(x => x.Brand).ToArray();
        }
    }
}
