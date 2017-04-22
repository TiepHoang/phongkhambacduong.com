using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;
using WCF.BussinessObject.EntityObject;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class PhongBanController : Controller
    {
        //
        // GET: /Admin/PhongBan/
        public ActionResult Index()
        {
            return View(new PhongBanBCL().PhongBan_GetAll());
        }

        //
        // GET: /Admin/PhongBan/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/PhongBan/Create
        [HttpPost]
        public ActionResult Create(PhongBanObject obj)
        {
            try
            {
                obj.ID = Guid.NewGuid();
                if (ModelState.IsValid)
                {
                    new PhongBanBCL().PhongBan_Insert(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // GET: /Admin/PhongBan/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(new PhongBanBCL().PhongBan_GetByID(id));
        }

        //
        // POST: /Admin/PhongBan/Edit/5
        [HttpPost]
        public ActionResult Edit(PhongBanObject obj)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    new PhongBanBCL().PhongBan_Update(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // POST: /Admin/PhongBan/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            try
            {
                // TODO: Add delete logic here
                new PhongBanBCL().PhongBan_Delete(id);
                return Json("Thành công");
            }
            catch
            {
                return Json("Thất bại");
            }
        }
    }
}
