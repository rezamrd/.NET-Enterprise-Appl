using Lab4v2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab4v2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly NewsDbContext _context;

        public HomeController(NewsDbContext context)
        {
            _context = context;
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}

