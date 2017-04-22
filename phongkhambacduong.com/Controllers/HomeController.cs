using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessObject.EntityObject;
using WCF.BussinessControler.BCL;

namespace phongkhambacduong.com.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View(new SloganBCL().Slogan_GetAll().FirstOrDefault());
        }

        public ActionResult ParDichVu()
        {
            return PartialView(new DichVuBCL().DichVu_GetAll());
        }

        public ActionResult ParCSVC()
        {
            return PartialView(new CoSoVatChatBCL().CoSoVatChat_GetAll());
        }

        public ActionResult ParBacSi()
        {
            return PartialView(new BacSiBCL().BacSi_GetAll());
        }

        public ActionResult ParDiaChi()
        {
            return PartialView(new DiaChiBCL().DiaChi_GetAll());
        }
        public ActionResult Contac()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult ParMenu()
        {
            return PartialView(new MenuBCL().Menu_GetAll());
        }

        [ChildActionOnly]
        public ActionResult ParHome()
        {
            return PartialView(new SloganBCL().Slogan_GetAll().FirstOrDefault());
        }

        [HttpPost]
        public ActionResult GopY(GopYObject GopY)
        {
            GopY.ThoiGian = DateTime.Now;
            GopY.ID = Guid.NewGuid();
            if (ModelState.IsValid)
            {
                new GopYBCL().GopY_Insert(GopY);
            }
            return RedirectToAction("Index");
        }
    }
}