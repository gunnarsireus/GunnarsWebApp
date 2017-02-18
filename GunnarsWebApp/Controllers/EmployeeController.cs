using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GunnarsWebApp.Models;
using GunnarsWebApp.DAL;
using System.Data.Entity.Validation;

namespace GunnarsWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly GunnarsWebAppContext _db = new GunnarsWebAppContext();

        // GET: Employees
        public ActionResult Index()
        {
            return View(_db.Employees.ToList());
        }

        public JsonResult IsUserNameAvailable(string UserName)
        {
            return Json(!_db.Employees.Any(employee => employee.UserName == UserName), JsonRequestBehavior.AllowGet);
        }
        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AddressId, ContactId,FirstName,LastName,UserName")] Employee employee)
        {
            if (!ModelState.IsValid) return View(employee);
            employee.DepartmentId = 1;
            var address = new Address { EmployeeId = employee.Id };
            var contact = new Contact { EmployeeId = employee.Id };
            _db.Employees.Add(employee);
            _db.SaveChanges();
            address.EmployeeId = employee.Id;
            contact.EmployeeId = employee.Id;
            _db.Addresses.Add(address);
            _db.Contacts.Add(contact);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AddressId, ContactId,FirstName,LastName,UserName")] Employee employee)
        {
            if (!ModelState.IsValid) return View(employee);
            _db.Entry(employee).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var employee = _db.Employees.Find(id);
            var addresses = _db.Addresses.Where(a => a.EmployeeId == employee.Id);
            _db.Addresses.RemoveRange(addresses);
            var contacts = _db.Contacts.Where(c => c.EmployeeId == employee.Id);
            _db.Contacts.RemoveRange(contacts);
            _db.Employees.Remove(employee);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
