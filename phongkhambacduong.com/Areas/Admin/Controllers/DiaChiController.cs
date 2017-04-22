using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;
using WCF.BussinessObject.EntityObject;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class DiaChiController : Controller
    {
        //
        // GET: /Admin/DiaChi/
        public ActionResult Index()
        {
            return View(new DiaChiBCL().DiaChi_GetAll());
        }

        //
        // GET: /Admin/DiaChi/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/DiaChi/Create
        [HttpPost]
        public ActionResult Create(DiaChiObject obj)
        {
            try
            {
                obj.ID = Guid.NewGuid();
                if (ModelState.IsValid)
                {
                    new DiaChiBCL().DiaChi_Insert(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // GET: /Admin/DiaChi/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(new DiaChiBCL().DiaChi_GetByID(id));
        }

        //
        // POST: /Admin/DiaChi/Edit/5
        [HttpPost]
        public ActionResult Edit(DiaChiObject obj)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    new DiaChiBCL().DiaChi_Update(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // POST: /Admin/DiaChi/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            try
            {
                // TODO: Add delete logic here
                new DiaChiBCL().DiaChi_Delete(id);
                return Json("Thành công");
            }
            catch
            {
                return Json("Thất bại");
            }
        }
    }
}
