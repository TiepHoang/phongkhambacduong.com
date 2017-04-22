using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;
using WCF.BussinessObject.EntityObject;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class SanPhamController : Controller
    {
        //
        // GET: /Admin/SanPham/
        public ActionResult Index()
        {
            return View(new SanPhamBCL().SanPham_GetAll());
        }

        //
        // GET: /Admin/SanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/SanPham/Create
        [HttpPost]
        public ActionResult Create(SanPhamObject obj)
        {
            try
            {
                obj.ID = Guid.NewGuid();
                string s = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("LinkImage", this);
                if (s != null) obj.LinkImage = s;
                if (ModelState.IsValid)
                {
                    new SanPhamBCL().SanPham_Insert(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // GET: /Admin/SanPham/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(new SanPhamBCL().SanPham_GetByID(id));
        }

        //
        // POST: /Admin/SanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(SanPhamObject obj)
        {
            try
            {
                // TODO: Add update logic here
                string s = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("LinkImage", this);
                if (s != null) obj.LinkImage = s;
                if (ModelState.IsValid)
                {
                    new SanPhamBCL().SanPham_Update(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // POST: /Admin/SanPham/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            try
            {
                // TODO: Add delete logic here
                new SanPhamBCL().SanPham_Delete(id);
                return Json("Thành công");
            }
            catch
            {
                return Json("Thất bại");
            }
        }
    }
}
