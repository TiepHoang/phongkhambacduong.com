using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace phongkhambacduong.com.Models
{
    public class Provider
    {
        public static string TrySaveFileAndGetUrl(string nameFile, Controller controller, string pathFolder = "/Image")
        {
            HttpPostedFileBase file = controller.Request.Files[nameFile];
            if (file != null && file.ContentLength > 0 && file.ContentType.Contains("image"))
            {
                string filename = DateTime.Now.ToString("ddMMyyyyhhMMss") + "_" + Path.GetFileName(file.FileName);
                string path = Path.Combine(controller.Server.MapPath("/Image"), filename);
                file.SaveAs(path);
                return pathFolder + "/" + filename;
            }
            return null;
        }
    }
}