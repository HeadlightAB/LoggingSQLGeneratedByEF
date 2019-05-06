using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly MyContext _context;

        public CarsController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var cars = _context.Cars.Select(x => x.Brand).ToArray();

            return cars;
        }
    }
}
