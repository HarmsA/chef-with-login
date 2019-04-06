using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using newlogin.Models;

namespace newlogin.Controllers
{
    [Route("posts")]
    public class PostController : Controller
    {
        private int? UserSession
        {
            get{ return HttpContext.Session.GetInt32("UserId");}
            set{ HttpContext.Session.SetInt32("UserId", (int)value);}
        }

        private DashboardVM DashViewModel
        {
            get 
            { return new DashboardVM()
                {
                    AllPosts = dbContext.Posts.Include(p => p.Chef).ToList()
                    
                };
            }
        }
        private UserContext dbContext;
        public PostController(UserContext context)
        {
            dbContext = context;
        }

        //localhost:5000/posts/details
        [Route("details")]
        [HttpGet]
        public IActionResult PostDetails()
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

                return RedirectToAction("HomePage");
            }
            return View("AddChef");
        }

        [HttpGet("home")]
        public IActionResult HomePage()
        {
            if(UserSession == null)
                return RedirectToAction("Index", "Home");
            // User loggedinUser = UserSession.FirstOrDefault(u => u.UserId == UserSession);
            // ViewBag.AllPosts = dbContext.Posts.Include(p => p.Chef);
            ViewBag.AllChefs = dbContext.Users.Include(u => u.Dishlist);
            return View(DashViewModel);
        }

        [HttpGet("addChef")]
        public IActionResult AddChef()
        {
            return View();
        }

        [HttpGet("createDish")]
        public IActionResult CreateDish()
        {
            return View();
        }

        [HttpPost("dishcreator")]
        public IActionResult DishCreator(Post newDish)
        {
            if(ModelState.IsValid)
            {
                newDish.UserId = (int)UserSession;
                dbContext.Posts.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("HomePage");
            }
            return View("CreateDish"); 
        }

        [HttpGet("dishes")]
        public IActionResult dishList()
        {
            return View(DashViewModel); 
        }
    }
}
