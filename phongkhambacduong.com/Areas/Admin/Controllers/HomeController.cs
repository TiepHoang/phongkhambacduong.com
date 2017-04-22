using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF.BussinessControler.BCL;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Admin/HomeAdmin/
        public ActionResult Index()
        {
            return View(new GopYBCL().GopY_GetAll().Take(10));
        }
    }
}