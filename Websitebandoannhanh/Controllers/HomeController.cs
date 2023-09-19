using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Websitebandoannhanh.Models;
using Websitebandoannhanh.Models.EF;

namespace Websitebandoannhanh.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Partial_Subcribe()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Subcribe(Subcribe req)
        {
            if (ModelState.IsValid)
            {
                db.Subcribes.Add(new Subcribe { Email = req.Email, CreateDate = DateTime.Now });
                db.SaveChanges();
                return Json(new { Success = true});
            }
            return View("Partial_Subcribe", req);
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