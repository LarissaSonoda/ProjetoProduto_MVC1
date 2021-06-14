using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;
using ProjetoPoduto.Models;
using System.Web.Mvc;

namespace ProjetoPoduto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var produto = new Produto();
            return View(produto);
        }
        [HttpPost]
        public ActionResult Index(Produto produto)
        {
            if (ModelState.IsValid)
            {
                return View("Info", produto);
            }
            return View(produto);
        }
        public ActionResult Info(Produto produto)
        {
            return View(produto);
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