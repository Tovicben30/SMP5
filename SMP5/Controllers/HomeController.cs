using SMP5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMP5.Controllers
    
{
    
    public class HomeController : Controller
    
    {
        
        public ActionResult Action()
        {
            return View();
        }

        public ViewResult Index()
        {

            ViewBag.Greeting = "Welcome";
            return View();
        }

       
        [HttpGet]
        public ViewResult JoinForm()
        {
            return View();
        }

        [HttpPost]
        
        public ViewResult JoinForm( UserResponse userResponse)
        {
            if(ModelState.IsValid)
            {

                return View("Thanks", userResponse);

            }
            else
            {
                return View();
            }





        }

        [NonAction]
        public bool IsEmailExist(string Email)
        {
            using (UserDatabaseEntities dc = new UserDatabaseEntities())
            {
                var t = dc.Users.Where(a => a.EmailID == Email).FirstOrDefault();
                return t != null;
            }
        }

    }
   
}