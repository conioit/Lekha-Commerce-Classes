using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LekhaCommerceClasses.Models;
namespace LekhaCommerceClasses.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        LekhaCommerceClassesEntities db = new LekhaCommerceClassesEntities();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tbl_Admin tbl)
        {
            var res = db.tbl_Admin.Where(x => x.UserName == tbl.UserName && x.Password == tbl.Password && x.IsActive == true).FirstOrDefault();
            if(res!=null)
            {
                Session["userid"] = res.Id;
                Session["username"] = res.UserName;
                Session["coachingname"] = res.CoachingName;
                return RedirectToAction("dashboard");
            }
            else
            {
                ViewBag.message = "Username or Password is invalid.";
                return View();
            }
        }
        public ActionResult dashboard()
        {
            if(Session["userid"]!=null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}