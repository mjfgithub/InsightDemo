using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsightWeb.Controllers
{
    public class HomeController : Controller
    {

       

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            var movies = new List<object>();

            movies.Add(new { Title = "Ghostbusters", Genre = "Comedy", Year = 1984 });
            movies.Add(new { Title = "Gone with Wind", Genre = "Drama", Year = 1939 });
            movies.Add(new { Title = "Star Wars", Genre = "Science Fiction", Year = 1977 });

            return Json(movies, JsonRequestBehavior.AllowGet);


            //return View();
        }
    }
}
