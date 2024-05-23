using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace Game_Wave.Controllers
{
    public class AboutUsController : Controller
    {
        DataContext db = new DataContext();

        public ActionResult Index(int sayfa = 1)
        {
            return View();
        }
    }
}