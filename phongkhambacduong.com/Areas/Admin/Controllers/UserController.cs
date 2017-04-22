using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using phongkhambacduong.com.Areas.Admin.Models;

namespace phongkhambacduong.com.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /Admin/User/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.UserObject user)
        {
            if (ModelState.IsValid)
            {
                if (new UserModel().CheckLogin(user.Username, user.Password))
                {
                    new Models.UserModel().SetSession(user);
                    string nameCookiesLogin = UserModel.nameCookiesLogin;
                    if (user.Remember)
                    {
                        new UserModel().SetCookieUserObject(user);
                    }
                    else
                    {
                        if (Request.Cookies[nameCookiesLogin] != null) Response.Cookies[nameCookiesLogin].Expires = DateTime.Now.AddDays(-1);
                    }
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không chính xác, xin thử lại!");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            new UserModel().ClearSession();
            return RedirectToAction("Index");
        }
    }
}