using stokApp.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stokApp.Controllers
{
    public class HomeController : Controller
    {
        Musteri musteri = new Musteri();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}