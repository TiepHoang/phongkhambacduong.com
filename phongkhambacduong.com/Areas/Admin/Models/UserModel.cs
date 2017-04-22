using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF.BussinessControler.BCL;

namespace phongkhambacduong.com.Areas.Admin.Models
{
    public class UserModel
    {
        string nameSession = "Login";
        public static string nameCookiesLogin = "User_Username";

        public void SetSession(UserObject ob)
        {
            HttpContext.Current.Session[nameSession] = ob;
        }

        public UserObject GetSession()
        {
            var ob = HttpContext.Current.Session[nameSession];
            if (ob == null) return null;
            return ob as UserObject;
        }

        public void ClearSession()
        {
            SetSession(null);
        }

        public bool CheckLogin(string Username, string Password)
        {
            var ob = new AccountBCL().Account_GetByID(Username);
            return ob != null && ob.Password != null && phongkhambacduong.com.Models.iMD5.Vietify(Password, ob.Password);
        }

        public UserObject GetUserObjectInCookie()
        {
            var ck = HttpContext.Current.Request.Cookies[nameCookiesLogin];
            if (ck == null) return null;
            string valueCookie = HttpContext.Current.Server.UrlDecode(ck.Value);
            return JsonConvert.DeserializeObject<UserObject>(valueCookie);
        }

        public void SetCookieUserObject(UserObject obj)
        {
            var jsonUser = JsonConvert.SerializeObject(obj);
            string cookieValue = HttpContext.Current.Server.UrlEncode(jsonUser);
            HttpCookie cookie = new HttpCookie(nameCookiesLogin, cookieValue)
            {
                Expires = DateTime.Now.AddDays(10)
            };
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}