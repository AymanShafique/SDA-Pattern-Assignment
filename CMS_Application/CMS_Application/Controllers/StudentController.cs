using CMS_Applicaion.Models;
using CMS_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_App.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult HomePage(Student s)
        {
            s.Courses = s.AllCurrentCourses(s.Id);
            return View("MainPage", s);
        }
        public ViewResult ShowHomePage(int id)
        {
            Student s = new Student();
            s = s.StudentInfo(id);
            s.Courses = s.AllCurrentCourses(s.Id);
            return View("MainPage", s);
        }
    }
}
