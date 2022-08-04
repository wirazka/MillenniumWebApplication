using System;
using System.Web;
using System.Web.Mvc;

namespace MillenniumWebApplication.Controllers
{
    public class LanguageController : BaseController
    {
        public ActionResult Set(string language)
        {
            var cookie = new HttpCookie("lang");
            cookie.Value = language;
            cookie.Expires = DateTime.Now.AddDays(365);
            Response.Cookies.Add(cookie);

            return RedirectToAction("Index", "Home");
        }
    }
}