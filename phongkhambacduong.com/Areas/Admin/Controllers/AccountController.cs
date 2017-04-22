using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;
using WCF.BussinessObject.EntityObject;
using System.Security.Cryptography;
using phongkhambacduong.com.Models;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Admin/Account/
        public ActionResult Index()
        {
            return View(new AccountBCL().Account_GetAll());
        }

        //
        // GET: /Admin/Account/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/Account/Create
        [HttpPost]
        public ActionResult Create(AccountObject obj, FormCollection fCollection)
        {
            try
            {
                var rePass = fCollection["rePassword"];
                if (rePass == null || !rePass.Equals(obj.Password))
                {
                    ModelState.AddModelError("messageRePassword", "Nhập khẩu không trùng khớp!");
                }
                else
                {
                    var s = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("Avatar", this);
                    if (s != null) obj.Avatar = s;
                    if (ModelState.IsValid)
                    {
                        obj.Password = iMD5.GetMD5Hash(obj.Password);
                        new AccountBCL().Account_Insert(obj);
                        return RedirectToAction("Index");
                    }
                }
            }
            catch { }
            return View();
        }

        //
        // GET: /Admin/Account/Edit/5
        public ActionResult Edit(string username)
        {
            return View(new AccountBCL().Account_GetByID(username));
        }

        //
        // POST: /Admin/Account/Edit/5
        [HttpPost]
        public ActionResult Edit(AccountObject obj)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var s = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("Avatar", this);
                    if (s != null) obj.Avatar = s;
                    obj.Password = iMD5.GetMD5Hash(obj.Password);
                    new AccountBCL().Account_Update(obj);
                    return RedirectToAction("Index");
                }
            }
            catch { }
            return View();
        }

        //
        // POST: /Admin/Account/Delete/5
        [HttpPost]
        public JsonResult Delete(string username)
        {
            try
            {
                // TODO: Add delete logic here
                new AccountBCL().Account_Delete(username);
                return Json("Thành công");
            }
            catch
            {
                return Json("Thất bại");
            }
        }
    }
}
