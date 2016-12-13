using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PcPartPickerAsp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string email, string password)
        {
            if(email == null || password == null)
            {
                return View();
            }
            else
            {
                return Redirect("~/Home");
            }
        }
        public ActionResult Login(string email, string password)
        {
            
            return Redirect("~/Home");
        }
    }
}