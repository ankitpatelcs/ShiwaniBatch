using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Statemanagement.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            string uname = fc["txtuname"];
            string pass = fc["txtpass"];

            if (uname=="shivani" && pass=="s123")
            {
                HttpCookie coUname = new HttpCookie("uname");
                coUname.Value = uname;
                coUname.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(coUname);

                HttpCookie coPass = new HttpCookie("pass");
                coPass.Value = pass;
                coUname.Expires= DateTime.Now.AddDays(2);
                Response.Cookies.Add(coPass);
            }

            return View();
        }

        public ActionResult SendMsg(string name)
        {
            ViewBag.msg = name;
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string uname = fc["txtuname"];
            string pass = fc["txtpass"];

            if (uname == "shivani" && pass == "s123")
            {
                Session["username"] = uname;
                Session["password"] = pass;
                Session.Timeout = 30;
                return RedirectToAction("Homepage");
            }
            ViewBag.loginerror = "Invalid Username or password";
            return View();
        }

        public ActionResult Homepage()
        {
            return View();
        }
        
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }

        public ActionResult svar()
        {
            ViewBag.msg = "calling ViewBag message";
            ViewData["message"] = "calling ViewData message";
            TempData["info"] = "calling TempData message";

            return View();
        }
        public ActionResult second()
        {            
            return View();
        }
    }
}