using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MultitenantInNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonDbContext _context;

        public HomeController(PersonDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Person.ToListAsync());
        }
    }
}
