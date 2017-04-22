using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;
using WCF.BussinessObject.EntityObject;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Admin/Menu/
        public ActionResult Index()
        {
            return View(new MenuBCL().Menu_GetAll());
        }

        //
        // GET: /Admin/Menu/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/Menu/Create
        [HttpPost]
        public ActionResult Create(MenuObject obj)
        {
            try
            {
                obj.ID = Guid.NewGuid();
                if (ModelState.IsValid)
                {
                    new MenuBCL().Menu_Insert(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // GET: /Admin/Menu/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(new MenuBCL().Menu_GetByID(id));
        }

        //
        // POST: /Admin/Menu/Edit/5
        [HttpPost]
        public ActionResult Edit(MenuObject obj)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    new MenuBCL().Menu_Update(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // POST: /Admin/Menu/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            try
            {
                // TODO: Add delete logic here
                new MenuBCL().Menu_Delete(id);
                return Json("Thành công");
            }
            catch
            {
                return Json("Thất bại");
            }
        }
    }
}
