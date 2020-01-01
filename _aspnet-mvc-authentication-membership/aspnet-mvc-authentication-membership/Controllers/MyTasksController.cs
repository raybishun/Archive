using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using aspnet_mvc_authentication_membership.Models;

namespace aspnet_mvc_authentication_membership.Controllers
{
    public class MyTasksController : Controller
    {
        private JiraLiteDataContext db = new JiraLiteDataContext();

        // GET: MyTasks
        public ActionResult Index()
        {
            var myTasks = db.MyTasks.Include(m => m.Priority);
            return View(myTasks.ToList());
        }

        // GET: MyTasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyTask myTask = db.MyTasks.Find(id);
            if (myTask == null)
            {
                return HttpNotFound();
            }
            return View(myTask);
        }

        // GET: MyTasks/Create
        public ActionResult Create()
        {
            ViewBag.TaskPriority = new SelectList(db.Priorities, "PriorityId", "PriorityDesc");
            return View();
        }

        // POST: MyTasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaskId,TaskSummary,TaskDesc,TaskDue,TaskReporter,TaskAssignee,TaskPriority")] MyTask myTask)
        {
            if (ModelState.IsValid)
            {
                db.MyTasks.Add(myTask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TaskPriority = new SelectList(db.Priorities, "PriorityId", "PriorityDesc", myTask.TaskPriority);
            return View(myTask);
        }

        // GET: MyTasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyTask myTask = db.MyTasks.Find(id);
            if (myTask == null)
            {
                return HttpNotFound();
            }
            ViewBag.TaskPriority = new SelectList(db.Priorities, "PriorityId", "PriorityDesc", myTask.TaskPriority);
            return View(myTask);
        }

        // POST: MyTasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaskId,TaskSummary,TaskDesc,TaskDue,TaskReporter,TaskAssignee,TaskPriority")] MyTask myTask)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myTask).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TaskPriority = new SelectList(db.Priorities, "PriorityId", "PriorityDesc", myTask.TaskPriority);
            return View(myTask);
        }

        // GET: MyTasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyTask myTask = db.MyTasks.Find(id);
            if (myTask == null)
            {
                return HttpNotFound();
            }
            return View(myTask);
        }

        // POST: MyTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyTask myTask = db.MyTasks.Find(id);
            db.MyTasks.Remove(myTask);
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
