using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace GoodHost.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : GoodHostControllerBase
    {
        public ActionResult Index()
        {
            if (User.IsInRole("User"))
            {
                return RedirectToAction("UsersHome", "UserLog");
            }
            return View();
        }
	}
}