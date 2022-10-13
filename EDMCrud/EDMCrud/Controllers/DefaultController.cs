﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EDMCrud.EDM;

namespace EDMCrud.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View(dc.tblemployees.ToList());
        }

        public ActionResult Details(int id)
        {
            return View(dc.tblemployees.Find(id));
        }
                
        public ActionResult AddEmp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmp(tblemployee obj)
        {
            dc.tblemployees.Add(obj);
            dc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditEmp(int id)
        {
            return View(dc.tblemployees.Find(id));
        }

        [HttpPost]
        public ActionResult EditEmp(tblemployee obj)
        {
            dc.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteEmp(int id)
        {
            return View(dc.tblemployees.Find(id));
        }

        [HttpPost]
        [ActionName("DeleteEmp")]
        public ActionResult DeleteEmpRec(int id)
        {
            dc.tblemployees.Remove(dc.tblemployees.Find(id));
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}