using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DemoEntity.Models;

namespace DemoEntity.Controllers
{
    public class ProgressLogsController : Controller
    {
        private OV_DSPEntities db = new OV_DSPEntities();

        // GET: ProgressLogs
        public ActionResult Index()
        {
            return View(db.ProgressLogs.ToList());
        }

		public ActionResult Index2()
		{
			return View(db.ProgressLogs.ToList());
		}

		public ActionResult Index3()
		{
			return View(db.ProgressLogs.ToList());
		}

		// GET: ProgressLogs/Details/5
		public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgressLog progressLog = db.ProgressLogs.Find(id);
            if (progressLog == null)
            {
                return HttpNotFound();
            }
            return View(progressLog);
        }

        // GET: ProgressLogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProgressLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProgressId,ShiftId,PrimaryLine,CompletedDate,CompletedHour,Counts,EquivalentCount,CumulativeCount,Issue,Comment,EntDate")] ProgressLog progressLog)
        {
            if (ModelState.IsValid)
            {
                db.ProgressLogs.Add(progressLog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(progressLog);
        }

        // GET: ProgressLogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgressLog progressLog = db.ProgressLogs.Find(id);
            if (progressLog == null)
            {
                return HttpNotFound();
            }
            return View(progressLog);
        }

        // POST: ProgressLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProgressId,ShiftId,PrimaryLine,CompletedDate,CompletedHour,Counts,EquivalentCount,CumulativeCount,Issue,Comment,EntDate")] ProgressLog progressLog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(progressLog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(progressLog);
        }

        // GET: ProgressLogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProgressLog progressLog = db.ProgressLogs.Find(id);
            if (progressLog == null)
            {
                return HttpNotFound();
            }
            return View(progressLog);
        }

        // POST: ProgressLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProgressLog progressLog = db.ProgressLogs.Find(id);
            db.ProgressLogs.Remove(progressLog);
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
