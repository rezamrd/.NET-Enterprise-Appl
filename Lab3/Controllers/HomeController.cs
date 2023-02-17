using Lab3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() { return View(); }

        public IActionResult SongForm() { return View(); }

        [HttpPost]
        public IActionResult Sing()
        {

            HttpContext.Session.SetString("bottleQunatties", Request.Form["bottleQunatties"]);
            return View();

        }

        [HttpGet]
        public IActionResult CreateStudent() { return View(); }

        [HttpPost]
        public IActionResult DisplayStudent(Student student)
        {

            return View(student);

        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
