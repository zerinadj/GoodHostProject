using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GoodHost.Web.Models.Places;
using System.Web.Mvc;

namespace GoodHost.Web.Controllers
{
    public class PlacesController : Controller
    {
        // GET api/<controller>
        PlaceDBAccessLayer pldb = new PlaceDBAccessLayer();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind] Place places)
        {
            try
            { 
                if (ModelState.IsValid)
                {
                    string resp = pldb.AddPlaceRecord(places);
                    TempData["msg"] = resp;
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View();
        }
    }
    
}