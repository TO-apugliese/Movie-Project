using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmParadies.Controllers
{
    public class HomeController : Controller
    {
        #region GET
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome";

            return View();
        }
        #endregion

        #region Post
        #endregion
    }
}
