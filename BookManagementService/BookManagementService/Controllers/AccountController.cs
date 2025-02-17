using BookManagementService.Data;
using BookManagementService.Migrations;
using BookManagementService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace BookManagementService.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext db;
        public AccountController(ApplicationDbContext db)
        {
            this.db=db;  
        }
        public IActionResult Index()
        {
            var d = HttpContext.Session.GetString("user");
            if (d == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Us=d.ToString();
                var data=db.users.ToList();
                return View(data);
            }
           
        }
        public static string EncryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return null;
            }
            else
            {
                byte[] b = ASCIIEncoding.ASCII.GetBytes(password);
                string ep = Convert.ToBase64String(b);
                return ep;
            }
        }

        public static string DecryptPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return null;
            }
            else
            {
                byte[] data = Convert.FromBase64String(password);
                string pass = ASCIIEncoding.ASCII.GetString(data);
                return pass;
            }
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                User us = new User()
                {

                    UserId = user.UserId,
                    Name = user.Name,
                    Email = user.Email,
                    Password = user.Password,
                    Phone = user.Phone,
                };

                db.users.Add(us);
                db.SaveChanges();
                TempData["Message"] = "User Added Successfully";
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel us)
        {
            if(ModelState.IsValid)
            {
                var data = db.users.Where(x => x.Name.Equals(us.username) && x.Password.Equals(us.password)).FirstOrDefault();
                if (data != null)
                {
                    HttpContext.Session.SetString("user", data.Name);
                    return RedirectToAction("Index", "Books");
                }
                else
                {
                    TempData["InvalidPass"] = "Invalid credentials";
                    return View();
                }
            }
            else
            {
                return View();
            }  
            
        }
        public IActionResult Logout() {
            var d = HttpContext.Session.GetString("user"); 
            if (d!= null)
            {
                HttpContext.Session.Remove("user");
                return RedirectToAction("Login");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        
    }
}
