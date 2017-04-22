using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;
using WCF.BussinessObject.EntityObject;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class CoSoVatChatController : Controller
    {
        //
        // GET: /Admin/CoSoVatChat/
        public ActionResult Index()
        {
            return View(new CoSoVatChatBCL().CoSoVatChat_GetAll());
        }

        //
        // GET: /Admin/CoSoVatChat/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/CoSoVatChat/Create
        [HttpPost]
        public ActionResult Create(CoSoVatChatObject obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    obj.ID = Guid.NewGuid();
                    string r = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("LinkImage", this);
                    if (r != null) obj.LinkImage = r;
                    new CoSoVatChatBCL().CoSoVatChat_Insert(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // GET: /Admin/CoSoVatChat/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(new CoSoVatChatBCL().CoSoVatChat_GetByID(id));
        }

        //
        // POST: /Admin/CoSoVatChat/Edit/5
        [HttpPost]
        public ActionResult Edit(CoSoVatChatObject obj)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    string r = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("LinkImage", this);
                    if (r != null) obj.LinkImage = r;
                    new CoSoVatChatBCL().CoSoVatChat_Update(obj);
                    return RedirectToAction("Index");
                }
            }
            catch
            { }
            return View(new CoSoVatChatBCL().CoSoVatChat_GetByID(obj.ID));
        }

        //
        // POST: /Admin/CoSoVatChat/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            try
            {
                // TODO: Add delete logic here
                new CoSoVatChatBCL().CoSoVatChat_Delete(id);
                return Json("Thành công");
            }
            catch
            {
                return Json("Thất bại");
            }
        }
    }
}
