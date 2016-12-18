using System.Web.Mvc;

namespace Epam.TravixTest.WebService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View("Index");
        }
    }
}
