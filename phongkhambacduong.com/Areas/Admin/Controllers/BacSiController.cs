using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;
using WCF.BussinessObject.EntityObject;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class BacSiController : Controller
    {
        //
        // GET: /Admin/BacSi/
        public ActionResult Index()
        {
            return View(new BacSiBCL().BacSi_GetAll());
        }

        //
        // GET: /Admin/BacSi/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/BacSi/Create
        [HttpPost]
        public ActionResult Create(BacSiObject obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    obj.ID = Guid.NewGuid();
                    var image = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("LinkImage", this);
                    if (image != null) obj.LinkImage = image;
                    new BacSiBCL().BacSi_Insert(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // GET: /Admin/BacSi/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(new BacSiBCL().BacSi_GetByID(id));
        }

        //
        // POST: /Admin/BacSi/Edit/5
        [HttpPost]
        public ActionResult Edit(BacSiObject obj)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var image = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("LinkImage", this);
                    if (image != null) obj.LinkImage = image;
                    new BacSiBCL().BacSi_Update(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View(new BacSiBCL().BacSi_GetByID(obj.ID));
        }

        //
        // POST: /Admin/BacSi/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            try
            {
                // TODO: Add delete logic here
                new BacSiBCL().BacSi_Delete(id);
                return Json("Thành công");
            }
            catch
            {
                return Json("Thất bại");
            }
        }
    }
}
