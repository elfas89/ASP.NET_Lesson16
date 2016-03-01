using Less_16.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Less_16.Controllers
{
    public class EmployeeController : Controller
    {

        private EmployeeContext db = new EmployeeContext();
        
        
        // GET: Employee

        public ActionResult Index()
        {
            return View(db.Employees);
        }

        public ActionResult IndexDetail(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            Employee b = db.Employees.Find(id);
            if (b == null) { return HttpNotFound(); }
            return View(b);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee b)
        {
            db.Employees.Add(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            Employee b = db.Employees.Find(id);
            if (b == null) { return HttpNotFound(); }
            return View(b);
        }
        [HttpPost]
        public ActionResult Edit(Employee b)
        {
            db.Entry(b).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        //public ActionResult Delete(int? id)
        //{
        //    if (id == null) { return HttpNotFound(); }
        //    Employee b = db.Employees.Find(id);
        //    if (b != null)
        //    {
        //        db.Employees.Remove(b);
        //        db.SaveChanges();
        //    }
        //    return RedirectToAction("Index");
        //}

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            Employee b = db.Employees.Find(id);
            if (b == null) { return HttpNotFound(); }
            return View(b);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee b = db.Employees.Find(id);
            db.Employees.Remove(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}