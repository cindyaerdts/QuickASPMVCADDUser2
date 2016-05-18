using System.Web.Mvc;
using QuickASPMVCADDUser2.Models;

namespace QuickASPMVCADDUser2.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = @"SMDC\g-fsc-aducs-a")]
        //[Authorize(Roles = @"SMDC\test-not-authorized")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            ViewBag.Message = "Find and add users";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}