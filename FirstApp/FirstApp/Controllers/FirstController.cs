using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        
        public ActionResult Empdata()
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid=1, fname="Shivani", email="s@gmail.com" });
            li.Add(new Employee { empid=2, fname="Mit", email="m@gmail.com" });
            li.Add(new Employee { empid=3, fname="Jayesh", email="j@gmail.com" });
            li.Add(new Employee { empid=4, fname="Jenees", email="j@gmail.com" });

            return View(li);
        }
    }
}