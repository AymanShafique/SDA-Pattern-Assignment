using CMS_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Controllers
{
    public class TeacherController : Controller
    {
        public ViewResult HomePage(Teacher t)
        {
            t.Courses = t.AllCurrentCourses(t.Id);
            return View("MainPage", t);
        }
        public ViewResult ShowHomePage(int id)
        {
            Teacher t = new Teacher();
            t = t.TeacherInfo(id);
            t.Courses = t.AllCurrentCourses(t.Id);
            return View("MainPage", t);
        }
    }
}
