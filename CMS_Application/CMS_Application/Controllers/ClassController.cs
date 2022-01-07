using CMS_Applicaion.Models;
using CMS_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Announcements(int id, int cid)
        {
            ClassDataObject c = new ClassDataObject();
            Class class1 = new Class();
            class1 = c.FindClass(cid);
            List<Class> l = new List<Class>();
            l.Add(class1);
            StudentDataObject sb = new StudentDataObject();
            Student s = sb.UserInfo(id);
            s.Courses = l;
            return View("Announcements", s);
        }
        public ViewResult AddSubject(int id)
        {
            StudentDataObject s = new StudentDataObject();
            Student stu = s.UserInfo(id);
            ClassDataObject c = new ClassDataObject();
            stu.Courses = c.AllCourses();
            return View("AddSubject", stu);
        }
        public ViewResult SearchCourseClasses(string c1, int id)
        {
            StudentDataObject s = new StudentDataObject();
            ClassDataObject c = new ClassDataObject();
            Student stu = new Student();
            stu = s.UserInfo(id);
            stu.Courses = c.CourseClasses(c1);
            return View("CourseClasses", stu);
        }
        public ViewResult DropSubject(int id)
        {
            StudentDataObject s = new StudentDataObject();
            Student stu = s.UserInfo(id);
            ClassDataObject c = new ClassDataObject();
            stu.Courses = s.StudentAllCurrentCourses(id);
            return View("DropSubject", stu);
        }
        public ViewResult SearchDropCourse(string c1, int id)
        {
            StudentDataObject s = new StudentDataObject();
            ClassDataObject c = new ClassDataObject();
            Student stu = new Student();
            stu = s.UserInfo(id);
            stu.Courses = c.CourseClasses(c1);
            return View("DropRequest", stu);
        }
    }
}
