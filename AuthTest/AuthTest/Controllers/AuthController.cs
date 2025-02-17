using AuthTest.Data;
using Microsoft.AspNetCore.Mvc;

namespace AuthTest.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext db;

        public AuthController(AppDbContext db) {
        
            this.db= db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult signin()
        {
            return View();
        }
        public IActionResult signup() { 
        
            return View();
        }
    }
}
