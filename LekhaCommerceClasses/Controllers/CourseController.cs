using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LekhaCommerceClasses.Models;
namespace LekhaCommerceClasses.Controllers
{
    public class CourseController : Controller
    {
        LekhaCommerceClassesEntities db = new LekhaCommerceClassesEntities();
        // GET: Course
        public ActionResult CourseList()
        {
            if (Session["userid"] != null)
            {
                var list = db.tbl_CourseManagment.ToList();
                ViewBag.list = list;
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Auth");
            }
        }
        public ActionResult AddCourse()
        {
            if (Session["userid"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Auth");
            }
        }
        [HttpPost]
        public ActionResult AddCourse(tbl_CourseManagment tbl)
        {
            if (Session["userid"] != null)
            {
                var isalreadyExist = db.tbl_CourseManagment.Where(x => x.CourseName == tbl.CourseName).FirstOrDefault();
                if(isalreadyExist==null)
                {
                    tbl.IsActive = true;
                    tbl.CreatedDate = DateTime.Now;
                    db.tbl_CourseManagment.Add(tbl);
                    db.SaveChanges();
                    TempData["message"] = "New Course Added Successfully";
                    return RedirectToAction("CourseList");
                }
                else
                {
                    ViewBag.message = "This Course Name is already exist";
                }
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Auth");
            }
        }
    }
}