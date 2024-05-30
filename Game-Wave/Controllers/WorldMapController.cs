using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace Game_Wave.Controllers
{
    public class WorldMapController : Controller
    {
        // GET: Admin

        DataContext db = new DataContext();
        public ActionResult Index(int? p)
        {
            var user = db.WorldToWorlds.ToList();

            if (p != 0)
            {
                var value = db.WorldToWorlds.Where(x => x.warDate == p).ToList();

                return View(value);
            }

            return View(user);
        }

        public ActionResult countryDetails()
        {
            var user = db.WorldCountries.Where(x => x.Id == 1).ToList();

            return View(user);
        }

        public ActionResult threeDMap() 
        {
            return View();
        }
    }
}