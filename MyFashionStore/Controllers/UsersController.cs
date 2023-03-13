using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFashionStore.Models;

namespace MyFashionStore.Controllers
{
    public class UsersController : Controller
    {
        FashionContext db = new FashionContext();
        // GET: Users
        public ActionResult Regester()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Regester(User s,HttpPostedFileBase img)
        {
           
            
            User user = db.Users.Where(n => n.email == s.email).FirstOrDefault();
            if(user!=null)
            {
                ViewBag.status = "This E-mail is exist!!!";
                return View();
            }
            else
            {
                if(img!=null)
                {
                    img.SaveAs(Server.MapPath("~/attach/" + img.FileName));
                    s.user_photo = img.FileName;
                    db.Users.Add(s);
                    db.SaveChanges();
                    return RedirectToAction("login");
                }
                return View();
            }
        }

        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(User s)
        {
            User d = db.Users.Where(n => n.email == s.email && n.password==s.password).SingleOrDefault();
            if (d != null && d.email == "admin@gmail.com")
            {
                Session.Add("adminId", d.user_id);
                return RedirectToAction("AdminPage", "Admin");
            }
            if (d!=null)
            {
                Session.Add("userID", d.user_id);
                return RedirectToAction("product", "Products");
            }
            else
            {
                ViewBag.status = "Invaled E-mail OR Password!!!";
                return View();
            }
        }
    }
}