using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace Game_Wave.Controllers
{
    public class ImportantWarsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}