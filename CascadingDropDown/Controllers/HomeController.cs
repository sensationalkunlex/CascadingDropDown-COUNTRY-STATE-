using CascadingDropDown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingDropDown.Controllers
{
    public class HomeController : Controller
    {

        Model db = new Model();
        public ActionResult Index()
        {
            List<Country> countryList = db.country.ToList();
            ViewBag.CountryList = new SelectList(countryList, "CountryID", "CountryName");


            
            return View();
        }
        public ActionResult GetStateList(int countryID) {
            db.Configuration.ProxyCreationEnabled = false;
            List<State> stateList = db.state.Where(m => m.CountryID == countryID).ToList();
            return Json(stateList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}