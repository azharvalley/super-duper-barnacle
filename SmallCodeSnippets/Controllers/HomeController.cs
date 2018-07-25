using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmallCodeSnippets.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PaginationOnPageScroll()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetPagesContent(int pageIndex = 0)
        {
            var Posts = "";
            int first = pageIndex + 1;
            int last = pageIndex + 9;
            string htmllist = "";
            for (int i = first; i <= last; i++)
            {

                htmllist = htmllist + "<div class=\"col-sm-4\" style=\"padding: 10px 10px 10px 10px;\"><strong>Product: " + i + "</strong>";
                htmllist = htmllist + "<img src=\"/images/" + i + ".png\" >";
                htmllist = htmllist + "</div>";
            }
            htmllist = htmllist + "<br><hr>";
            Posts = htmllist;

            //Delaying the code so that we can we can view the loading process.
            int milliseconds = 2000;
            System.Threading.Thread.Sleep(milliseconds);

            return Json(Posts, JsonRequestBehavior.AllowGet);
        }
    }
}