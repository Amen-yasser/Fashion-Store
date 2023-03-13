using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFashionStore.Models;


namespace MyFashionStore.Controllers
{
   
    public class AdminController : Controller
    {
        FashionContext db = new FashionContext();
        // GET: Admin
        public ActionResult AdminPage()
        {
            return View();
        }
        public ActionResult Addproduct()
        {
            //SelectList cats = new SelectList(db.Categories.ToList(), "cat_id", "cat_name");
            //var cats = db.Categories.ToList();
            ViewBag.category = db.Categories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Addproduct(Product pro, HttpPostedFileBase proImg)
        {
            if(proImg!=null)
            {
                proImg.SaveAs(Server.MapPath($"~/imageForShow/{proImg.FileName}"));
                pro.product_photo = proImg.FileName;
                db.Products.Add(pro);
                db.SaveChanges();
                return View();
            }
            else
            {
                return View();
            }

        }
    }
}