using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;
using WCF.BussinessObject.EntityObject;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class PositionController : Controller
    {
        //
        // GET: /Admin/Position/
        public ActionResult Index()
        {
            return View(new PositionBCL().Position_GetAll());
        }

        //
        // GET: /Admin/Position/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/Position/Create
        [HttpPost]
        public ActionResult Create(PositionObject obj)
        {
            try
            {
                obj.ID = Guid.NewGuid();
                if (ModelState.IsValid)
                {
                    new PositionBCL().Position_Insert(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // GET: /Admin/Position/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(new PositionBCL().Position_GetByID(id));
        }

        //
        // POST: /Admin/Position/Edit/5
        [HttpPost]
        public ActionResult Edit(PositionObject obj)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    new PositionBCL().Position_Update(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // POST: /Admin/Position/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            try
            {
                // TODO: Add delete logic here
                new PositionBCL().Position_Delete(id);
                return Json("Thành công");
            }
            catch
            {
                return Json("Thất bại");
            }
        }
    }
}
