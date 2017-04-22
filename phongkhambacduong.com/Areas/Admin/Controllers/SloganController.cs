using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;
using WCF.BussinessObject.EntityObject;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class SloganController : Controller
    {
        //
        // GET: /Admin/Slogan/
        public ActionResult Index()
        {
            return View(new SloganBCL().Slogan_GetAll().FirstOrDefault());
        }
        //
        // POST: /Admin/Slogan/Index/5
        [HttpPost]
        public ActionResult Index(SloganObject obj)
        {
            try
            {
                // TODO: Add update logic here
                var s = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("ImageGioiThieu", this);
                if (s != null) obj.ImageGioiThieu = s;
                s = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("ImagePage", this);
                if (s != null) obj.ImagePage = s;
                s = phongkhambacduong.com.Models.Provider.TrySaveFileAndGetUrl("LogoPage", this);
                if (s != null) obj.LogoPage = s;
                if (ModelState.IsValid)
                {
                    new SloganBCL().Slogan_Update(obj);
                    ModelState.AddModelError("Result", "Thành công");
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Result", ex.Message);
            }
            return View();
        }
    }
}
