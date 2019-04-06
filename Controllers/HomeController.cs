using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using newlogin.Models;

namespace newlogin.Controllers
{
    public class HomeController : Controller
    {
        private int? UserSession
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
            set { HttpContext.Session.SetInt32("UserId", (int)value); }
        }
        private UserContext dbContext;
        public HomeController(UserContext context)
        {
            dbContext = context;
        }
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already exitst.");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                string hashedPW = hasher.HashPassword(newUser, newUser.Password);
                newUser.Password = hashedPW;

                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();

                UserSession = newUser.UserId;
                return RedirectToAction("PostDetails", "Post");
            }
            return View("Index");
        }

        [HttpGet("login")]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost("verifyLogin")]
        public IActionResult VerifyLogin(LoginUser loginUser)
        {
            if(ModelState.IsValid)
            {
                User userlogin = dbContext.Users.FirstOrDefault(u => u.Email == loginUser.LogEmail);
                if(userlogin == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                    var result = hasher.VerifyHashedPassword(loginUser, userlogin.Password, loginUser.LogPassword);

                    if(result == 0)
                    {
                        ModelState.AddModelError("Email", "Invalid Email/Password");
                        return View("Index");
                    }
                    // Log them in with session
                    UserSession = userlogin.UserId;
                    return RedirectToAction("HomePage", "Post");
                }
            }
            return View("Index");
        }

        [HttpGet("HomePage")]
        public IActionResult HomePage()
        {
            // User loggedinUser = UserSession.FirstOrDefault(u => u.UserId == UserSession);
            return View();
        }
    }
}
