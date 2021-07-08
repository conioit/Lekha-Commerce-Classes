using LekhaCommerceClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LekhaCommerceClasses.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        LekhaCommerceClassesEntities db = new LekhaCommerceClassesEntities();
        public ActionResult subjectList()
        {
            if (Session["userid"] != null)
            {
                var list = db.tbl_SubjectMaster.ToList();
                ViewBag.list = list;
                return View();
            }
            else
            {
                return RedirectToAction("Login","Auth");
            }
        }
        public ActionResult AddSubject()
        {
            if (Session["userid"] != null)
            {
                var courseList = db.tbl_CourseManagment.Where(X => X.IsActive == true).ToList().Select(x => new SelectListItem { Text = x.CourseName, Value = x.Id.ToString() }).ToList();
                ViewBag.courseList = courseList;
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Auth");
            }
        }
        [HttpPost]
        public ActionResult AddSubject(tbl_subCourses tbl)
        {
            var courseList = db.tbl_CourseManagment.Where(X => X.IsActive == true).ToList().Select(x => new SelectListItem { Text = x.CourseName, Value = x.Id.ToString() }).ToList();
            ViewBag.courseList = courseList;
            if (Session["userid"] != null)
            {
                var isalreadyExist = db.tbl_subCourses.Where(x => x.SubCourseName == tbl.SubCourseName).FirstOrDefault();
                if (isalreadyExist == null)
                {
                    tbl.IsActive = true;
                    tbl.StartDate = DateTime.Now;
                    tbl.CreatedDate = DateTime.Now;
                    db.tbl_subCourses.Add(tbl);
                    db.SaveChanges();
                    TempData["message"] = "New Sub Course Added Successfully";
                    return RedirectToAction("subCourseList");
                }
                else
                {
                    ViewBag.message = "This Sub Course Name is already exist";
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