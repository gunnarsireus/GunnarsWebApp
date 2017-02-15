using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GunnarsWebApp.DAL;
using GunnarsWebApp.Models;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace GunnarsWebApp.Controllers
{
    public class XmlController : Controller
    {
        private GunnarsWebAppContext db = new GunnarsWebAppContext();


        // GET: Xml
        public ActionResult Index()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SubmissionModelCollection));
            StreamReader reader = new StreamReader(@"C:\Users\gunna\Documents\GitHub\GunnarsWebApp\GunnarsWebApp\Resources\AllSubmissions.xml");
            SubmissionModelCollection subs = (SubmissionModelCollection)serializer.Deserialize(reader);
            reader.Close();

            return View(subs.Submissions.SubmissionModel);
        }

        // GET: Xml/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubmissionModel submissionModel = db.SubmissionModels.Find(id);
            if (submissionModel == null)
            {
                return HttpNotFound();
            }
            return View(submissionModel);
        }

        // GET: Xml/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Xml/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ListIndexID,SubmissionDate,ProjectType,Name,Email,Address,PostalCode,City,PhoneNumber,ProjectName,ProjectDescription,ProjectWebSiteURL,ProjectFilePath,ProjectFileName")] SubmissionModel submissionModel)
        {
            if (ModelState.IsValid)
            {
                db.SubmissionModels.Add(submissionModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(submissionModel);
        }

        // GET: Xml/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubmissionModel submissionModel = db.SubmissionModels.Find(id);
            if (submissionModel == null)
            {
                return HttpNotFound();
            }
            return View(submissionModel);
        }

        // POST: Xml/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ListIndexID,SubmissionDate,ProjectType,Name,Email,Address,PostalCode,City,PhoneNumber,ProjectName,ProjectDescription,ProjectWebSiteURL,ProjectFilePath,ProjectFileName")] SubmissionModel submissionModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(submissionModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(submissionModel);
        }

        // GET: Xml/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubmissionModel submissionModel = db.SubmissionModels.Find(id);
            if (submissionModel == null)
            {
                return HttpNotFound();
            }
            return View(submissionModel);
        }

        // POST: Xml/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SubmissionModel submissionModel = db.SubmissionModels.Find(id);
            db.SubmissionModels.Remove(submissionModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
