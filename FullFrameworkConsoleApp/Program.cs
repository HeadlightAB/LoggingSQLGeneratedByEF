using System.Linq;

namespace FullFrameworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new MyContext();
            var cars = ctx.Cars.Select(x => x.Brand).ToArray();
        }
    }
}
