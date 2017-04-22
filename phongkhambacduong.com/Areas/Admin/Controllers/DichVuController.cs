using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;
using WCF.BussinessObject.EntityObject;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class DichVuController : Controller
    {
        //
        // GET: /Admin/DichVu/
        public ActionResult Index()
        {
            return View(new DichVuBCL().DichVu_GetAll());
        }

        //
        // GET: /Admin/DichVu/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/DichVu/Create
        [HttpPost]
        public ActionResult Create(DichVuObject obj)
        {
            try
            {
                obj.ID = Guid.NewGuid();
                string s = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("Icon", this);
                if (s != null) obj.Icon = s;
                if (ModelState.IsValid)
                {
                    new DichVuBCL().DichVu_Insert(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // GET: /Admin/DichVu/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(new DichVuBCL().DichVu_GetByID(id));
        }

        //
        // POST: /Admin/DichVu/Edit/5
        [HttpPost]
        public ActionResult Edit(DichVuObject obj)
        {
            try
            {
                // TODO: Add update logic here
                string s = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("Icon", this);
                if (s != null) obj.Icon = s;
                if (ModelState.IsValid)
                {
                    new DichVuBCL().DichVu_Update(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // POST: /Admin/DichVu/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            try
            {
                // TODO: Add delete logic here
                new DichVuBCL().DichVu_Delete(id);
                return Json("Thành công");
            }
            catch
            {
                return Json("Thất bại");
            }
        }
    }
}
