using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace phongkhambacduong.com.Helper
{
    public static class StringHelper
    {
        public static IHtmlString SubString(this HtmlHelper help, string data, int indexStart, int length)
        {
            if (data == null || data.Length <= length) return new HtmlString(data);
            return new HtmlString(data.Substring(indexStart, length) + "...");
        }
    }
}