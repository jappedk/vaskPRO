using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VaskeWEB.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            String name = fc["Username"];
            
            try
            {
                Bruger temp = Service.valiDateLogin(name);
                return RedirectToAction("Index", "Home", temp);
            }
            catch
            {
                ModelState.AddModelError("LoginError", "Log in incorrect Try again");
                return View();
            }
        }
    }
}