using MillenniumWebApplication.Models;
using System.Web.Mvc;

namespace MillenniumWebApplication.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            var model = new UserViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult AddUser(UserViewModel model)
        {
            return RedirectToAction("ShowUser", model);
        }

        public ActionResult ShowUser(UserViewModel model)
        {
            return View(model);
        }
    }
}