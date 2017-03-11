using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PCPlumbing.Models;
using System.IO;
using PCPlumbing.Security;

namespace PCPlumbing.Controllers
{
    public class ImagesController : Controller
    {

        private PCPlumbingContext db = new PCPlumbingContext();

        // GET: Images
        public ActionResult Index()
        {
            
            return View(db.Images.ToList());
            
        }

        // GET: Images/Create
        public ActionResult Create()
        {
            if (SessionPersister.Username != null)
                return View();
            return RedirectToAction("AccessDenied", "Admins");
        }

        // POST: Images/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Image,ImageName,ImageDescription")] Images images)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    var file = Request.Files[0];
                    if (file != null && file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("../Content/Images/Gallery"), fileName);

                        //if file doesn't already exist
                        string pathToString = path.ToString();
                        string imageLocation = "\\Content\\Images\\Gallery";
                        int pathIndex = pathToString.IndexOf(imageLocation);
                        string imagePathToSave = pathToString.Substring(pathIndex);

                        if (db.Images.Where(im => im.Image.Equals(imagePathToSave)).FirstOrDefault() != null)
                        {
                            ViewBag.Error = "An image with this name already exists.";
                            return View("Create");
                        }

                        images.Image = imagePathToSave;

                        file.SaveAs(path);
                        db.Images.Add(images);
                        db.SaveChanges();
                        ModelState.Clear();
                        ViewBag.Success = "Image successfully added";
                        return View("Create");
                    }
                }
            }
            return View(images);
        }

        public ActionResult Details()
        {
            if (SessionPersister.Username != null)
                return View(db.Images.ToList());
            return RedirectToAction("AccessDenied", "Admins");
        }

        // GET: Images/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Images image = db.Images.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View(image);
        }

        // POST: Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Images images = db.Images.Find(id);
            string imagePath = db.Images.Find(id).Image;

            var path = HttpContext.Server.MapPath(imagePath);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            db.Images.Remove(images);
            db.SaveChanges();
            return RedirectToAction("Details");
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
