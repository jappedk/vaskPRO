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
            String navn = fc["Username"];
            
          
                Bruger temp = Service.findBruger(navn);

            if (temp != null)
            {
                return RedirectToAction("Index", "Home", temp);
            }
            else
            {
                ModelState.AddModelError("LoginError", "Log in incorrect Try again");
                return View();
            }
        }
    }
}