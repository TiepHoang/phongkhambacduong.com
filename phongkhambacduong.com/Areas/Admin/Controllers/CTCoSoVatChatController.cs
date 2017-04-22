using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;
using WCF.BussinessObject.EntityObject;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class CTCoSoVatChatController : Controller
    {
        //
        // GET: /Admin/CTCoSoVatChat/
        public ActionResult Index(Guid ID_CoSoVatChat)
        {
            ViewBag.ID_CoSoVatChat = ID_CoSoVatChat;
            return View(new CTCoSoVatChatBCL().CTCoSoVatChat_GetGroupByID(ID_CoSoVatChat));
        }

        //
        // GET: /Admin/CTCoSoVatChat/Create
        public ActionResult Create(Guid ID_CoSoVatChat)
        {
            ViewBag.ID_CoSoVatChat = ID_CoSoVatChat;
            return View();
        }

        //
        // POST: /Admin/CTCoSoVatChat/Create
        [HttpPost]
        public ActionResult Create(CTCoSoVatChatObject obj)
        {
            ViewBag.ID_CoSoVatChat = obj.ID_CoSoVatChat;
            try
            {
                obj.ID = Guid.NewGuid();
                string s = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("LinkImage", this);
                if (s != null) obj.LinkImage = s;
                if (ModelState.IsValid)
                {
                    new CTCoSoVatChatBCL().CTCoSoVatChat_Insert(obj);
                    return RedirectToAction("Index", new { ID_CoSoVatChat = obj.ID_CoSoVatChat });
                }
            }
            catch { }
            return View();
        }

        //
        // GET: /Admin/CTCoSoVatChat/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.ID_CoSoVatChat = id;
            return View(new CTCoSoVatChatBCL().CTCoSoVatChat_GetByID(id));
        }

        //
        // POST: /Admin/CTCoSoVatChat/Edit/5
        [HttpPost]
        public ActionResult Edit(CTCoSoVatChatObject obj)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    string s = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("LinkImage", this);
                    if (s != null) obj.LinkImage = s;
                    new CTCoSoVatChatBCL().CTCoSoVatChat_Update(obj);
                    return RedirectToAction("Index", new { ID_CoSoVatChat = obj.ID_CoSoVatChat });
                }
            }
            catch { }
            return View(new CTCoSoVatChatBCL().CTCoSoVatChat_GetByID((Guid)obj.ID_CoSoVatChat));
        }

        //
        // POST: /Admin/CTCoSoVatChat/Delete/5
        [HttpPost]
        public JsonResult Delete(Guid id)
        {
            try
            {
                // TODO: Add delete logic here
                new CTCoSoVatChatBCL().CTCoSoVatChat_Delete(id);
                return Json("Thành công");
            }
            catch
            {
                return Json("Thất bại");
            }
        }
    }
}
