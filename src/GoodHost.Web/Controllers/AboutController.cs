using System.Web.Mvc;

namespace GoodHost.Web.Controllers
{
    public class AboutController : GoodHostControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}