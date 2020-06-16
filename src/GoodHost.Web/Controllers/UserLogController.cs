using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodHost.Web.Controllers
{
    public class UserLogController : Controller
    {
        // GET: Profile
        public new ActionResult Profile()
        {
            return View();
        }
        //GET: CreateOffer
        public ActionResult CreateOffer()
        {
            return View();
        }
    }
}