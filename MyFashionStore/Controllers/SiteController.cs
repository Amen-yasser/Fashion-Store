using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFashionStore.Models;

namespace MyFashionStore.Controllers
{
    public class SiteController : Controller
    {
        FashionContext db = new FashionContext();
        // GET: Site
        public ActionResult Home()
        {
            List<Product> product = db.Products.ToList();
            Product offer = db.Products.Where(n => n.product_photo == "offer.jpg").SingleOrDefault();
            ViewBag.offer = offer;
            return View(product);
        }
        public ActionResult about()
        {
            return View();
        }
    }
}