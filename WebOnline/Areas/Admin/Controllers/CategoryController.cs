using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebOnline.Models;
using WebOnline.Models.EF;

namespace WebOnline.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public static CategoryController instance;
        public static readonly object instanceLock = new object();
        public static CategoryController Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryController();
                    }
                    return instance;
                }
            }
        }
        // GET: Admin/Category

        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var items = db.Categories;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model)
        {
            if(ModelState.IsValid)
            {
                model.CreateDate = DateTime.Now;
                model.ModfiedDate = DateTime.Now;
                model.Alias = WebOnline.Models.Common.Filter.FilterChar(model.Title);
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var item = db.Categories.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Attach(model);
                model.ModfiedDate = DateTime.Now;
                model.Alias = WebOnline.Models.Common.Filter.FilterChar(model.Title);
                db.Entry(model).Property(x => x.Title).IsModified = true;
                db.Entry(model).Property(x => x.Descriptione).IsModified = true;
                db.Entry(model).Property(x => x.Alias).IsModified = true;
                db.Entry(model).Property(x => x.SeoDescriptione).IsModified = true;
                db.Entry(model).Property(x => x.SeoKeywords).IsModified = true;
                db.Entry(model).Property(x => x.SeoTitle).IsModified = true;
                db.Entry(model).Property(x => x.Position).IsModified = true;
                db.Entry(model).Property(x => x.ModfiedDate).IsModified = true;
                db.Entry(model).Property(x => x.Modfiedby).IsModified = true;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Categories.Find(id);
            if(item != null)
            {
                /*var DeleteItem=db.Categories.Attach(item);*/
                db.Categories.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}