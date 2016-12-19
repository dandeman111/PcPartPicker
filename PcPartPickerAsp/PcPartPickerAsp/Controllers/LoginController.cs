using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PcPartPickerAsp.DAL.Repository;

namespace PcPartPickerAsp.Controllers
{
    public class LoginController : Controller
    {
        public UserRepo UserRepo { get; private set; }  
        public LoginController()
        {
            UserRepo = new UserRepo();
        }
        // GET: Login
        public ActionResult Index(string email, string password)
        {
            if(email == null || password == null)
            {
               return View();
            }
            else
            {
                Session["username"] = UserRepo.Login(password, email).Username;
                Session["email"] = UserRepo.Login(password, email).Email;
                return Redirect("~/Home");
            }
        }
        public ActionResult Login(string email, string password)
        {
            
            return Redirect("~/Home");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return Redirect("~/Home");
        }
    }
}