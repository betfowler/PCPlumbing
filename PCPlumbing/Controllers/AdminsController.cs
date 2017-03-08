using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PCPlumbing.Models;
using PCPlumbing.ViewModels;
using Microsoft.AspNet.Identity;
using PCPlumbing.Security;

namespace PCPlumbing.Controllers
{
    public class AdminsController : Controller
    {
        private PCPlumbingContext db = new PCPlumbingContext();

        // GET: Admins
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AccessDenied()
        {
            return View();
        }

        // GET: Admins/Create
        public ActionResult Create()
        {
            if (SessionPersister.Username != null)
                return View();
            return RedirectToAction("AccessDenied", "Admins");
        }

        // POST: Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdminID,Username,Password")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                admin.Password = Hashing.ComputeHash(admin.Password);
                db.Admins.Add(admin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(admin);
        }
        
        [HttpPost]
        public ActionResult Login(AdminViewModel avm, AdminModel am)
        {
            if(string.IsNullOrEmpty(avm.Admin.Username) || string.IsNullOrEmpty(avm.Admin.Password) || am.login(avm.Admin.Username, avm.Admin.Password) == false)
            {
                ViewBag.Error = "Log in details invalid";
                return View("Index");
            }
            SessionPersister.Username = avm.Admin.Username;
            return RedirectToAction("Create","Images");
        }

        [OutputCache(NoStore = true, Duration = 0)]
        public ActionResult Logout()
        {
            SessionPersister.Username = null;
            return RedirectToAction("Index", "Home");
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
