using Microsoft.AspNetCore.Mvc;
using SocialWeb.Models;

namespace Social_Media_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SocialDBContext _context;
        public HomeController(SocialDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
