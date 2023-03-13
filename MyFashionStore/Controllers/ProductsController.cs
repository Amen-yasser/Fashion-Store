using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFashionStore.Models;

namespace MyFashionStore.Controllers
{
    public class ProductsController : Controller
    {
        FashionContext db = new FashionContext();
        // GET: Products
        public ActionResult product(string st)
        {
            ViewBag.st = st;
            List<Product> pro = db.Products.ToList();
            return View(pro);
        }

        public ActionResult AddToCard(int id)
        {
            Order myOrder = new Order();
            Product myPro = db.Products.Where(n => n.product_id == id).SingleOrDefault();
            Order o = db.Orders.Where(n => n.id_product == id).FirstOrDefault();
            if(o !=null)
            {
                ViewBag.st = "already exist";
                return RedirectToAction("product",  new {st= ViewBag.st});
            }
            else
            {
                myOrder.id_product = myPro.product_id;
                myOrder.total_price = myPro.price;
                myOrder.id_user = (int)Session["userID"];
                db.Orders.Add(myOrder);
                db.SaveChanges();
                return RedirectToAction("product");
            }

        }
        public ActionResult Card()
        {
            int userid = (int)Session["userID"];
            List<Order> allOrder = db.Orders.Where(n => n.id_user == userid).ToList();
            return View(allOrder);
        }

        public ActionResult deleteItemCard(int id )
        {

            Order deletedOrder = db.Orders.Where(n => n.id_product == id).FirstOrDefault();
            db.Orders.Remove(deletedOrder);
            db.SaveChanges();
            return RedirectToAction("Card");
        }

    }
}